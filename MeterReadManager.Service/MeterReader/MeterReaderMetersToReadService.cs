using Azure.Messaging.ServiceBus;
using MeterReadManager.Domain.Model;
using MeterReadManager.Helper;
using MeterReadManager.Service.Interface;
using MeterReadManager.Service.Interface.MeterReader;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace MeterReadManager.Service.MeterReader
{
    public class MeterReaderMetersToReadService : IMeterReaderMetersToReadService
    {
        private readonly ILogger _logger;
        private IMeterService _meterService;

        private const int MetersToReadPageSize = 5;
        public MeterReaderMetersToReadService(ILoggerFactory loggerFactory, IMeterService meterService)
        {
            _meterService = meterService;
            _logger = loggerFactory.CreateLogger<MeterReaderMetersToReadService>();
        }

        public async Task PutMetersToReadOnServiceBusQueue()
        {
            int pageCount = 1;
            int messageCount = 1;
            int numberOfMetersToRead = _meterService.GetActiveMetersToReadCount();
            int numberOfPages = GetNumberOfPages(numberOfMetersToRead);

            _logger.LogInformation("Number of meters to put on queue to read: {0}", numberOfMetersToRead);
            _logger.LogInformation("Number of pages of meters: {0}", numberOfPages);

            await using var client = new ServiceBusClient(EnvironmentVariablesHelper.AzureServiceBusMeterReadingManagementConnectionString());
            ServiceBusSender sender = client.CreateSender(EnvironmentVariablesHelper.AzureServiceBusQueueMetersToRead());
            ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();

            while (pageCount <= numberOfPages)
            {
                List<MeterToRead>? metersToRead = await _meterService.GetActiveMetersToReadAsync(pageCount, MetersToReadPageSize);

                if (metersToRead != null)
                {
                    foreach (MeterToRead meter in metersToRead)
                    {
                        ServiceBusMessage message = new ServiceBusMessage(SerializerHelper.Serialize(meter));

                        if (!messageBatch.TryAddMessage(message))
                        {
                            // Send the current batch as it is full and create a new one                            
                            await sender.SendMessagesAsync(messageBatch);
                            messageBatch.Dispose();

                            messageBatch = await sender.CreateMessageBatchAsync();

                            if (!messageBatch.TryAddMessage(message))
                            {
                                Console.WriteLine($"Failed to fit message number in a batch {TextHelper.Base64Encode(JsonConvert.SerializeObject(metersToRead))}");
                                break;
                            }
                        }

                        messageCount++;
                    }
                }

                pageCount++;

                if (messageCount >= numberOfMetersToRead)
                    break;
            }

            await sender.SendMessagesAsync(messageBatch);
            messageBatch.Dispose();

            _logger.LogInformation("Number of meters put on queue: {0}", messageCount - 1);
        }

        private int GetNumberOfPages(int numberOfMetersToRead)
        {
            return numberOfMetersToRead / MetersToReadPageSize + (numberOfMetersToRead % MetersToReadPageSize == 0 ? 0 : 1);
        }
    }
}

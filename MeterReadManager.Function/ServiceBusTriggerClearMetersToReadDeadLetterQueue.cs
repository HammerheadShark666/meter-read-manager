using MeterReadManager.Helper;
using Microsoft.Azure.Functions.Worker;

namespace MeterReadManager.Function
{
    public class ServiceBusTriggerClearMetersToReadDeadLetterQueue
    { 
        public ServiceBusTriggerClearMetersToReadDeadLetterQueue() {}

        [Function("ServiceBusTriggerClearMetersToReadDeadLetterQueue")]
        public void Run([ServiceBusTrigger($"%{Constants.AzureServiceBusQueueMetersToRead}%/$DeadLetterQueue", Connection = Constants.AzureServiceBusMeterReadingManagementConnectionString)] string daedLetterItem)
        {
            
        }
    }
}

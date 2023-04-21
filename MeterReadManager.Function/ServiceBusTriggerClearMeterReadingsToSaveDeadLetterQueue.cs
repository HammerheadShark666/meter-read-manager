using MeterReadManager.Helper;
using Microsoft.Azure.Functions.Worker;

namespace MeterReadManager.Function
{
    public class ServiceBusTriggerClearMeterReadingsToSaveDeadLetterQueue
    { 
        public ServiceBusTriggerClearMeterReadingsToSaveDeadLetterQueue() {}

        [Function("ServiceBusTriggerClearMeterReadingsToSaveDeadLetterQueue")]
        public void Run([ServiceBusTrigger($"%{Constants.AzureServiceBusQueueMeterReadingsToSave}%/$DeadLetterQueue", Connection = Constants.AzureServiceBusMeterReadingManagementConnectionString)] string daedLetterItem)
        {
            
        }
    }
}

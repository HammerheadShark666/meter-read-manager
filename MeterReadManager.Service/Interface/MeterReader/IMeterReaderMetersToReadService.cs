namespace MeterReadManager.Service.Interface.MeterReader
{
    public interface IMeterReaderMetersToReadService
    {
        Task PutMetersToReadOnServiceBusQueue();
    }
}

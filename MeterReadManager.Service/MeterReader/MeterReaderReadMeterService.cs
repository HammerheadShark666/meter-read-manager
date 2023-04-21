using MeterReadManager.Domain.Model;
using MeterReadManager.Helper;
using MeterReadManager.Helper.Interface;
using MeterReadManager.Service.Interface.MeterReader;
using Microsoft.Extensions.Logging;

namespace MeterReadManager.Service.MeterReader;

public class MeterReaderReadMeterService : BaseMeterReader<MeterToRead>, IMeterReaderReadMeterService
{
    private readonly IMeterReaderReadMeterSimulator _readMeterSimulator;

    public MeterReaderReadMeterService(ILogger<MeterReaderReadMeterService> logger, IMeterReaderReadMeterSimulator readMeterSimulator, IDeserializeToObject<MeterToRead> deserializer, IMeterReaderFailedMeterReadingService meterReaderFailedMeterReadingService)
                                        : base(logger, deserializer, meterReaderFailedMeterReadingService)
    {
        _readMeterSimulator = readMeterSimulator;
    }

    public string ReadMeter(string meter)
    {
        MeterToRead? meterToRead = _deserializer.Deserialize(meter);
        if (meterToRead != null)
        {
            SimulatedMeterReading simulatedMeterReading = _readMeterSimulator.SimulateReading(meterToRead);
            return SerializerHelper.Serialize(simulatedMeterReading);
        }

        throw new Exception("Error occurred reading meter.");
    }
}
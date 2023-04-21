using MeterReadManager.Data.UnitOfWork.Interfaces;
using MeterReadManager.Domain;
using MeterReadManager.Domain.Model;
using MeterReadManager.Service.Interface.MeterReader;
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;

namespace MeterReadManager.Service.MeterReader;

public class MeterReaderReadMeterSimulatorService : IMeterReaderReadMeterSimulator
{
    private readonly ILogger _logger;
    private readonly IUnitOfWork _unitOfWork;

    public MeterReaderReadMeterSimulatorService(ILoggerFactory loggerFactory, IUnitOfWork unitOfWork) 
    {
        _logger = loggerFactory.CreateLogger<MeterReaderMetersToReadService>();
        _unitOfWork = unitOfWork;
    }

    public SimulatedMeterReading SimulateReading(MeterToRead meterToRead)
    {
        MeterReading? lastMeterReading = _unitOfWork.MeterReadings.GetLastMeterReading(meterToRead.MeterNumber);

        if (meterToRead.MeterNumber == "426565606")
            throw new Exception($"Meter reading timeout: {meterToRead.MeterNumber}");

        SimulatedMeterReading simulatedMeterReading = new SimulatedMeterReading()
        {
            MeterId = meterToRead.MeterId,
            MeterNumber = meterToRead.MeterNumber,
            DateTime = DateTime.Now,
            Value = getMeterReadingValueAsync(lastMeterReading)
        };

        return simulatedMeterReading;
    }

    private decimal getMeterReadingValueAsync(MeterReading? lastMeterReading)
    {
        return lastMeterReading == null
            ? GetMeterReadingIncrementValue()
            : lastMeterReading.Value += GetMeterReadingIncrementValue();
    }

    private decimal GetMeterReadingIncrementValue()
    {
        RandomNumberGenerator.Create();
        var denominator = RandomNumberGenerator.GetInt32(1, 200);
        decimal sDecimal = (decimal)100 / denominator;
        return sDecimal;
    }
}
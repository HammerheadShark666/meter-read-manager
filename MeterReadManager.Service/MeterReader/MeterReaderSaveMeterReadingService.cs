using AutoMapper;
using MeterReadManager.Data.UnitOfWork.Interfaces;
using MeterReadManager.Domain;
using MeterReadManager.Domain.Model;
using MeterReadManager.Helper;
using MeterReadManager.Helper.Interface;
using MeterReadManager.Service.Interface.MeterReader;
using Microsoft.Extensions.Logging;

namespace MeterReadManager.Service.MeterReader;
public class MeterReaderSaveMeterReadingService : BaseMeterReader<SimulatedMeterReading>, IMeterReaderSaveMeterReadingService
{ 
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper; 

    public MeterReaderSaveMeterReadingService(ILogger<MeterReaderSaveMeterReadingService> logger, IUnitOfWork unitOfWork, IMapper mapper, IDeserializeToObject<SimulatedMeterReading> deserializer, IMeterReaderFailedMeterReadingService meterReaderFailedMeterReadingService) 
                                                    : base(logger, deserializer, meterReaderFailedMeterReadingService)
    {         
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task SaveMeterReadingAsync(SimulatedMeterReading simulatedMeterReading)
    {       
        if (simulatedMeterReading != null)
        {
            if(simulatedMeterReading.MeterNumber == "153397458")
                throw new Exception("Database not found.");            

            _unitOfWork.MeterReadings.Add(_mapper.Map<SimulatedMeterReading, MeterReading>(simulatedMeterReading, new MeterReading()));
            _unitOfWork.ReadingLogs.Add(ReadingLogService.CreateReadingLog(simulatedMeterReading.MeterId, simulatedMeterReading.DateTime, true, Constants.MeterReadingLogStatus));
            await _unitOfWork.Complete();
        }
    }
}

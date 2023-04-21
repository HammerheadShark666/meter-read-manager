using MeterReadManager.Domain;
using MeterReadManager.Domain.Dto;
using MeterReadManager.Domain.Model;
using MeterReadManager.Domain.Model.Authentication;

namespace MeterReadManager.Helper;

public class AutoMapperProfile : AutoMapper.Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Account, AccountDto>();
        CreateMap<AccountDto, Account>(); 
         
        base.CreateMap<Account, LoginDto>()
            .ForMember(dest => dest.IsAuthenticated, act => act.MapFrom(src => src.IsAuthenticated));

        base.CreateMap<Account, JwtRefreshTokenDto>()
            .ForPath(dest => dest.User.LastName, opts => opts.MapFrom(src => src.LastName))
            .ForPath(dest => dest.User.FirstName, opts => opts.MapFrom(src => src.FirstName))
            .ForPath(dest => dest.User.Title, opts => opts.MapFrom(src => src.Title))
            .ForPath(dest => dest.User.Email, opts => opts.MapFrom(src => src.Email))
            .ForPath(dest => dest.User.Role, opts => opts.MapFrom(src => src.Role))
            .ForMember(dest => dest.IsAuthenticated, act => act.MapFrom(src => src.IsAuthenticated));





        CreateMap<Account, User>();

        //CreateMap<ResetPassword, ResetPasswordDto>();

        //CreateMap<ResetPasswordDto, ResetPassword>();

        CreateMap<Register, Account>();

        //CreateMap<Register, RegisterDto>();

        //CreateMap<RegisterDto, Register>();

        CreateMap<Login, LoginDto>();

        CreateMap<LoginDto, Login>();

        CreateMap<JwtRefreshToken, JwtRefreshTokenDto>();

        CreateMap<JwtRefreshTokenDto, JwtRefreshToken>();

        //CreateMap<RegisterVerifyEmailDto, RegisterVerifyEmail>();

        //CreateMap<RegisterVerifyEmail, RegisterVerifyEmailDto>();

        CreateMap<Customer, CustomerDto>();

        CreateMap<CustomerDto, Customer>();

        CreateMap<County, CountyDto>();

        CreateMap<CountyDto, County>();

        CreateMap<MeterReading, Domain.Dto.MeterReadingDto>();

        CreateMap<Domain.Dto.MeterReadingDto, MeterReading>();

        CreateMap<ReadingLog, ReadingLogDto>();

        CreateMap<ReadingLogDto, ReadingLog>();

        CreateMap<ReadingLogEntry, ReadingLogEntryDto>();

        CreateMap<SimulatedMeterReading, MeterReading>();

        base.CreateMap<MeterToRead, FailedMeterToRead>()
            .ForPath(dest => dest.MeterId, opts => opts.MapFrom(src => src.MeterId))
            .ForPath(dest => dest.MeterNumber, opts => opts.MapFrom(src => src.MeterNumber));


        base.CreateMap<SimulatedMeterReading, FailedMeterToRead>()
            .ForPath(dest => dest.MeterId, opts => opts.MapFrom(src => src.MeterId))
            .ForPath(dest => dest.MeterNumber, opts => opts.MapFrom(src => src.MeterNumber));
    }
}

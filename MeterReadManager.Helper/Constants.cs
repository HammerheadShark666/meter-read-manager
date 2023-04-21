namespace MeterReadManager.Helper;

public class Constants
{                                               
    public const string DatabaseConnectionString = "SQLAZURECONNSTR_METER_READ_MANAGER"; 

    public const string AzureServiceBusMeterReadingManagementConnectionString = "SERVICE_BUS_METER_READING_MANAGEMENT_CONNECTION_STRING";
    public const string AzureServiceBusQueueMetersToRead = "SERVICE_BUS_QUEUE_METERS_TO_READ";
    public const string AzureServiceBusQueueMeterReadingsToSave = "SERVICE_BUS_QUEUE_METER_READINGS_TO_SAVE";
    public const string AzureServiceBusQueueFailedMeterReadings = "SERVICE_BUS_QUEUE_FAILED_METER_READINGS";
    public const string AzureTriggerTimerMetersToRead = "METERS_TO_READ_TRIGGER_TIMER";

    public const string SendGridApiKey = "SENDGRID_CONNECTION_STRING";
    public const string SendGridDefaultFromEmail = "SENDGRID_DEFAULT_FROM_EMAIL";

    public const string JwtSettingsSercret = "JWT_SETTINGS_SECRET";
    public const string JwtSettingsRefreshTokenTtl = "JWT_SETTINGS_REFRESH_TOKEN_TTL";
    public const string JwtSettingsTokenExpiryMinutes = "JWT_SETTINGS_TOKEN_EXPIRY_MINUTES";
    public const string JwtSettingsRefreshTokenExpiryDays = "JWT_SETTINGS_REFRESH_TOKEN_EXPIRY_DAYS";
    public const string JwtSettingsPasswordTokenExpiryDays = "JWT_SETTINGS_RESET_PASSWORD_TOKEN_EXPIRY_DAYS";

    public const string MeterReadingLogStatus = "Successful";
}
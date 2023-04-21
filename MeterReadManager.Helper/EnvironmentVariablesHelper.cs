using System;

namespace MeterReadManager.Helper;

public class EnvironmentVariablesHelper
{
    public static string? SendGridApiKey()
    {
        return Environment.GetEnvironmentVariable(Constants.SendGridApiKey);
    }

    public static string? SendGridDefaultFromEmail()
    {
        return Environment.GetEnvironmentVariable(Constants.SendGridDefaultFromEmail);
    }

    //public static string? AzureStorageConnectionString()
    //{
    //    return Environment.GetEnvironmentVariable(Constants.AzureStorageConnectionString);
    //}

    public static string? JwtSettingsSercret()
    {
        return Environment.GetEnvironmentVariable(Constants.JwtSettingsSercret);
    }

    public static int JwtSettingsRefreshTokenTtl()
    {
        return Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsRefreshTokenTtl));
    }

    public static int JwtSettingsTokenExpiryMinutes()
    {
        return Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsTokenExpiryMinutes));
    }

    public static int JwtSettingsRefreshTokenExpiryDays()
    {
        return Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsRefreshTokenExpiryDays));
    }

    //public static int JwtSettingsPasswordTokenExpiryDays()
    //{
    //    return Convert.ToInt16(Environment.GetEnvironmentVariable(Constants.JwtSettingsPasswordTokenExpiryDays));
    //}
    //public static string? AzureStorageQueueConnection()
    //{
    //    return Environment.GetEnvironmentVariable(Constants.AzureStorageQueueConnection);
    //}

    //public static string? AzureStorageQueue()
    //{
    //    return Environment.GetEnvironmentVariable(Constants.AzureStorageQueue);
    //}

    public static string? AzureServiceBusMeterReadingManagementConnectionString() {
        return Environment.GetEnvironmentVariable(Constants.AzureServiceBusMeterReadingManagementConnectionString);
    }

    public static string? AzureServiceBusQueueMetersToRead()
    {
        return Environment.GetEnvironmentVariable(Constants.AzureServiceBusQueueMetersToRead);
    }

    public static string? AzureServiceBusQueueFailedMeterReadings()
    {
        return Environment.GetEnvironmentVariable(Constants.AzureServiceBusQueueFailedMeterReadings);
    }
}

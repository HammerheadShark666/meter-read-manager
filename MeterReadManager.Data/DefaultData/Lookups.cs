using MeterReadManager.Domain;

namespace MeterReadManager.Data.DefaultData;

public class Lookups
{
    public static List<Country> GetCountryDefaultData()
    {
        return new List<Country>()
        {
            new Country { Id = 1, Name = "England" },
            new Country { Id = 2, Name = "Scotland" },
            new Country { Id = 3, Name = "Wales" },
            new Country { Id = 4, Name = "Northern Ireland" } 
        };
    }
     
    public static List<County> GetCountyDefaultData()
    {
        Country england = new Country() { Id = 1, Name = "England" };
        Country scotland = new Country() { Id = 2, Name = "Scotland" };
        Country wales = new Country() { Id = 3, Name = "Wales" };
        Country northernIreland = new Country() { Id = 4, Name = "Northern Ireland" };

        return new List<County>()
        {
            new County { Id = 1, Name = "West Yorkshire",  CountryId = england.Id },
            new County { Id = 2, Name = "North Yorkshire", CountryId = england.Id },
            new County { Id = 3, Name = "Aberdeenshire", CountryId = scotland.Id },
            new County { Id = 4, Name = "Ross and Cromarty", CountryId = scotland.Id },
            new County { Id = 5, Name = "Breconshire", CountryId = wales.Id },
            new County { Id = 6, Name = "Gwynedd", CountryId = wales.Id },
            new County { Id = 7, Name = "Armagh", CountryId = northernIreland.Id },
            new County { Id = 8, Name = "Londonderry", CountryId = northernIreland.Id },
        };
    }

    public static List<MeterType> GetMeterTypeDefaultData()
    {
        return new List<MeterType>()
        {
            new MeterType { Id = 1, Name = "Electric" },
            new MeterType { Id = 2, Name = "Gas" },
            new MeterType { Id = 3, Name = "Water" },
            new MeterType { Id = 4, Name = "Gas/Electric" }
        };
    }
}

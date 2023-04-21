using MeterReadManager.Domain;

namespace MeterReadManager.Data.DefaultData;

public class Meters
{
    public static List<Meter> GetMeterDefaultData()
    {
        MeterType electricMeter = new MeterType { Id = 1, Name = "Electric" };
        MeterType gasMeter = new MeterType { Id = 2, Name = "Gas" };
        MeterType waterMeter = new MeterType { Id = 3, Name = "Water" };
        MeterType gasElectricMeter = new MeterType { Id = 4, Name = "Gas/Electric" };

        return new List<Meter>()
        {
            new Meter { Id = 1, MeterNumber = "234378901", Location = "1 Main Street, Laoth", MeterTypeId = electricMeter.Id, CustomerId = 1, AccountId = 2, Active = true },
            new Meter { Id = 2, MeterNumber = "234378902", Location = "2 Main Street, Laoth", MeterTypeId = electricMeter.Id, CustomerId = 1, AccountId = 2, Active = true },
            new Meter { Id = 3, MeterNumber = "234378903", Location = "3 Main Street, Laoth", MeterTypeId = electricMeter.Id, CustomerId = 1, AccountId = 2, Active = true },
            new Meter { Id = 4, MeterNumber = "234378904", Location = "4 Main Street, Laoth", MeterTypeId = electricMeter.Id, CustomerId = 1, AccountId = 2, Active = true },

            new Meter { Id = 5, MeterNumber = "426565605", Location = "1 Main Street, Laoth",MeterTypeId = gasMeter.Id, CustomerId = 2, AccountId = 2, Active = true },
            new Meter { Id = 6, MeterNumber = "426565606", Location = "2 Main Street, Laoth",MeterTypeId = gasMeter.Id, CustomerId = 2, AccountId = 2, Active = true },
            new Meter { Id = 7, MeterNumber = "426565607", Location = "3 Main Street, Laoth",MeterTypeId = gasMeter.Id, CustomerId = 2, AccountId = 2, Active = true },
            new Meter { Id = 8, MeterNumber = "426565608", Location = "4 Main Street, Laoth",MeterTypeId = gasMeter.Id, CustomerId = 2, AccountId = 2, Active = true },

            new Meter { Id = 9, MeterNumber = "542356015",  Location = "1 Main Street, Laoth",MeterTypeId = waterMeter.Id,  CustomerId = 3, AccountId = 2, Active = true },
            new Meter { Id = 10, MeterNumber = "683534603", Location = "2 Main Street, Laoth",MeterTypeId = waterMeter.Id, CustomerId = 3, AccountId = 2, Active = true },
            new Meter { Id = 11, MeterNumber = "823234647", Location = "3 Main Street, Laoth",MeterTypeId = waterMeter.Id, CustomerId = 3, AccountId = 2, Active = true },
            new Meter { Id = 12, MeterNumber = "453459768", Location = "4 Main Street, Laoth",MeterTypeId = waterMeter.Id, CustomerId = 3, AccountId = 2, Active = true },

            new Meter { Id = 13, MeterNumber = "956756343", Location = "10 Lower Lane, Heaton", MeterTypeId = gasElectricMeter.Id, CustomerId = 4, AccountId = 3, Active = true },
            new Meter { Id = 14, MeterNumber = "956756344", Location = "11 Lower Lane, Heaton", MeterTypeId = gasElectricMeter.Id, CustomerId = 4, AccountId = 3, Active = true },
            new Meter { Id = 15, MeterNumber = "956756345", Location = "12 Lower Lane, Heaton", MeterTypeId = gasElectricMeter.Id, CustomerId = 4, AccountId = 3, Active = true },
            new Meter { Id = 16, MeterNumber = "956756346", Location = "13 Lower Lane, Heaton", MeterTypeId = gasElectricMeter.Id, CustomerId = 4, AccountId = 3, Active = true },

            new Meter { Id = 17, MeterNumber = "532787542", Location = "14 Marlon Lane, Larchfield", MeterTypeId = gasMeter.Id, CustomerId = 5, AccountId = 3, Active = true },
            new Meter { Id = 18, MeterNumber = "532787548", Location = "15 Marlon Lane, Larchfield", MeterTypeId = electricMeter.Id, CustomerId = 5, AccountId = 3, Active = true },
            new Meter { Id = 19, MeterNumber = "532787549", Location = "16 Marlon Lane, Larchfield", MeterTypeId = waterMeter.Id, CustomerId = 5, AccountId = 3, Active = true },
            new Meter { Id = 20, MeterNumber = "532787545", Location = "17 Marlon Lane, Larchfield", MeterTypeId = gasMeter.Id, CustomerId = 5, AccountId = 3, Active = true },

            new Meter { Id = 21, MeterNumber = "532787345", Location = "18 Jones Close, Kilton", MeterTypeId = gasMeter.Id, CustomerId = 6, AccountId = 3, Active = true },
            new Meter { Id = 22, MeterNumber = "532784567", Location = "19 Jones Close, Kilton", MeterTypeId = gasMeter.Id, CustomerId = 6, AccountId = 3, Active = true },
            new Meter { Id = 23, MeterNumber = "532781144", Location = "20 Jones Close, Kilton", MeterTypeId = waterMeter.Id, CustomerId = 6, AccountId = 3, Active = true },
            new Meter { Id = 24, MeterNumber = "532783474", Location = "21 Jones Close, Kilton", MeterTypeId = gasMeter.Id, CustomerId = 6, AccountId = 3, Active = true },

            new Meter { Id = 25, MeterNumber = "153397451", Location = "38 Derby Street, Milton", MeterTypeId = electricMeter.Id, CustomerId = 7, AccountId = 3, Active = true },
            new Meter { Id = 26, MeterNumber = "153397450", Location = "42 Derby Street, Milton", MeterTypeId = gasMeter.Id, CustomerId = 7, AccountId = 3, Active = true },
            new Meter { Id = 27, MeterNumber = "153397454", Location = "53 Derby Street, Milton", MeterTypeId = electricMeter.Id, CustomerId = 7, AccountId = 3, Active = true },
            new Meter { Id = 28, MeterNumber = "153397458", Location = "62 Derby Street, Milton", MeterTypeId = gasMeter.Id, CustomerId = 7, AccountId = 3, Active = true },

            new Meter { Id = 29, MeterNumber = "812234863", Location = "118 Harly Avenue, Olton", MeterTypeId = waterMeter.Id, CustomerId = 8, AccountId = 3, Active = true },
            new Meter { Id = 30, MeterNumber = "812234236", Location = "119 Harly Avenue, Olton", MeterTypeId = gasMeter.Id, CustomerId = 8, AccountId = 3, Active = true },
            new Meter { Id = 31, MeterNumber = "812234908", Location = "120 Harly Avenue, Olton", MeterTypeId = electricMeter.Id, CustomerId = 8, AccountId = 3, Active = true },
            new Meter { Id = 32, MeterNumber = "812234631", Location = "121 Harly Avenue, Olton", MeterTypeId = waterMeter.Id, CustomerId = 8, AccountId = 3, Active = true },
        };
    }
}

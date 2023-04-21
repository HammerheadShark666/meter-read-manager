using MeterReadManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeterReadManager.Data.DefaultData;

public class Customers
{
    public static List<Customer> GetCustomerDefaultData()
    {
        Country england = new Country() { Id = 1, Name = "England" };
        Country scotland = new Country() { Id = 1, Name = "Scotland" };
        Country wales = new Country() { Id = 1, Name = "Wales" };
        Country northernIreland = new Country() { Id = 1, Name = "Northern Ireland" };

        County westYorkshire = new County { Id = 1, Name = "West Yorkshire", Country = england };
        County northYorkshire = new County { Id = 2, Name = "North Yorkshire", Country = england };
        County aberdeenshire = new County { Id = 3, Name = "Aberdeenshire", Country = scotland };
        County rossAndCromarty = new County { Id = 4, Name = "Ross and Cromarty", Country = scotland };
        County breconshire = new County { Id = 5, Name = "Breconshire", Country = wales };
        County gwynedd = new County { Id = 6, Name = "Gwynedd", Country = wales };
        County armagh = new County { Id = 7, Name = "Armagh", Country = northernIreland };
        County londonderry = new County { Id = 8, Name = "Londonderry", Country = northernIreland };
         
        return new List<Customer>()
        {
            new Customer { Id = 1, Surname = "Jones", FirstName = "Jackie", Email = "jackie.jones@hotmail.com", Address1 = "24 Long Road", Address2 = "Carlton", Address3  = "East Town", CityTown  = "Leeds", CountyId = westYorkshire.Id, Postcode  = "LS4 RH4", },
            new Customer { Id = 2, Surname = "Patel", FirstName = "Ahmed", Email = "ahmed.patel@hotmail.com", Address1 = "1 Catoral Close", Address2 = "Grangestone", Address3  = "Lower Baildon", CityTown  = "York", CountyId = northYorkshire.Id, Postcode  = "BD34 F45", },
            new Customer { Id = 3, Surname = "Amos", FirstName = "Tony", Email = "tony.amos@@hotmail.com", Address1 = "143 Short Street", Address2 = "Middleton", Address3  = null, CityTown  = "Aberdeen", CountyId = aberdeenshire.Id, Postcode  = "AD6 CE3", },
            new Customer { Id = 4, Surname = "Green", FirstName = "Jane", Email = "jane.green@hotmail.com", Address1 = "28 Brush Lane", Address2 = "West Town", Address3  = null, CityTown  = "Inverurie", CountyId = rossAndCromarty.Id, Postcode  = "RS3 NT5", },
            new Customer { Id = 5, Surname = "Bernstien", FirstName = "Keith", Email = "keith.bernstien@hotmail.com", Address1 = "65 Carlton Avenue", Address2 = "Cawley", Address3  = null, CityTown  = "Hay-on-Wye", CountyId = breconshire.Id, Postcode  = "HY09 PL9", },
            new Customer { Id = 6, Surname = "Harper", FirstName = "Jenny", Email = "jenny.harper@hotmail.com", Address1 = "36 Mixen Lane", Address2 = "Soothill", Address3  = null, CityTown  = "Brecon", CountyId = gwynedd.Id, Postcode  = "BR2 KB2", },
            new Customer { Id = 7, Surname = "Denny", FirstName = "Sandy", Email = "sandy.denny@hotmail.com", Address1 = "5 Margton Street", Address2 = "Niverton", Address3  = null, CityTown  = "Bannfoot", CountyId = armagh.Id, Postcode  = "BN6 CG5", },
            new Customer { Id = 8, Surname = "Opsoto", FirstName = "Brian", Email = "brian.opsoto@hotmail.com", Address1 = "84 Hollow Avenue", Address2 = "Overton", Address3  = null, CityTown  = "Bessbrook", CountyId = londonderry.Id, Postcode  = "BN1 SC3", }
        };
    }
}
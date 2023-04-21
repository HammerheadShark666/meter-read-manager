﻿namespace MeterReadManager.Domain.Dto;

public class CustomerDto : BaseDto
{   
    public long Id { get; set; }
 
    public string Surname { get; set; }
 
    public string FirstName { get; set; }
        
    public string Email { get; set; }
      
    public string Address1 { get; set; }

    public string Address2 { get; set; }

    public string Address3 { get; set; }

    public string CityTown { get; set; }

    public long CountyId { get; set; }

    public County County { get; set; }

    public string Postcode { get; set; }
}

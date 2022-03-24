using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Models
{
    public class Country: BaseClass
    {
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso  { get; set; }
    public  List<CountryDetail> CountryDetails { get; set; }
    }

}

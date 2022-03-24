using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities.Models
{
    public class CountryDetail: BaseClass
    {
        public string Operator { get; set; }
        public string OperatorCode { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
    }
}

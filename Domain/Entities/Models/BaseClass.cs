using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Entities.Models
{
    public class BaseClass
    {
        [JsonIgnore]
        [Key]
        public int Id { get; set; }
    }
}

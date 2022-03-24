using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities.Context;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Repository.Helpers
{
    public class DataGenerator
    {


        public static void Initialize(DataContext context)
        {
           //var context = new DataContext(
           //     serviceProvider.GetRequiredService<DbContextOptions<DataContext>>());

           var check = context.Database.EnsureCreated();

           if (!check )
           {
              return;
              
           }

           
           if (context.Countries.Any())
           {
               return;   // Data was already seeded
           }


           var countries = new List<Country>()
           {
               new Country()
               {
                   Id = 1,
                   CountryCode = "234",
                   Name = "Nigeria",
                   CountryIso = "NG",
                   CountryDetails = new List<CountryDetail>()
                   {
                       new CountryDetail()
                       {
                           Operator = "MTN Nigeria",
                           OperatorCode = "MTN NG",
                           CountryId = 1
                       },
                       new CountryDetail()
                       {
                           Operator = "Airtel Nigeria ",
                           OperatorCode = "ANG",
                           CountryId = 1
                       },
                       new CountryDetail()
                       {
                           Operator = "9 Mobile Nigeria ",
                           OperatorCode = "ETN",
                           CountryId = 1
                       },
                       new CountryDetail()
                       {
                           Operator = "Globacom Nigeria ",
                           OperatorCode = "GLO NG",
                           CountryId = 1
                       }
                   },
               },
               new Country()
               {
                   Id = 2,
                   Name = "Ghana",
                   CountryIso  = "GH",
                   CountryCode = "233",
                   CountryDetails = new List<CountryDetail>()
                   {
                       new CountryDetail()
                       {
                           Operator = "Vodafone Ghana",
                           OperatorCode = "Vodafone GH",
                           CountryId = 2
                       },
                       new CountryDetail()
                       {
                           Operator = "MTN Ghana",
                           OperatorCode = "MTN Ghana",
                           CountryId = 2
                       },
                       new CountryDetail()
                       {
                           Operator = "Tigo Ghana",
                           OperatorCode = "Tigo Ghana",
                           CountryId = 2
                       }
                   },
               },
               new Country()
               {
                   Id = 3,
                   Name = "Benin Republic",
                    CountryIso = "BN",
                    CountryCode  = "229",
                   CountryDetails = new List<CountryDetail>()
                   {
                       new CountryDetail()
                       {
                           Operator = "MTN Benin",
                           OperatorCode = "MTN Benin",
                           CountryId = 3
                       },
                       new CountryDetail()
                       {
                           Operator = "Moov Benin",
                           OperatorCode = "Moov Benin",
                           CountryId = 3
                       }
                   },
               },
               new Country()
               {
                   Id = 4,
                   Name = "Côte d'Ivoire",
                   CountryIso = "CIV",
                    CountryCode = "225",
                   CountryDetails = new List<CountryDetail>()
                   {
                       new CountryDetail()
                       {
                           Operator = "MTN Côte d'Ivoire",
                           OperatorCode = "MTN CIV",
                           CountryId = 4
                       }
                   },
               }
           };

           context.Countries.AddRange(
               countries

           );

           context.SaveChanges();
        }

       
    }
}

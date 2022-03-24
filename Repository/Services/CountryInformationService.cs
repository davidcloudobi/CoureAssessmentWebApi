using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Context;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using Repository.Response;

namespace Repository.Services
{
    public class CountryInformationService : ICountryInformation
    {
        public CountryInformationService(DataContext context)
        {
            Context = context;
        }

        public DataContext Context { get; set; }

        public async Task<GlobalResponse<List<Country>>> GetCountriesDetails(string phoneNumber)
        {


            if (string.IsNullOrEmpty(phoneNumber))
            {
                return new GlobalResponse<List<Country>>()
                {
                    Message = "Phone number is empty or null"
                };
            }

            if (!int.TryParse(phoneNumber, out var result))
            {
                return new GlobalResponse<List<Country>>()
                {
                    Message = "Phone number invalid"
                };
            }

            // Assuming the first 3 digits is the country code 
            // From Wikipedia, The least length of a phone number is 4, with a country code of 3, this makes the minimum length of any phone number 7
            if (phoneNumber.Length <= 7)
            {
                return new GlobalResponse<List<Country>>()
                {
                    Message = "Invalid Phone number length"
                };
            }

            var code = phoneNumber.Substring(0, 3);


            var countries = await  (from country in Context.Countries
                let details = (Context.CountryDetails.Where(x => x.CountryId == country.Id).ToList())
                where country.CountryCode == code
                select new Country()
                {
                    CountryCode = country.CountryCode,
                    CountryIso = country.CountryIso,
                    Name = country.Name,
                    CountryDetails = details
                }).ToListAsync();


           //await Context.Countries.Where(x => x.CountryCode == code).ToListAsync();


            return new GlobalResponse<List<Country>>()
            {
                Status = true,
                Message = "successful",
                Data = countries
            };
        }
    }
}

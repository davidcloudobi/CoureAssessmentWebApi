using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities.Context;
using Domain.Entities.Models;
using Repository.Response;

namespace Repository.Interfaces
{
    public interface ICountryInformation
    {
       Task<GlobalResponse<List<Country>>> GetCountriesDetails(string phoneNumber);
    }
}
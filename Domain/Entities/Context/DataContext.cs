using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.Context
{
    public class DataContext : DbContext
    {   
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryDetail> CountryDetails { get; set; }

    }
}

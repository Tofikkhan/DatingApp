using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        // constructor for data context
        public  DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; } // Values = Table name created on SQLite


    }
}

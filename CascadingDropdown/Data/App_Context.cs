using CascadingDropdown.Models.Cascade;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingDropdown.Data
{
    public class App_Context:DbContext
    {
        public App_Context(DbContextOptions<App_Context> options):base(options) { }

        public DbSet<Country> tblCountry { get; set; }
        public DbSet<State> tblState { get; set; }
        public DbSet<City> tblCity { get; set; }
    }
}

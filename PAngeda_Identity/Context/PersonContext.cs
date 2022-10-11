
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAngeda_Identity.Models;

namespace PAngeda_Identity.Context
{
    internal class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}




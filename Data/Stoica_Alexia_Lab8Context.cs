using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stoica_Alexia_Lab8.Models;

namespace Stoica_Alexia_Lab8.Data
{
    public class Stoica_Alexia_Lab8Context : DbContext
    {
        public Stoica_Alexia_Lab8Context (DbContextOptions<Stoica_Alexia_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Stoica_Alexia_Lab8.Models.Book> Book { get; set; }

        public DbSet<Stoica_Alexia_Lab8.Models.Publisher> Publisher { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d7p4n4Namespace.Final.Class;
using Microsoft.EntityFrameworkCore;

namespace d7p4n4Namespace.Context.Class
{
    public class AllContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Ac4ySD3;Trusted_Connection=True;");
        }

        public DbSet<Ac4ySDSequence> Ac4ySDSequences { get; set; }


    }
}

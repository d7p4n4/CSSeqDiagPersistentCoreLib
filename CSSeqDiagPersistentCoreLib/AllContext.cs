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
        private string baseName { get; set; }
        private string userName { get; set; }
        private string password { get; set; }

        public AllContext(string bName, string uName, string pwd)
        {
            baseName = bName;
            userName = uName;
            password = pwd;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=" + baseName + ";Trusted_Connection=False;User Id=" + userName + ";Password=" + password + ";");
        }

        public DbSet<Ac4ySDSequence> Ac4ySDSequences { get; set; }


    }
}

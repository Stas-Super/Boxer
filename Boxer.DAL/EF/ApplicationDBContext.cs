using Boxer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Boxer.DAL.EF
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Battle> Battles { get; set; }
        public ApplicationDBContext() : base("DefaultConnection")
        {
            
        }

    }
}

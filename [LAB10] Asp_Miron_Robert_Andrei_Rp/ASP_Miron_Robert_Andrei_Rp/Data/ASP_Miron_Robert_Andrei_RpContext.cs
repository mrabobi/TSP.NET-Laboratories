using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_Miron_Robert_Andrei_Rp.Models;

namespace ASP_Miron_Robert_Andrei_Rp.Data
{
    public class ASP_Miron_Robert_Andrei_RpContext : DbContext
    {
        public ASP_Miron_Robert_Andrei_RpContext (DbContextOptions<ASP_Miron_Robert_Andrei_RpContext> options)
            : base(options)
        {
        }

        public DbSet<ASP_Miron_Robert_Andrei_Rp.Models.Movie> Movie { get; set; }
    }
}

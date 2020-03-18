using EF_StudiiDeCaz.Entities;
using System.Data.Entity;

namespace EF_StudiiDeCaz
{


    public class BusinessContext : DbContext
    {

        public DbSet<Business> Businesses { get; set; }
        public BusinessContext()
            : base("name=BusinessContext")
        {
        }

    }

}
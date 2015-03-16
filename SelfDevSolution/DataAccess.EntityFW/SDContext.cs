using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace DataAccess.EntityFW
{
    public class SDContext : DbContext
    {
        public SDContext():base("SDConnectionString")
        {
            Database.SetInitializer<SDContext>(new DropCreateDatabaseIfModelChanges<SDContext>());
        }
        public SDContext(string connectionString)
            : base(connectionString)
        {

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultWpfMvvmProject.DataAccess.DbContext
{
    public class DefaultDbContext:System.Data.Entity.DbContext
    {
        public DefaultDbContext():base("DefaultDb") {}
        //public DbSet<Field> Fields { get; set; }
    }
}

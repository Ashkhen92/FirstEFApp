using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFApp
{
    class UserContext:DbContext
    {
         public DbSet<User> Users { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerAppAgain.Data
{
    public class EdurekaDBContext  : DbContext
    {
        public EdurekaDBContext(DbContextOptions<EdurekaDBContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}

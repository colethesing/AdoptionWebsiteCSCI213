using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdoptionWebsiteTest.Models;

namespace AdoptionWebsiteTest.Data
{
    public class AdoptionWebsiteTestContext : DbContext
    {
        public AdoptionWebsiteTestContext (DbContextOptions<AdoptionWebsiteTestContext> options)
            : base(options)
        {
        }

        public DbSet<AdoptionWebsiteTest.Models.Form> Form { get; set; } = default!;
    }
}

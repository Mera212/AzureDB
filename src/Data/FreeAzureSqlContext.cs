using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src;

    public class FreeAzureSqlContext : DbContext
    {
        public FreeAzureSqlContext (DbContextOptions<FreeAzureSqlContext> options)
            : base(options)
        {
        }

        public DbSet<src.Person> Person { get; set; } = default!;
    }

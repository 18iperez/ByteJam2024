using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SandsofTime.Models;

namespace SandsofTime.Data
{
    public class SandsofTimeContext : DbContext
    {
        public SandsofTimeContext (DbContextOptions<SandsofTimeContext> options)
            : base(options)
        {
        }

        public DbSet<SandsofTime.Models.SandsOfTime> SandsOfTime { get; set; } = default!;
    }
}

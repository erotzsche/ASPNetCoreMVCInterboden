using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetMVCAppInterboden.Model
{
    public class WohnungenContext : DbContext
    {
        public WohnungenContext(DbContextOptions<WohnungenContext> options) : base(options)
        {
        }

        public DbSet<Wohnung> Wohnungen { get; set; }
    }
}

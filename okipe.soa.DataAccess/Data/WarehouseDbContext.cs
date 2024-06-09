using Microsoft.EntityFrameworkCore;
using okipe.soa.Models;
using okipe_soa_warehouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okipe.soa.DataAccess.Data
{
    public class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options)
        {
        }

        public DbSet<Line> Lines { get; set; }
    
    }
}

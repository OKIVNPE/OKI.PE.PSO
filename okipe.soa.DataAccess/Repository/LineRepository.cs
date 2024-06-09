using okipe.soa.DataAccess.Data;
using okipe.soa.DataAccess.Repository.IRepository;
using okipe.soa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using okipe_soa_warehouse.Models;

namespace okipe.soa.DataAccess.Repository
{
    public class LineRepository : Repository<Line>, ILineRepository
    {
        private WarehouseDbContext _db;

        public LineRepository(WarehouseDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Line obj)
        {
            _db.Lines.Update(obj);
        }
    }
}

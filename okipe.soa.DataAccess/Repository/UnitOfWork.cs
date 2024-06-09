using okipe.soa.DataAccess.Data;
using okipe.soa.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okipe.soa.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private WarehouseDbContext _db;

        public UnitOfWork(WarehouseDbContext db)
        {
            _db = db;
            Line = new LineRepository(_db);
        }
        public ILineRepository Line { get; private set; }
       

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

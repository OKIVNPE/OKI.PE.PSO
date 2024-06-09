using okipe.soa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using okipe_soa_warehouse.Models;

namespace okipe.soa.DataAccess.Repository.IRepository
{

    public interface ILineRepository : IRepository<Line>
    {
        void Update(Line obj);
    }
}

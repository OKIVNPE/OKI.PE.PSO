using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okipe.soa.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ILineRepository Line { get; }

        void Save();
    }
}

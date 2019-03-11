using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;

namespace SMOSEC.Domain.IRepository
{
    public interface IAssetsProRepository : IRepository<cmdb_project>
    {
        IQueryable<cmdb_project> GetByID(int ID);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;

namespace SMOSEC.Domain.IRepository
{
    public interface IAssetsRoleRepository:IRepository<cmdb_role>
    {
        IQueryable<cmdb_role> GetByID(int ID);
    }
}

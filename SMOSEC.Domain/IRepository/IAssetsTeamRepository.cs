using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;

namespace SMOSEC.Domain.IRepository
{
    public interface IAssetsTeamRepository : IRepository<cmdb_team>
    {
        IQueryable<cmdb_team> GetByID(int ID);
    }
}

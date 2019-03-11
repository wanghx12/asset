using SMOSEC.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOSEC.Domain.IRepository
{
    /// <summary>
    /// 部门的仓储接口,仅用于查询
    /// </summary>
    public interface IDepartmentRepository : IRepository<cmdb_machineroom>
    {
        /// <summary>
        /// 根据部门ID返回部门对象
        /// </summary>
        /// <param name="ID">部门ID</param>

        IQueryable<cmdb_machineroom> GetAlldep();

        IQueryable<cmdb_machineroom> GetByID(int ID);

    }
}

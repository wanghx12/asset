using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;

namespace SMOSEC.Domain.IRepository
{
    public interface IAssBorrowOrderRowRepository : IRepository<cmdb_assettouselog>
    {
        /// <summary>
        /// 根据借用单编号返回借用单log信息
        /// </summary>
        /// <param name="id">借用单编号</param>
        /// <returns></returns>
        IQueryable<cmdb_assettouselog> GetByBoId(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;


namespace SMOSEC.Domain.IRepository
{
    /// <summary>
    /// 资产品牌的仓储接口，仅用于查询
    /// </summary>
    public interface IAssetsBrandRepository : IRepository<cmdb_brand>
    {
        /// <summary>
        /// 根据资产类别编号返回资产类别对象
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        IQueryable<cmdb_brand> GetByID(int ID);
    }
}

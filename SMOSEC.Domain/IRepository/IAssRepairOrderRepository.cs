using SMOSEC.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOSEC.Domain.IRepository
{
    /// <summary>
    /// 报修单的仓储接口，仅用于查询信息
    /// </summary>
    public interface IAssRepairOrderRepository:IRepository<cmdb_repairlog>
    {
        /// <summary>
        /// 根据报修单编号，返回报修单信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        IQueryable<cmdb_repairlog> GetByID(int ID);
        /// <summary>
        /// 根据用户编号查询报修单信息
        /// </summary>
        /// <param name="Role"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        IQueryable<cmdb_repairlog> GetByUser(String UserID);
        /// <summary>
        /// 得到最大的报修单ID
        /// </summary>
        /// <returns></returns>
        String GetMaxID();
        ///// <summary>
        ///// 返回报修单信息
        ///// </summary>
        ///// <returns></returns>
        //IQueryable<cmdb_repairlog> GetAll();

        /// <summary>
        /// 根据资产编号返回保修单信息
        /// </summary>
        /// <param name="id">资产编号</param>
        /// <returns></returns>
        IQueryable<cmdb_repairlog> GetByAssetId(int id);
    }
}

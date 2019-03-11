using SMOSEC.Domain.Entity;
using SMOSEC.Domain.IRepository;
using SMOSEC.Infrastructure;
using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;


namespace SMOSEC.Repository.Assets
{
    /// <summary>
    /// 报修单的仓储实现，仅用于查询
    /// </summary>
    public class AssRepairOrderRepository : BaseRepository<cmdb_repairlog>, IAssRepairOrderRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssRepairOrderRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据报修单编号，返回报修单信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public IQueryable<cmdb_repairlog> GetByID(int ID)
        {
            return _entities.Where(x => x.id == ID);
        }
        /// <summary>
        /// 根据用户编号查询报修单信息
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public IQueryable<cmdb_repairlog> GetByUser(String UserID)
        {
            return _entities;
            //if (String.IsNullOrEmpty(UserID))
            //{
            //    return _entities.AsNoTracking().OrderByDescending(a => a.call_date);
            //}
            //else
            //{
            //    return _entities.Where(x => x.CREATEUSER == UserID).AsNoTracking().OrderByDescending(a => a.CREATEDATE);
            //}
        }
        /// <summary>
        /// 得到最大的报修单ID
        /// </summary>
        /// <returns></returns>
        public string GetMaxID()
        {
            return _entities.Select(e => e.id.ToString()).Max();
        }
        ///// <summary>
        ///// 返回报修单信息
        ///// </summary>
        ///// <returns></returns>
        //public IQueryable<cmdb_repairlog> GetAll()
        //{
        //    return _entities;
        //}

        /// <summary>
        /// 根据资产编号返回保修单信息
        /// </summary>
        /// <param name="id">资产编号</param>
        /// <returns></returns>
        public IQueryable<cmdb_repairlog> GetByAssetId(int id)
        {
            return _entities.Where(a => a.asset_id == id);
        }
    }
}

using System;
using System.Linq;
using SMOSEC.Domain.IRepository;
using SMOSEC.Infrastructure;
using System.Collections.Generic;

namespace SMOSEC.Repository.Assets
{
    /// <summary>
    /// 固定资产的仓储实现，仅用于查询
    /// </summary>
    public class AssetsRepository : BaseRepository<SMOSEC.Domain.Entity.cmdb_asset>, IAssetsRepository
    {
        /// <summary>
        /// 固定资产类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssetsRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据资产条码和区域编号，返回库存信息
        /// </summary>
        /// <param name="ASSID">资产编号</param>
        /// <param name="LOCATIONID">区域编号</param>
        /// <returns></returns>
        public IQueryable<SMOSEC.Domain.Entity.cmdb_asset> GetByTypeID(int TypeID)
        {
            return _entities.Where(x => x.asset_type_id  == TypeID);
        }
        /// <summary>
        /// 根据资产sn返回资产信息
        /// </summary>
        /// <param name="SN">资产编号</param>
        /// <returns></returns>
        public IQueryable<SMOSEC.Domain.Entity.cmdb_asset> GetByID(String SN)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(SN))
            {
                result = result.Where(a => a.sn == SN);
            }
            return result;
        }
        /// <summary>
        /// 根据序列号返回闲置资产对象
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        public IQueryable<Domain.Entity.cmdb_asset> GetUnusedBySN(String SN)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(SN))
            {
                result = result.Where(a => a.sn == SN && a.status==1);
            }
            return result;
        }
        ///// <summary>
        ///// 判断当前使用人是否有领用或借用资产
        ///// </summary>
        ///// <param name="UserID">用户编号</param>
        ///// <returns></returns>
        //public IQueryable<Domain.Entity.cmdb_asset> GetByUser(String UserID)
        //{
        //    var result = _entities;
        //    if (!string.IsNullOrEmpty(UserID))
        //    {
        //        result = result.Where(a => a.CURRENTUSER == UserID && (a.STATUS == 2 || a.STATUS==5));
        //    }
        //    return result;
        //}
        /// <summary>
        /// 查询对应状态的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="Name">资产名称</param>
        /// <param name="UserID">用户名称</param>
        /// <param name="Status">状态</param>
        /// <returns></returns>
        public IQueryable<SMOSEC.Domain.Entity.cmdb_asset> GetAssByStatus(int Status)
        {
            var result = _entities;

            //result = result.Where(a => a.machine_room_id == LocationID);
            //if (!string.IsNullOrEmpty(UserID))
            //{
            //    result = result.Where(a => a.use_man_id == UserID);
            //}

            result = result.Where(a => a.status == Status);
            return result;
        }

        /// <summary>
        /// 查询对应状态的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="SN">序列号</param>
        /// <param name="UserID">用户名</param>
        /// <param name="Status">状态</param>
        /// <returns></returns>
        public IQueryable<SMOSEC.Domain.Entity.cmdb_asset> GetAssByStatusEx(string SN, int Status)
        {
            var result = _entities;
            //result = result.Where(a => a.machine_room_id == LocationID);
            
            if (!string.IsNullOrEmpty(SN))
            {
                result = result.Where(a => a.sn == SN);
            }

            result = result.Where(a => a.status == Status);
            return result;
        }
        /// <summary>
        /// 根据序列号或者名称查询资产
        /// </summary>
        /// <param name="SNOrName">序列号或者名称</param>
        /// <param name="types"></param>
        /// <returns></returns>
        public IQueryable<Domain.Entity.cmdb_asset> QueryAssets(string SNOrUuid)
        {
            var result = _entities;
            //result = result.Where(a=>a.status != -1);
            if (!string.IsNullOrEmpty(SNOrUuid))
            {
                result = result.Where(a => a.sn.Contains(SNOrUuid) || a.uuid.Contains(SNOrUuid) );
            }
            return result;
        }
        /// <summary>
        /// 查询空闲的资产数据(除调入区域外的)
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="Name">资产名称</param>
        /// <returns></returns>
        public IQueryable<Domain.Entity.cmdb_asset> GetUnUsedAssOther(int LocationID)
        {
            var result = _entities;
            result = result.Where(a => a.machine_room_id == LocationID);

            result = result.Where(a => a.status == 1);
            return result;
        }
        ///// <summary>
        ///// 查询即将失效的资产(需联合AssPR)
        ///// </summary>
        ///// <param name="days"></param>
        ///// <returns></returns>
        //public IQueryable<Domain.Entity.cmdb_asset> GetImminentAssets(int days)
        //{
        //    DateTime targetDateTime = DateTime.Now.Date.AddDays(days);
        //    DateTime Now = DateTime.Now.Date;
        //    //            return _entities.Where(a => a.EXPIRYDATE >=Now && ASSIDs.Contains(a.ASSID)).AsNoTracking();
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// 查询低于安全库存的资产(需联合AssQuant)
        ///// </summary>
        ///// <returns></returns>
        //public IQueryable<SMOSEC.Domain.Entity.cmdb_asset> GetLackOfStockAss()
        //{
        //    throw new System.NotImplementedException();
        //}

        /// <summary>
        /// 根据序列号得到资产
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        public IQueryable<SMOSEC.Domain.Entity.cmdb_asset> GetAssetsBySN(string SN)
        {
            var result = _entities;
            if (!string.IsNullOrEmpty(SN))
            {
                result = result.Where(a => a.sn == SN);
            }
            return result;
        }

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        public int GetMaxID()
        {
            return _entities.Select(e => e.id).Max();
        }

        /// <summary>
        /// 根据区域编号,类型和部门编号,得到盘点清单
        /// </summary>
        /// <param name="LocationId">区域编号</param>
        /// <param name="typeId">类型编号</param>
        /// <param name="DepartmentId">部门编号</param>
        public IQueryable<Domain.Entity.cmdb_asset> GetInventoryAssetses(int LocationId, int typeId)
        {
            var result = _entities;
            result = result.Where(a => a.machine_room_id == LocationId);
            result = result.Where(a => a.asset_type_id == typeId);

            return result;
        }

        /// <summary>
        /// 查询序列号是否存在
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        public bool SNIsExists(string SN)
        {
            return _entities.Any(a => a.sn == SN);
        }
    }
}

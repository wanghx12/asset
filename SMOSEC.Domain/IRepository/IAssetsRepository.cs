using System;
using System.Linq;
using SMOSEC.Domain.Entity;
using System.Collections.Generic;

namespace SMOSEC.Domain.IRepository
{
    /// <summary>
    /// 固定资产的仓储接口，仅用于查询
    /// </summary>
    public interface IAssetsRepository : IRepository<cmdb_asset>
    {
        /// <summary>
        ///  根据类型编号返回资产对象
        /// </summary>
        /// <param name="TypeID">类型编号</param>
        /// <returns></returns>
        IQueryable<cmdb_asset> GetByTypeID(int TypeID);
        /// <summary>
        /// 根据资产SN条码返回资产对象
        /// </summary>
        /// <param name="SN">资产SN编号</param>
        /// <returns></returns>
        IQueryable<cmdb_asset> GetByID(String SN);
        /// <summary>
        /// 根据序列号返回闲置资产对象
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        IQueryable<cmdb_asset> GetUnusedBySN(String SN);
        ///// <summary>
        ///// 判断当前使用人是否有领用或借用资产
        ///// </summary>
        ///// <param name="UserID">使用人</param>
        ///// <returns></returns>
        //IQueryable<cmdb_asset> GetByUser(String UserID);
        /// <summary>
        /// 查询对应状态的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="brandid">型号</param>
        /// <param name="UserID">用户编号</param>
        /// <param name="Status">状态</param>
        /// <returns></returns>
        IQueryable<cmdb_asset> GetAssByStatus(int Status);
        /// <summary>
        /// 根据SN或者uuid模糊查询资产
        /// </summary>
        /// <param name="SNOrName">SN或者唯一号</param>
        /// <param name="types"></param>
        /// <returns></returns>
        IQueryable<cmdb_asset> QueryAssets(string SNOrUuid);
        /// <summary>
        /// 查询对应状态的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="SN">序列号</param>
        /// <param name="UserID">用户编号</param>
        /// <param name="Status">状态</param>
        /// <returns></returns>
        IQueryable<cmdb_asset> GetAssByStatusEx(string SN, int Status);
        /// <summary>
        /// 查询空闲的资产数据(除调入区域外的)
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="Name">名称</param>
        /// <returns></returns>
        IQueryable<cmdb_asset> GetUnUsedAssOther(int LocationID);
        ///// <summary>
        ///// 查询即将失效的资产
        ///// </summary>
        ///// <param name="days">天数</param>
        ///// <returns></returns>
        //IQueryable<cmdb_asset> GetImminentAssets(int days);

        /// <summary>
        /// 查询低于安全库存的资产
        /// </summary>
        /// <returns></returns>
        //IQueryable<cmdb_asset> GetLackOfStockAss();


        IQueryable<cmdb_asset> GetAssetsBySN(string SN);

        /// <summary>
        /// 查询SN是否重复
        /// </summary>
        /// <param name="SN">序列号</param>
        /// <returns></returns>
        bool SNIsExists(string SN);

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        int GetMaxID();

        /// <summary>
        /// 根据区域编号,类型和部门编号,得到盘点清单
        /// </summary>
        /// <param name="LocationId">区域编号</param>
        /// <param name="typeId">类型编号</param>
        /// <param name="DepartmentId">部门编号</param>
        IQueryable<cmdb_asset> GetInventoryAssetses(int LocationId, int typeId);

        /// <summary>
        /// 根据机房查询资产
        /// </summary>
        IQueryable<cmdb_asset> QueryAssetsByRoom(int room);

        /// <summary>
        /// 根据挂帐人查询资产
        /// </summary>
        IQueryable<cmdb_asset> QueryAssetsByPayman(int payman);
    }
}

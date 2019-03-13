using System.Collections.Generic;
using System.Data;
using System.Linq;
using SMOSEC.CommLib;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;

namespace SMOSEC.Application.IServices
{
    /// <summary>
    /// 主数据的服务接口
    /// </summary>
    public interface ISettingService
    {
        #region 查询
        /// <summary>
        /// 根据sn返回资产信息
        /// </summary>
        /// <returns></returns>
        AssetsOutputDto  GetAssetsBysn(string ID);

        /// <summary>
        /// 得到某区域所有的固定资产
        /// </summary>
        /// <param name="LocationId">区域编号</param>
        /// <returns></returns>
        DataTable GetAllAss();

        /// <summary>
        /// 查询空闲的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="Name">资产名称</param>
        /// <returns></returns>
        DataTable GetUnUsedAss(int LocationID);

        /// <summary>
        /// 查询空闲的资产数据(除调入区域外的)
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="Name">资产名称</param>
        /// <returns></returns>
        //DataTable GetUnUsedAssOther(string LocationID, string Name);

        /// <summary>
        /// 查询空闲的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="SN">资产编号</param>
        /// <returns></returns>
        DataTable GetUnUsedAssEx(string SN);

        /// <summary>
        /// 查询在用的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="Name">资产名称</param>
        /// <param name="UserID">当前所有者</param>
        /// <returns></returns>
        //DataTable GetInUseAss(string LocationID);

        /// <summary>
        /// 查询在用的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="SN">资产编号</param>
        /// <param name="UserID">当前所有者</param>
        /// <returns></returns>
        //DataTable GetInUseAssEx(string LocationID, string SN, string UserID);

        /// <summary>
        /// 查询借用的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="Name">资产名称</param>
        /// <param name="UserID">当前所有者</param>
        /// <returns></returns>
        DataTable GetBorrowedAss();

        /// <summary>
        /// 查询借用的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="SN">资产编号</param>
        /// <param name="UserID">当前所有者</param>
        /// <returns></returns>
        DataTable GetBorrowedAssEx(string SN);



        /// <summary>
        /// 根据SN或者名称或者部门或者状态查询资产
        /// </summary>
        /// <param name="SNOrName">SN或者名称</param>
        /// <param name="LocationId">区域</param>
        /// <param name="DepId">部门编号</param>
        /// <param name="Status">资产状态</param>
        /// <param name="Type">资产类型</param>
        /// <returns></returns>
        DataTable QueryAssets(string SNOrName, int LocationId, int Status, int Type, int Pro);

        /// <summary>
        /// 根据SN得到资产信息
        /// </summary>
        /// <param name="SN">SN编号</param>
        /// <param name="LocationId">区域编号</param>
        /// <returns></returns>
        DataTable GetAssetsBySN(string SN);

        /// <summary>
        /// 根据资产编号得到资产信息
        /// </summary>
        /// <param name="Id">资产编号</param>
        /// <returns></returns>
        AssetsOutputDto GetAssetsByid(int id);

        /// <summary>
        /// 得到所有的SN
        /// </summary>
        /// <returns></returns>
        List<string> GetAllSns();
        /// <summary>
        /// 得到所有的唯一号
        /// </summary>
        /// <returns></returns>
        List<string> GetAlluuid();


        #endregion

        #region 操作
        /// <summary>
        /// 新增资产
        /// </summary>
        /// <param name="entity">资产信息</param>
        /// <returns></returns>
        ReturnInfo AddAssets(AssetsInputDto entity, string usernanme);

        /// <summary>
        /// 更新资产信息
        /// </summary>
        /// <param name="entity">资产信息</param>
        /// <returns></returns>
        ReturnInfo UpdateAssets(AssetsInputDto entity, string username);

        /// <summary>
        /// 删除资产信息
        /// </summary>
        ReturnInfo DeleteAssets(string sn, string username);


        #endregion

    }
}
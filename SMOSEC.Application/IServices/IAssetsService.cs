using System;
using System.Data;
using SMOSEC.CommLib;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;

namespace SMOSEC.Application.IServices
{
    /// <summary>
    /// 资产操作(借用,归还,领用,退库)的服务接口
    /// </summary>
    public interface IAssetsService
    {
        #region 查询
        /// <summary>
        /// 根据借用单编号返回借用单信息
        /// </summary>
        /// <param name="id">借用单编号</param>
        /// <returns></returns>
        AssBorrowOrderOutputDto GetBobyId(int id);

        /// <summary>
        /// 返回全部借用单信息,
        /// </summary>
        DataTable GetAllBo();

        /// <summary>
        /// 得到对应的借用单行项列表
        /// <param name="boid">借用单编号</param>
        /// </summary>
        /// <returns></returns>
        DataTable GetRowsByBoid(int boid);  
        #endregion

        #region 操作
        /// <summary>
        /// 添加借用单
        /// </summary>
        /// <param name="borrowOrderInput">借用单信息</param>
        /// <returns></returns>
        ReturnInfo AddAssBorrowOrder(AssBorrowOrderInputDto borrowOrderInput);

        /// <summary>
        /// 添加借用资产条目
        /// </summary>
        /// <param name="borrowOrderInputrow">借用单信息</param>
        /// <returns></returns>
        ReturnInfo AddAssBorrowOrderRow(AssBorrowOrderRowInputDto borrowOrderInputrow);

        /// <summary>
        /// 删除借用资产条目
        /// </summary>
        /// <param name="borrowOrderInputrow">借用单信息</param>
        /// <returns></returns>
        ReturnInfo DelAssBorrowOrderRow(string sn, int use_log_id);

        /// <summary>
        /// 归还借用资产
        /// </summary>
        /// <param name="borrowOrderInputrow">借用单信息</param>
        /// <returns></returns>
        ReturnInfo ReturnAss(AssBorrowOrderRowInputDto borrowOrderInputrow);

        ///// <summary>
        ///// 更换使用者
        ///// </summary>
        ///// <param name="ASSID">资产编号</param>
        ///// <param name="CurrentUser">当前使用者</param>
        ///// <param name="UserID">操作用户</param>
        ///// <returns></returns>
        //ReturnInfo ChangeUser(String ASSID, String CurrentUser, String UserID);

        #endregion
    }
}
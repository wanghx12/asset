using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.InputDTO;
using System;
using System.Collections.Generic;


namespace SMOSEC.Application.IServices
{
    /// <summary>
    /// 报修单的服务接口
    /// </summary>
    public interface IAssRepairOrderService
    {
        #region 查询
        /// <summary>
        /// 根据报修单编号返回报修单信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        ROInputDto GetByID(int ID);
        /// <summary>
        /// 返回报修单信息
        /// </summary>
        /// <returns></returns>
        List<cmdb_repairlog> GetAll();
        #endregion

        #region 操作
        /// <summary>
        /// 新增报修单
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ReturnInfo AddAssRepairOrder(repairInPutDto entity);
        /// <summary>
        /// 更新报修单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ReturnInfo UpdateAssRepairOrder(int id, string status);
        #endregion
    }
}

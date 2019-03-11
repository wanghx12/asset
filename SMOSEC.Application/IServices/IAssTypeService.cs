using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMOSEC.Application.IServices
{
    /// <summary>
    /// 资产类别的服务接口
    /// </summary>
    public interface IAssTypeService
    {
        #region 查询
        /// <summary>
        /// 返回所有资产类别信息
        /// </summary>
        /// <returns></returns>
        List<cmdb_assettype> GetAll();
        /// <summary>
        /// 返回所有资产大类信息
        /// </summary>
        /// <returns></returns>
        List<cmdb_assettype> GetAllFirstLevel();
        /// <summary>
        /// 根据资产类别编号返回资产类别信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        cmdb_assettype GetByID(int ID);
        /// <summary>
        /// 根据资产类别编号判断该分类下是否有相关资产数据
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        Boolean HasAssets(int ID);

        #endregion
        # region 操作
        /// <summary>
        /// 新增资产类别
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ReturnInfo AddAssetsType(cmdb_assettype entity);
        /// <summary>
        /// 更新资产类别
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ReturnInfo UpdateAssetsType(cmdb_assettype entity);
        /// <summary>
        /// 删除资产类别
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        ReturnInfo DeleteAssetsType(int  ID);
        /// <summary>
        /// 更改分类启用状态
        /// </summary>
        /// <param name="TypeId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        //ReturnInfo ChangeEnable(String TypeId, IsEnable status);

        ReturnInfo Addtype(string name, string dealman);
        #endregion   
    }
}

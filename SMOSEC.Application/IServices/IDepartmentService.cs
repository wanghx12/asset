using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOSEC.Application.IServices
{
    /// <summary>
    /// 部门的服务接口
    /// </summary>
    public interface IDepartmentService
    {
        #region 查询

        /// <summary>
        /// 得到所有部门
        /// </summary>
        List<cmdb_machineroom> GetAll();
        /// <summary>
        /// 根据部门ID返回部门对象
        /// </summary>
        /// <param name="ID">部门ID</param>
        List<cmdb_machineroom> GetDepartmentByDepID(int ID);

        ReturnInfo Addmachine_room(string name, string dealman);

        #endregion

    }
}

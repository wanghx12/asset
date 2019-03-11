using AutoMapper;
using SMOSEC.Application.IServices;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.Domain.IRepository;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;
using SMOSEC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SMOSEC.Application.Services
{
    /// <summary>
    /// 部门的服务实现
    /// </summary>
    public class DepartmentService: IDepartmentService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 用户的仓储类的接口
        /// </summary>
        //private IcoreUserRepository _coreUserRepository;
        /// <summary>
        /// 部门的仓储类的接口
        /// </summary>
        private IDepartmentRepository _departmentRepository;

        private SMOSECDbContext SMOSECDbContext;


        /// <summary>
        /// 部门服务实现的构造函数
        /// </summary>
        public DepartmentService(IUnitOfWork unitOfWork,
            //IcoreUserRepository coreUserRepository,
            IDepartmentRepository departmentRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            //_coreUserRepository = coreUserRepository;
            _departmentRepository = departmentRepository;
            SMOSECDbContext = (SMOSECDbContext)dbContext;
        }

        #region 查询

        /// <summary>
        /// 得到所有部门
        /// </summary>
        public List<cmdb_machineroom> GetAll()
        {
            return _departmentRepository.GetAlldep().AsNoTracking().ToList(); 
        }

        /// <summary>
        /// 根据部门ID返回部门对象
        /// </summary>
        /// <param name="ID">部门ID</param>
        public List<cmdb_machineroom> GetDepartmentByDepID(int ID)
        {
            return _departmentRepository.GetByID(ID).AsNoTracking().ToList();
        }
        public ReturnInfo Addmachine_room(string name, string dealman)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            try
            {
                var assbo = new cmdb_machineroom
                {
                    name = name
                };
                _unitOfWork.RegisterNew(assbo);

                var pr = new cmdb_modityhistory
                {
                    username = dealman,
                    m_time = DateTime.Now,
                    content = "添加--->机房" + "--->" + name,
                };
                _unitOfWork.RegisterNew(pr);

                bool result = _unitOfWork.Commit();
                rInfo.IsSuccess = result;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                sb.Append(ex.Message);
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
        }


        #endregion

    }
}

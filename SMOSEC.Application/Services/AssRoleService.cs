using System.Collections.Generic;
using SMOSEC.Application.IServices;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.Infrastructure;
using SMOSEC.Domain.IRepository;
using System;
using AutoMapper;
using System.Data.Entity;
using System.Linq;
using SMOSEC.DTOs.Enum;
using System.Text;

namespace SMOSEC.Application.Services
{
    public class AssRoleService : IAssRoleService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 资产品牌型号的查询接口
        /// </summary>
        private IAssetsRoleRepository _AssetsRoleRepository;
        /// <summary>
        /// 固定资产的查询接口
        /// </summary>
        private IAssetsRepository _AssetsRepository;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public AssRoleService(IUnitOfWork unitOfWork,
            IAssetsRoleRepository AssetsRoleRepository,
            IAssetsRepository AssetsRepository)
        {
            _unitOfWork = unitOfWork;
            _AssetsRoleRepository = AssetsRoleRepository;
            _AssetsRepository = AssetsRepository;
        }
        public List<cmdb_role> GetAll()
        {
            return _AssetsRoleRepository.GetAll().AsNoTracking().ToList();
        }
        public ReturnInfo Addrole(string name, string dealman)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            try
            {
                var assbo = new cmdb_role
                {
                    name = name
                };
                _unitOfWork.RegisterNew(assbo);

                var pr = new cmdb_modityhistory
                {
                    username = dealman,
                    m_time = DateTime.Now,
                    content = "添加--->角色" + "--->" + name,
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

    }
}

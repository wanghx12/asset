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
    public class AssTeamService : IAssTeamService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 资产品牌型号的查询接口
        /// </summary>
        private IAssetsTeamRepository _AssetsTeamRepository;
        /// <summary>
        /// 固定资产的查询接口
        /// </summary>
        private IAssetsRepository _AssetsRepository;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public AssTeamService(IUnitOfWork unitOfWork,
            IAssetsTeamRepository AssetsTeamRepository,
            IAssetsRepository AssetsRepository)
        {
            _unitOfWork = unitOfWork;
            _AssetsTeamRepository = AssetsTeamRepository;
            _AssetsRepository = AssetsRepository;
        }
        public List<cmdb_team> GetAll()
        {
            return _AssetsTeamRepository.GetAll().AsNoTracking().ToList();
        }
        public ReturnInfo Addteam(string name, string dealman)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            try
            {
                var assbo = new cmdb_team
                {
                    name = name
                };
                _unitOfWork.RegisterNew(assbo);

                var pr = new cmdb_modityhistory
                {
                    username = dealman,
                    m_time = DateTime.Now,
                    //content = HttpUtility.UrlEncode("添加--->团队" + "--->" + name, Encoding.UTF8),
                    content = "添加--->团队" + "--->" + name,
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

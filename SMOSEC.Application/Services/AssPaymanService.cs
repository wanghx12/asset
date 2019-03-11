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
    public class AssPaymanService : IAssPaymanService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 资产挂账人的查询接口
        /// </summary>
        private IAssetsPaymanRepository _AssetsPaymanRepository;
        /// <summary>
        /// 固定资产的查询接口
        /// </summary>
        private IAssetsRepository _AssetsRepository;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public AssPaymanService(IUnitOfWork unitOfWork,
            IAssetsPaymanRepository AssetsPaymanRepository,
            IAssetsRepository AssetsRepository)
        {
            _unitOfWork = unitOfWork;
            _AssetsPaymanRepository = AssetsPaymanRepository;
            _AssetsRepository = AssetsRepository;
        }
        public List<cmdb_payman> GetAll()
        {
            return _AssetsPaymanRepository.GetAll().AsNoTracking().ToList();
        }
        public ReturnInfo Addpayman(string name, string dealman)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            try
            {
                var assbo = new cmdb_payman
                {
                    name = name
                };
                _unitOfWork.RegisterNew(assbo);

                var pr = new cmdb_modityhistory
                {
                    username = dealman,
                    m_time = DateTime.Now,
                    content = "添加--->挂账人" + "--->" + name,
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

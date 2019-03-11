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
    public class AssBrandService : IAssBrandService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 资产品牌型号的查询接口
        /// </summary>
        private IAssetsBrandRepository _AssetsBrandRepository;
        /// <summary>
        /// 固定资产的查询接口
        /// </summary>
        private IAssetsRepository _AssetsRepository;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public AssBrandService(IUnitOfWork unitOfWork,
            IAssetsBrandRepository AssetsBrandRepository,
            IAssetsRepository AssetsRepository)
        {
            _unitOfWork = unitOfWork;
            _AssetsBrandRepository = AssetsBrandRepository;
            _AssetsRepository = AssetsRepository;
        }
        public List<cmdb_brand> GetAll()
        {
            return _AssetsBrandRepository.GetAll().AsNoTracking().ToList();
        }
        public cmdb_brand GetByID(int ID)
        {
            cmdb_brand at = _AssetsBrandRepository.GetByID(ID).AsNoTracking().FirstOrDefault();
            return at;
        }
        public ReturnInfo Addbrand(string name, string dealman)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            try
            {
                var assbo = new cmdb_brand
                {
                    name = name
                };
                _unitOfWork.RegisterNew(assbo);

                var pr = new cmdb_modityhistory
                {
                    username = dealman,
                    m_time = DateTime.Now,
                    content = "添加--->品牌型号" + "--->" + name,
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

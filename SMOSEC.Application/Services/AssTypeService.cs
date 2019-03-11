﻿using System.Collections.Generic;
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
    /// <summary>
    /// 资产类别的接口实现
    /// </summary>
    public class AssTypeService : IAssTypeService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 资产类别的查询接口
        /// </summary>
        private IAssetsTypeRepository _AssetsTypeRepository;
        /// <summary>
        /// 固定资产的查询接口
        /// </summary>
        private IAssetsRepository _AssetsRepository;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOSECDbContext SMOSECDbContext;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public AssTypeService(IUnitOfWork unitOfWork,
            IAssetsTypeRepository AssetsTypeRepository,
            IAssetsRepository AssetsRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _AssetsTypeRepository = AssetsTypeRepository;
            _AssetsRepository = AssetsRepository;
            SMOSECDbContext = (SMOSECDbContext)dbContext;
        }
        #region 查询
        /// <summary>
        /// 返回所有资产类别信息
        /// </summary>
        /// <returns></returns>
        public List<cmdb_assettype> GetAll()
        {
            return _AssetsTypeRepository.GetAll().AsNoTracking().ToList();
        }
        /// <summary>
        /// 返回所有资产大类信息
        /// </summary>
        /// <returns></returns>
        public List<cmdb_assettype> GetAllFirstLevel()
        {
            return _AssetsTypeRepository.GetAllFirstLevel().AsNoTracking().ToList();
        }
        /// <summary>
        /// 根据资产类别编号返回资产类别信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public cmdb_assettype GetByID(int ID)
        {
            cmdb_assettype at = _AssetsTypeRepository.GetByID(ID).AsNoTracking().FirstOrDefault();
            return at;
        }
        /// <summary>
        /// 根据资产类别编号判断该资产类别下是否有相关资产
        /// 暂未实现
        /// </summary>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public bool HasAssets(int TypeID)
        {
            List<cmdb_asset> assetss = _AssetsRepository.GetByTypeID(TypeID).AsNoTracking().ToList();
            if (assetss.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion 查询
        #region 操作
        public ReturnInfo AddAssetsType(cmdb_assettype entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            //if (String.IsNullOrEmpty(entity.TYPEID))
            //    throw new Exception("分类编号不能为空");
            //if (String.IsNullOrEmpty(entity.NAME))
            //    throw new Exception("分类名称不能为空");
            //if (String.IsNullOrEmpty(entity.EXPIRYDATE.ToString()))
            //    throw new Exception("年限不能为空");
            //cmdb_assettype at = _AssetsTypeRepository.GetByID(entity.TYPEID).AsNoTracking().FirstOrDefault();
            //if (at != null)
            //    throw new Exception("该分类编号已存在!");
            try
            {
                //entity.EXPIRYDATEUNIT = 1;
                //entity.ISENABLE = 1;
                _unitOfWork.RegisterNew(entity);
                bool result = _unitOfWork.Commit();
                RInfo.IsSuccess = result;
                RInfo.ErrorInfo = "创建成功!";
                return RInfo;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = ex.Message;
                return RInfo;
            }
        }
        /// <summary>
        /// 更新资产类别
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo UpdateAssetsType(cmdb_assettype entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                //if (String.IsNullOrEmpty(entity.TYPEID))
                //    throw new Exception("资产类别编号不能为空");
                //cmdb_assettype at = _AssetsTypeRepository.GetByID(entity.TYPEID).FirstOrDefault();
                //if (at == null)
                //    throw new Exception("该分类编号不存在，请检查!");

                //at.NAME = entity.NAME;
                //at.EXPIRYDATE = entity.EXPIRYDATE;
                //_unitOfWork.RegisterDirty(at);
                //bool result = _unitOfWork.Commit();
                //RInfo.IsSuccess = result;
                //RInfo.ErrorInfo = "更新信息成功!";
                return RInfo;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = ex.Message;
                return RInfo;
            }
        }
        /// <summary>
        /// 删除资产类别
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ReturnInfo DeleteAssetsType(int ID)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                cmdb_assettype at = _AssetsTypeRepository.GetByID(ID).FirstOrDefault();
                if (at == null)
                    throw new Exception("该分类编号不存在，请检查!");

                _unitOfWork.RegisterDeleted(at);
                bool result = _unitOfWork.Commit();
                RInfo.IsSuccess = result;
                RInfo.ErrorInfo = "删除成功!";
                return RInfo;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = ex.Message;
                return RInfo;
            }
        }
        public ReturnInfo Addtype(string name, string dealman)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            try
            {
                var assbo = new cmdb_assettype
                {
                    name = name
                };
                _unitOfWork.RegisterNew(assbo);

                var pr = new cmdb_modityhistory
                {
                    username = dealman,
                    m_time = DateTime.Now,
                    content = "添加--->资产类型" + "--->" + name,
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


        #endregion 操作
    }
}

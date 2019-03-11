using AutoMapper;
using SMOSEC.Application.IServices;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.Domain.IRepository;
using SMOSEC.DTOs.Enum;
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
    /// 用户的接口实现
    /// </summary>
    public class coreUserService : IcoreUserService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        ///// <summary>
        ///// 资产信息的查询接口
        ///// </summary>
        //private IAssetsRepository _assetsRepository;
        /// <summary>
        /// 用户信息的查询接口
        /// </summary>
        private IcoreUserRepository _coreUserRepository;
        ///// <summary>
        ///// 部门信息的查询接口
        ///// </summary>
        //private IDepartmentRepository _DepartmentRepository;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOSECDbContext SMOSECDbContext;
        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public coreUserService(IUnitOfWork unitOfWork,
            //IAssetsRepository assetsRepository,
            IcoreUserRepository coreUserRepository,
            //IDepartmentRepository DepartmentRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            //_assetsRepository = assetsRepository;
            _coreUserRepository = coreUserRepository;
            //_DepartmentRepository = DepartmentRepository;
            SMOSECDbContext = (SMOSECDbContext)dbContext;
        }
        #region 查询
        /// <summary>
        /// 返回管理员信息
        /// </summary>
        /// <returns></returns>
        public List<cmdb_userinfo> GetDealInAdmin()
        {
            return _coreUserRepository.GetDealInAdmin().AsNoTracking().ToList();
        }
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public List<cmdb_userinfo> GetAll()
        {
            return _coreUserRepository.GetAll().OrderBy(x=>x.local_username).AsNoTracking().ToList();
        }
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        public List<cmdb_userinfo> GetUser()
        {
            return _coreUserRepository.GetUser().AsNoTracking().ToList();
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Password">用户密码</param>
        public ReturnInfo Login(string UserID, String Password)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                if (string.IsNullOrEmpty(UserID))
                {
                    RInfo.IsSuccess = false;
                    throw new Exception("用户名为空;");
                }
                else
                {
                    cmdb_userinfo User = _coreUserRepository.GetByID(UserID).AsNoTracking().FirstOrDefault();
                    if (User != null)
                    {
                        Console.WriteLine("begin");
                        if (_coreUserRepository.Login(UserID, Password))
                        {
                            RInfo.IsSuccess = true;
                        }
                        else
                        {
                            RInfo.IsSuccess = false;
                            throw new Exception("密码错误");
                        }
                    }
                    else
                    {
                        RInfo.IsSuccess = false;
                        throw new Exception("该用户不存在");
                    }
                }
            }
            catch (Exception ex)
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = ex.Message;
            }
            return RInfo;
        }
        /// <summary>
        /// 返回管理员信息
        /// </summary>
        /// <returns></returns>
        public List<cmdb_userinfo> GetAdmin()
        {
            return _coreUserRepository.GetAdmin().AsNoTracking().ToList();
        }
        /// <summary>
        /// 根据用户编号返回用户信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public cmdb_userinfo GetUserByID(string ID)
        {
            return _coreUserRepository.GetByID(ID).AsNoTracking().FirstOrDefault();
        }
        #endregion
        #region 操作
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo AddUser(cmdb_userinfo entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            cmdb_userinfo coreUser = _coreUserRepository.GetByID(entity.local_username).FirstOrDefault();
            if (coreUser != null) throw new Exception("该用户已存在，请检查！");
            try
            {
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
        /// 修改密码
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="OldPwd"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public ReturnInfo ChangePwd(string UserID, String OldPwd, String newPwd)
        {
            ReturnInfo RInfo = new ReturnInfo();
            cmdb_userinfo coreUser = _coreUserRepository.GetByID(UserID).FirstOrDefault();
            if (coreUser == null) throw new Exception("该用户不存在，请检查！");
            if (coreUser.local_password != OldPwd) throw new Exception("原密码错误，请重试!");
            try
            {
                coreUser.local_password = newPwd;
                _unitOfWork.RegisterDirty(coreUser);
                bool result = _unitOfWork.Commit();
                RInfo.IsSuccess = result;
                RInfo.ErrorInfo = "修改密码成功!";
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
        /// 更新用户信息
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        #endregion
    }
}

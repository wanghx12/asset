using SMOSEC.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOSEC.Domain.IRepository
{
    /// <summary>
    /// 用户信息的仓储接口，仅用于查询
    /// </summary>
    public interface IcoreUserRepository : IRepository<cmdb_userinfo>
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Password">用户密码</param>
        /// <returns>true表示成功，false表示失败</returns>
        bool Login(string UserID, String Password);
        /// <summary>
        /// 获取管理员数据
        /// </summary>
        /// <returns></returns>
        IQueryable<cmdb_userinfo> GetAdmin();
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        IQueryable<cmdb_userinfo> GetUser();
        /// <summary>
        /// 获取调入管理员数据
        /// </summary>
        /// <returns></returns>
        IQueryable<cmdb_userinfo> GetDealInAdmin();
        /// <summary>
        /// 通过用户编号获取数据
        /// </summary>
        /// <returns></returns>
        IQueryable<cmdb_userinfo> GetByID(string ID);
        /// <summary>
        /// 判断该用户ID是否存在
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        bool IsExists(int UserID);
    }
}

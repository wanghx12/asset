using SMOSEC.Domain.Entity;
using SMOSEC.Domain.IRepository;
using SMOSEC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOSEC.Repository.Setting
{
    /// <summary>
    /// 用户信息的仓储实现，仅用于查询
    /// </summary>
    public class coreUserRepository : BaseRepository<cmdb_userinfo>, IcoreUserRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public coreUserRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="Password">用户密码</param>
        /// <returns>true表示成功，false表示失败</returns>
        public bool Login(string UserID, String Password)
        {
            return _entities.Any(x => x.local_username == UserID && x.local_password == Password);
        }
        /// <summary>
        /// 获取管理员数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<cmdb_userinfo> GetAdmin()
        {
            return _entities.Where(x => x.permission == "super");
        }
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<cmdb_userinfo> GetUser()
        {
            return _entities.Where(x => x.permission == "guest");
        }
        /// <summary>
        /// 通过用户编号获取用户信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public IQueryable<cmdb_userinfo> GetByID(string ID)
        {
            return _entities.Where(x => x.local_username == ID);
        }
        /// <summary>
        /// 获取调入管理员数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<cmdb_userinfo> GetDealInAdmin()
        {
            return _entities.Where(x => x.permission == "admin");
        }
        /// <summary>
        /// 判断该用户ID是否存在
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>true表示存在，false表示不存在</returns>
        public bool IsExists(int UserID)
        {
            return _entities.Any(x => x.id == UserID);
        }
    }
}

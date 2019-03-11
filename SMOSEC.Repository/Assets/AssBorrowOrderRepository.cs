using System.Data.Entity;
using System.Linq;
using SMOSEC.Domain.Entity;
using SMOSEC.Domain.IRepository;
using SMOSEC.Infrastructure;

namespace SMOSEC.Repository.Assets
{
    /// <summary>
    /// 借用单查询实现
    /// </summary>
    public class AssBorrowOrderRepository : BaseRepository<cmdb_uselog>, IAssBorrowOrderRepository
    {
        /// <summary>
        /// 借用单查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssBorrowOrderRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据借用单编号返回借用单信息
        /// </summary>
        /// <param name="id">借用单编号</param>
        /// <returns></returns>
        public IQueryable<cmdb_uselog> GetById(int id)
        {
            return _entities.Where(a => a.id == id);
        }

        /// <summary>
        /// 返回全部借用单信息
        /// </summary>
        public IQueryable<cmdb_uselog> GetAllBo()
        {
            var result = _entities;
            return result.AsNoTracking().OrderByDescending(a=>a.id);
        }

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        public string GetMaxId()
        {
            return _entities.Select(e => e.id.ToString()).Max();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;
using SMOSEC.Domain.IRepository;
using SMOSEC.Infrastructure;

namespace SMOSEC.Repository.Assets
{
    public class AssBorrowOrderRowRepository : BaseRepository<cmdb_assettouselog>, IAssBorrowOrderRowRepository
    {
        /// <summary>
        /// 借用单查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssBorrowOrderRowRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据借用单编号返回借用单log信息
        /// </summary>
        /// <param name="id">借用单编号</param>
        /// <returns></returns>
        public IQueryable<cmdb_assettouselog> GetByBoId(int id)
        {
            return _entities.Where(a => a.use_log_id == id);
        }
    }
}

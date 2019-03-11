using SMOSEC.Domain.Entity;
using SMOSEC.Domain.IRepository;
using SMOSEC.Infrastructure;
using System;
using System.Linq;

namespace SMOSEC.Repository.Assets
{
    /// <summary>
    /// 资产类别的仓储实现，仅用于查询
    /// </summary>
    public class AssetsTypeRepository : BaseRepository<cmdb_assettype>, IAssetsTypeRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssetsTypeRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据类型编号返回资产类别对象
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public IQueryable<cmdb_assettype> GetByID(int ID)
        {
            return _entities.Where(x => x.id == ID);
        }
        /// <summary>
        /// 获取所有大类
        /// </summary>
        /// <returns></returns>
        public IQueryable<cmdb_assettype> GetAllFirstLevel()
        {
            return _entities;
        }
    }
}

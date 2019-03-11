using System.Linq;
using SMOSEC.Domain.Entity;

namespace SMOSEC.Domain.IRepository
{
    /// <summary>
    /// 借用单查询接口
    /// </summary>
    public interface IAssBorrowOrderRepository : IRepository<cmdb_uselog>
    {
        /// <summary>
        /// 根据借用单编号返回借用单信息
        /// </summary>
        /// <param name="id">借用单编号</param>
        /// <returns></returns>
        IQueryable<cmdb_uselog> GetById(int id);

        /// <summary>
        /// 返回全部借用单信息
        /// </summary>
        IQueryable<cmdb_uselog> GetAllBo();

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        string GetMaxId();
    }
}
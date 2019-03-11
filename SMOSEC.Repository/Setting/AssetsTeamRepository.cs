﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;
using SMOSEC.Domain.IRepository;
using SMOSEC.Infrastructure;

namespace SMOSEC.Repository.Assets
{
    public class AssetsTeamRepository : BaseRepository<cmdb_team>, IAssetsTeamRepository
    {
        /// <summary>
        /// 仓储类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public AssetsTeamRepository(IDbContext dbContext)
            : base(dbContext)
        { }
        /// <summary>
        /// 根据类型编号返回资产类别对象
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public IQueryable<cmdb_team> GetByID(int ID)
        {
            return _entities.Where(x => x.id == ID);
        }


    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.Domain.Entity;

namespace SMOSEC.Domain.IRepository
{
    public interface IAssetsUserRepository : IRepository<cmdb_useman>
    {
        IQueryable<cmdb_useman> GetByID(int ID);
    }
}

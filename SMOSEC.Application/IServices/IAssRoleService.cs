using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;

namespace SMOSEC.Application.IServices
{
    public interface IAssRoleService
    {
        List<cmdb_role> GetAll();
        ReturnInfo Addrole(string name, string dealman);
    }
}

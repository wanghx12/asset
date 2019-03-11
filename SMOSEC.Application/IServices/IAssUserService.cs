using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;

namespace SMOSEC.Application.IServices
{
    public interface IAssUserService
    {
        List<cmdb_useman> GetAll();
        ReturnInfo Adduserman(string name, string dealman);
    }
}

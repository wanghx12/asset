using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;

namespace SMOSEC.Application.IServices
{
    public interface IAssTeamService
    {
        List<cmdb_team> GetAll();
        ReturnInfo Addteam(string name, string dealman);
    }
}

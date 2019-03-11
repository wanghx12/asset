using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;

namespace SMOSEC.Application.IServices
{
    public interface IAssProService
    {
        List<cmdb_project> GetAll();
        ReturnInfo Addpro(string name, string dealman);
    }
}

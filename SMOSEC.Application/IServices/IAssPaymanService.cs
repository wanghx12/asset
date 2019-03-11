using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;

namespace SMOSEC.Application.IServices
{
    public interface IAssPaymanService
    {
        List<cmdb_payman> GetAll();
        ReturnInfo Addpayman(string name, string dealman);
    }
}

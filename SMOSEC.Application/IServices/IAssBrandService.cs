using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMOSEC.Application.IServices
{
    public interface IAssBrandService
    {
        List<cmdb_brand> GetAll();
        cmdb_brand GetByID(int ID);
        ReturnInfo Addbrand(string name, string dealman);
    }
}

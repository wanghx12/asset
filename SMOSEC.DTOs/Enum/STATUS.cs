using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOSEC.DTOs.Enum
{
    /// <summary>
    /// 枚举类，资产状态
    /// </summary>
    public enum STATUS
    {
        在用 = 0,
        闲置 = 1,
        送测 = 2,
        外借 = 3,
        损坏 = 4,
        未知 = 5
    }
}

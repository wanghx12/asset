//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOSEC.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    
    public class cmdb_loginhistory : IAggregateRoot
    {
        public int id { get; set; }
        public string username { get; set; }
        public System.DateTime v_time { get; set; }
    }
}

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
    
    public class cmdb_payman : IAggregateRoot
    {
        public cmdb_payman()
        {
            this.cmdb_asset = new HashSet<cmdb_asset>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<cmdb_asset> cmdb_asset { get; set; }
    }
}

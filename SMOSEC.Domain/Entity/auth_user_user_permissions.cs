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
    
    public partial class auth_user_user_permissions : IAggregateRoot
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int permission_id { get; set; }
    
        public virtual auth_permission auth_permission { get; set; }
        public virtual auth_user auth_user { get; set; }
    }
}

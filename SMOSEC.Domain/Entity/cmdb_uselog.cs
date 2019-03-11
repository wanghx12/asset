using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOSEC.Domain.Entity
{
    public class cmdb_uselog : IAggregateRoot
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("id")]
        public int id { get; set; }

        public string phone { get; set; }
        public string principal { get; set; }
        public System.DateTime give_time { get; set; }
        public System.DateTime return_time { get; set; }
        public short expired { get; set; }
        public string position { get; set; }

        [ForeignKey("cmdb_project")]
        public int project_id { get; set; }

        [ForeignKey("cmdb_team")]
        public int team_id { get; set; }

        [ForeignKey("cmdb_useman")]
        public Nullable<int> use_man_id { get; set; }

        public string remark { get; set; }

        public virtual ICollection<cmdb_assettouselog> cmdb_assettouselog { get; set; }
        public virtual cmdb_project cmdb_project { get; set; }
        public virtual cmdb_team cmdb_team { get; set; }
        public virtual cmdb_useman cmdb_useman { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOSEC.Domain.Entity
{
    public class cmdb_repairlog : IAggregateRoot
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("id")]
        public int id { get; set; }
        [Required]
        public string find_man { get; set; }
        [Required]
        public string call_man { get; set; }
        [Required]
        public System.DateTime call_date { get; set; }
        [Required]
        public string repair_man { get; set; }
        [Required]
        public string repair_content { get; set; }
        [Required]
        public string repair_status { get; set; }

        [ForeignKey("cmdb_asset")]
        public int asset_id { get; set; }

        public virtual cmdb_asset cmdb_asset { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMOSEC.Domain.Entity
{
    public class cmdb_assettouselog : IAggregateRoot
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("id")]
        public int id { get; set; }
        [ForeignKey("cmdb_asset")]
        public int asset_id { get; set; }
        [ForeignKey("cmdb_uselog")]
        public int use_log_id { get; set; }

        public virtual cmdb_asset cmdb_asset { get; set; }
        public virtual cmdb_uselog cmdb_uselog { get; set; }
    }
}

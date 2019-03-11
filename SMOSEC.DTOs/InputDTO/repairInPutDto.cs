using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOSEC.DTOs.InputDTO
{
    public class repairInPutDto : IEntity
    {
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
        [Required]
        public int asset_id { get; set; }
    }
}

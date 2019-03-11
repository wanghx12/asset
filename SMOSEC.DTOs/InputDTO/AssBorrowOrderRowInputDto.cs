using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SMOSEC.DTOs.InputDTO
{
    /// <summary>
    /// 借用单行项
    /// </summary>
    public class AssBorrowOrderRowInputDto : IEntity
    {
        ///// <summary>
        ///// 资产编号
        ///// </summary>
        //[Required]
        //[DisplayName("资产编号")]
        //public int asset_id { get; set; }

        /// <summary>
        /// 借用单号
        /// </summary>
        [Required]
        [DisplayName("借用单号")]
        public int use_log_id { get; set; }

        /// <summary>
        /// 借用的所有资产编号
        /// </summary>
        public List<string> Sns { get; set; }

    }

}
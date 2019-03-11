using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMOSEC.DTOs.InputDTO
{
    /// <summary>
    /// 借用单
    /// </summary>
    public class AssBorrowOrderInputDto : IEntity
    {
        /// <summary>
        /// 借用单号
        /// </summary>
        //[Required]
        //[DisplayName("借用单号")]
        //public int id { get; set; }

        /// <summary>
        /// 借用人电话
        /// </summary>
        [Required]
        public string phone { get; set; }

        /// <summary>
        /// 经手人
        /// </summary>
        [Required]
        public string principal { get; set; }

        /// <summary>
        /// 借出时间
        /// </summary>
        [Required]
        public DateTime give_time { get; set; }

        /// <summary>
        /// 预计归还时间
        /// </summary>
        [Required]
        public DateTime return_time { get; set; }

        /// <summary>
        /// 过期状态
        /// </summary>
        [Required]
        public short expired { get; set; }

        /// <summary>
        /// 借用地点
        /// </summary>
        [Required]
        public string position { get; set; }

        /// <summary>
        /// 项目
        /// </summary>
        [Required]
        public int project_id { get; set; }

        /// <summary>
        /// 团队
        /// </summary>
        [Required]
        public int team_id { get; set; }

        /// <summary>
        /// 使用人
        /// </summary>
        public int? use_man_id { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string remark { get; set; }

        ///// <summary>
        ///// 借用的所有资产编号
        ///// </summary>
        //public List<int> Assids { get; set; }
    }


}
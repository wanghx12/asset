using System;

namespace SMOSEC.DTOs.OutputDTO
{
    /// <summary>
    /// 借用单
    /// </summary>
    public class AssBorrowOrderOutputDto
    {
        /// <summary>
        /// 借用单号
        /// </summary>
        //public int id { get; set; }

        /// <summary>
        /// 借用人电话
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 经手人
        /// </summary>
        public string principal { get; set; }

        /// <summary>
        /// 借出时间
        /// </summary>
        public DateTime give_time { get; set; }

        /// <summary>
        /// 预计归还时间
        /// </summary>
        public DateTime return_time { get; set; }

        /// <summary>
        /// 过期状态
        /// </summary>
        public short expired { get; set; }

        /// <summary>
        /// 借用地点
        /// </summary>
        public string position { get; set; }

        /// <summary>
        /// 项目
        /// </summary>
        public int project_id { get; set; }

        /// <summary>
        /// 团队
        /// </summary>
        public int team_id { get; set; }

        /// <summary>
        /// 使用人
        /// </summary>
        public int? use_man_id { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string remark { get; set; }

        public string bo_name { get; set; }
        public string pro_name { get; set; }
        public string team_name { get; set; }

    }

}
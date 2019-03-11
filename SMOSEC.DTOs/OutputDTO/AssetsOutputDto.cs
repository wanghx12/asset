using System;

namespace SMOSEC.DTOs.OutputDTO
{
    /// <summary>
    /// 资产
    /// </summary>
    public class AssetsOutputDto
    {
        /// <summary>
        /// 资产条码
        /// </summary>
        public string AssId { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// 资产编号
        /// </summary>
        public string Num { get; set; }
        /// <summary>
        /// 序列号
        /// </summary>
        public string SN { get; set; }

        /// <summary>
        /// 资产类别
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 类别名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 品牌型号
        /// </summary>
        public int Brandid { get; set; }

        public string Brandname { get; set; }

        /// <summary>
        /// 机房
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// 机房名称
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public short Status { get; set; }
        //public string StatusName { get; set; }

        /// <summary>
        /// 挂账人
        /// </summary>
        public string Payman { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// 团队名称
        /// </summary>
        public string Team { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// 当前用户
        /// </summary>
        public int? CurrentUser { get; set; }

        /// <summary>
        /// 当前用户名
        /// </summary>
        public string CurrentUserName { get; set; }

        /// <summary>
        /// 外借时间
        /// </summary>
        public DateTime? BorrowDate { get; set; }

        /// <summary>
        /// 归还时间
        /// </summary>
        public DateTime ? ReturnDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        public int pay_man_id { get; set; }
        public int? project_id { get; set; }
        public int? role_id { get; set; }
        public int? team_id { get; set; }
        public int id { get; set; }

    }

}
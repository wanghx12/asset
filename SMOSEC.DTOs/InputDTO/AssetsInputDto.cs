using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace SMOSEC.DTOs.InputDTO
{
    /// <summary>
    /// 资产信息
    /// </summary>
    public class AssetsInputDto : IEntity
    {
        
        //public int id { get; set; }
        /// <summary>
        /// 资产条码
        /// </summary>
        public string uuid { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// 序列号
        /// </summary>
        [Required]
        public string SN { get; set; }
        /// <summary>
        /// 资产编号
        /// </summary>
        public string asset_number { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        [Required]
        public string Position { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Required]
        public short Status { get; set; }
        /// <summary>
        /// 外借时间
        /// </summary>
        //public DateTime? BorrowDate { get; set; }
        public Nullable<System.DateTime> give_time { get; set; }

        /// <summary>
        /// 归还时间
        /// </summary>
        //public DateTime? ReturnDate { get; set; }
        public Nullable<System.DateTime> return_time { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }
        [Required]
        public System.DateTime modify_date { get; set; }

        /// <summary>
        /// 资产类别
        /// </summary>
        [Required]
        public int asset_type_id { get; set; }

        /// <summary>
        /// 品牌型号
        /// </summary>
        [Required]
        public int brand_id { get; set; }


        /// <summary>
        /// 机房
        /// </summary>
        [Required]
        public int machine_room_id { get; set; }
        [Required]
        public int pay_man_id { get; set; }



        //public string StatusName { get; set; }
        public Nullable<int> project_id { get; set; }
        public Nullable<int> role_id { get; set; }
        public Nullable<int> team_id { get; set; }
        /// <summary>
        /// 当前用户
        /// </summary>
        public Nullable<int> use_man_id { get; set; }




        
        //assets.asset_type_id = entity.TypeId;
        //                assets.brand_id = entity.Brandid;
        //                assets.machine_room_id = entity.LocationId;
        //                //assets.pay_man_id = entity.Payman;
        //                //assets.project_id = entity.Project;
        //                //assets.role_id = entity.Role;
        //                //assets.team_id = entity.Team;
        //                assets.use_man_id = entity.CurrentUser;
    }

}
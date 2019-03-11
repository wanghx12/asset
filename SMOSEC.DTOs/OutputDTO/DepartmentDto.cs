using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SMOSEC.DTOs.OutputDTO
{
    /// <summary>
    /// 部门列表里的传输对象,用于返回查询结果
    /// </summary>
    public class DepartmentDto
    {
        /// <summary>
        /// 机房编号
        /// </summary>
        [Key]
        [StringLength(maximumLength: 10, ErrorMessage = "长度不能超过10")]
        [DisplayName("机房编号")]
        public string DEPARTMENTID { get; set; }
        /// <summary>
        /// 机房名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "长度不能超过20")]
        [DisplayName("机房名称")]
        public string NAME { get; set; }

    }
}

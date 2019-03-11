namespace SMOSEC.DTOs.OutputDTO
{
    /// <summary>
    /// 单据详情时的序列号信息传输类
    /// </summary>
    public class OperDetailSnOutputDto
    {
        /// <summary>
        /// Sn号
        /// </summary>
        public string Sn { get; set; }
        /// <summary>
        /// 资产编号
        /// </summary>
        public int Assid { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 品牌型号
        /// </summary>
        public string Brand { get; set; }
    }
}
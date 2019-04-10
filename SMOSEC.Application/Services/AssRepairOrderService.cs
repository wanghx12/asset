using SMOSEC.Application.IServices;
using System;
using System.Collections.Generic;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.Infrastructure;
using SMOSEC.Domain.IRepository;
using System.Data.Entity;
using System.Linq;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.InputDTO;
using AutoMapper;

namespace SMOSEC.Application.Services
{
    /// <summary>
    /// 报修单的接口实现
    /// </summary>
    public class AssRepairOrderService : IAssRepairOrderService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;
        /// <summary>
        /// 报修单的查询接口
        /// </summary>
        private IAssRepairOrderRepository _AssRepairOrderRepository;
        /// <summary>
        /// 报修单行项的查询接口
        /// </summary>
        //private IAssRepairOrderRowRepository _AssRepairOrderRowRepository;
        /// <summary>
        /// 资产序列号的查询接口
        /// </summary>
        private IAssetsSNRepository _AssetsSNRepository;
        /// <summary>
        /// 资产的查询接口
        /// </summary>
        private IAssetsRepository _AssetsRepository;
        /// <summary>
        /// 处理记录的查询接口
        /// </summary>
        //private IAssProcessRecordRepository _AssProcessRecordRepository;
        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOSECDbContext SMOSECDbContext;

        /// <summary>
        /// 成本中心服务实现的构造函数
        /// </summary>
        public AssRepairOrderService(IUnitOfWork unitOfWork,
            IAssRepairOrderRepository AssRepairOrderRepository,
            //IAssRepairOrderRowRepository AssRepairOrderRowRepository,
            IAssetsRepository AssetsRepository,
            //IAssetsSNRepository AssetsSNRepository,
            //IcoreUserRepository coreUserRepository,
            //IAssProcessRecordRepository AssProcessRecordRepository,
            //IAssLocationRepository AssLocationRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _AssRepairOrderRepository = AssRepairOrderRepository;
            //_AssRepairOrderRowRepository = AssRepairOrderRowRepository;
            _AssetsRepository = AssetsRepository;
            //_AssetsSNRepository = AssetsSNRepository;
            //_AssProcessRecordRepository = AssProcessRecordRepository;
            SMOSECDbContext = (SMOSECDbContext)dbContext;
        }
        #region 查询
        /// <summary>
        /// 返回报修单信息
        /// </summary>
        /// <returns></returns>
        public List<cmdb_repairlog> GetAll()
        {
            return _AssRepairOrderRepository.GetAll().AsNoTracking().OrderByDescending(a => a.id).ToList();
        }
        /// <summary>
        /// 根据报修单编号返回报修单信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ROInputDto GetByID(int ID)
        {
            ROInputDto ro = Mapper.Map<cmdb_repairlog, ROInputDto>(_AssRepairOrderRepository.GetByID(ID).AsNoTracking().FirstOrDefault());
            //ro.Rows = _AssRepairOrderRowRepository.GetByROID(ID).AsNoTracking().ToList();
            return ro;
        }
        /// <summary>
        /// 根据报修行项编号返回报修单行项信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        //public AssRepairOrderRow GetRowByRowID(String ROID, String RPOROWID)
        //{
        //    return _AssRepairOrderRowRepository.GetByID(ROID, RPOROWID).AsNoTracking().FirstOrDefault();
        //}
        #endregion

        #region 操作
        /// <summary>
        /// 新增报修单
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo AddAssRepairOrder(repairInPutDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();

            List<cmdb_repairlog> Rows = _AssRepairOrderRepository.GetByAssetId(entity.asset_id).ToList();
            if (Rows != null && Rows.Count > 0)
            {
                if (Rows[0].repair_status == "等待修")
                {
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = "该资产已经报修，请等待!";
                    return RInfo;
                }
            }

            if (String.IsNullOrEmpty(entity.call_man)) throw new Exception("处理人不能为空");
            if (String.IsNullOrEmpty(entity.call_date.ToString())) throw new Exception("维修日期不能为空");
            if (String.IsNullOrEmpty(entity.repair_content)) throw new Exception("维修内容不能为空");

            //String MaxID = _AssRepairOrderRepository.GetMaxID();        //获取当前最大报修单编号
            //String NowID = Helper.GeneratePRID("W", MaxID);                //生成最新的报修单编号
            //entity.ROID = NowID;
            try
            {
                var assbo = Mapper.Map<repairInPutDto, cmdb_repairlog>(entity);
                //                public string find_man { get; set; }
                //public string call_man { get; set; }
                //public System.DateTime call_date { get; set; }
                //public string repair_man { get; set; }
                //public string repair_content { get; set; }
                //public string repair_status { get; set; }
                //public int asset_id { get; set; }
                _unitOfWork.RegisterNew(assbo);
                //AddAssRepairOrderRow(entity);

                bool result = _unitOfWork.Commit();
                RInfo.IsSuccess = result;
                RInfo.ErrorInfo = "创建成功!";
                return RInfo;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = ex.Message;
                return RInfo;
            }
        }
        /// <summary>
        /// 更新报修单
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo UpdateAssRepairOrder(int id, string status)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                cmdb_repairlog aro = _AssRepairOrderRepository.GetByID(id).FirstOrDefault();
                if (aro != null)
                {
                    aro.repair_status = status;
                    _unitOfWork.RegisterDirty(aro);
                    //UpdateAssRepairOrderRow(entity);

                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = "修改成功!";
                    return RInfo;
                    //if (aro.repair_status != "等待修")
                    //{
                    //    throw new Exception("只有待维修中的才能确认");
                    //}
                    //else
                    //{}
                }
                else
                {
                    throw new Exception("报修单不存在!");
                }
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = ex.Message;
                return RInfo;
            }
        }
        /// <summary>
        /// 新增报修单行项
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo AddAssRepairOrderRow(ROInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                //String ROROWID = "0";
                //if (entity.Rows != null)
                //{
                //    foreach (AssRepairOrderRow Row in entity.Rows)
                //    {
                //        ROROWID = (int.Parse(ROROWID) + 1).ToString();
                //        Row.ROID = entity.ROID;
                //        Row.ROROWID = ROROWID;
                //        if (GetRowByRowID(Row.ROID, Row.ROROWID) != null)
                //            throw new Exception("维修单行项号已存在!");
                //        _unitOfWork.RegisterNew(Row);
                //        //往AssProcessRecord表添加数据
                //        CreatePR(entity, Row, PROCESSMODE.报修);

                //        Assets assetsSN = _AssetsRepository.GetByID(Row.ASSID).FirstOrDefault();
                //        if (assetsSN == null)
                //            throw new Exception("不存在条码为:" + Row.ASSID + "的资产!");

                //        assetsSN.STATUS = (int)STATUS.维修;
                //        _unitOfWork.RegisterDirty(assetsSN);
                //    }
                //}
                RInfo.IsSuccess = true;
                RInfo.ErrorInfo = "维修单行项创建成功！";
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = ex.Message;
            }
            return RInfo;
        }
        /// <summary>
        /// 更新报修单行项
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo UpdateAssRepairOrderRow(ROInputDto entity)
        {
            ReturnInfo RInfo = new ReturnInfo();
            try
            {
                //AssRepairOrderRow assROR = new AssRepairOrderRow();
                //foreach (AssRepairOrderRow Row in entity.Rows)
                //{
                //    assROR = _AssRepairOrderRowRepository.GetByID(entity.ROID, Row.ROROWID).FirstOrDefault();
                //    if (assROR == null) throw new Exception("维修单行项：" + Row.ROROWID + "不存在！");
                //    assROR.WAITREPAIRQTY = assROR.WAITREPAIRQTY - Row.REPAIREDQTY;     //待维修数量
                //    if (Row.WAITREPAIRQTY < 0) throw new Exception("维修数量不能超过待维修总数");
                //    assROR.REPAIREDQTY = Convert.ToDecimal(assROR.REPAIREDQTY) + Row.REPAIREDQTY;
                //    if (assROR.WAITREPAIRQTY == 0)       //如果全部维修完毕，则修改行项状态
                //        assROR.STATUS = 1;

                //    //更新OrderRow数据
                //    _unitOfWork.RegisterDirty(assROR);
                //    //往AssProcessRecord表添加数据
                //    CreatePR(entity, Row, PROCESSMODE.维修完毕);

                //    Assets assetsSN = _AssetsRepository.GetByID(Row.ASSID).FirstOrDefault();
                //    if (assetsSN == null)
                //        throw new Exception("不存在条码为:" + Row.ASSID + "的资产!");

                //    assetsSN.STATUS = (Int32)STATUS.闲置;
                //    _unitOfWork.RegisterDirty(assetsSN);
                //}

                //RInfo.IsSuccess = true;
                //RInfo.ErrorInfo = "维修单行项更新成功！";
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = ex.Message;
            }
            return RInfo;
        }
        /// <summary>
        /// 创建ProcessRecorder表数据
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="RowData"></param>
        /// <param name="Type"></param>
        //public void CreatePR(ROInputDto Data, AssRepairOrderRow RowData, PROCESSMODE Type)
        //{
        //    AssProcessRecord assProcessRecord = new AssProcessRecord
        //    {
        //        ASSID = RowData.ASSID,          //资产条码
        //        CREATEDATE = DateTime.Now,      //创建时间
        //        CREATEUSER = Data.CREATEUSER,   //创建用户
        //        HANDLEDATE = DateTime.Now,      //处理时间
        //        MODIFYDATE = DateTime.Now,      //修改时间
        //        MODIFYUSER = Data.MODIFYUSER,   //修改用户
        //    };
        //    switch (Type)
        //    {
        //        case PROCESSMODE.报修:
        //            assProcessRecord.QUANTITY = RowData.WAITREPAIRQTY;
        //            assProcessRecord.PROCESSMODE = (Int32)PROCESSMODE.报修;
        //            assProcessRecord.HANDLEMAN = Data.CREATEUSER;
        //            break;
        //        case PROCESSMODE.维修完毕:
        //            assProcessRecord.QUANTITY = RowData.REPAIREDQTY;
        //            assProcessRecord.PROCESSMODE = (Int32)PROCESSMODE.维修完毕;
        //            assProcessRecord.HANDLEMAN = Data.MODIFYUSER;
        //            break;
        //    }
        //    switch (Type)         //根据操作模式，输入操作内容
        //    {
        //        case PROCESSMODE.报修:
        //            assProcessRecord.PROCESSCONTENT = Data.CREATEUSER + "报修了物品编号为" + RowData.ASSID + "的资产";
        //            break;
        //        case PROCESSMODE.维修完毕:
        //            assProcessRecord.PROCESSCONTENT = Data.CREATEUSER + "维修了物品编号为" + RowData.ASSID + "的资产";
        //            break;
        //    }
        //    _unitOfWork.RegisterNew(assProcessRecord);
        //}
        #endregion
    }
}

using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using AutoMapper;
using SMOSEC.Application.IServices;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.Domain.IRepository;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;
using SMOSEC.Infrastructure;
using System.Collections.Generic;

namespace SMOSEC.Application.Services
{
    /// <summary>
    /// 资产操作(借用,归还,领用,退库)的服务实现
    /// </summary>
    public class AssetsService : IAssetsService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 资产信息的查询接口
        /// </summary>
        private IAssetsRepository _assetsRepository;

        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOSECDbContext _SMOSECDbContext;

        /// <summary>
        /// 借用单的查询接口
        /// </summary>
        private IAssBorrowOrderRepository _assBorrowOrderRepository;

        /// <summary>
        /// 借用单log的查询接口
        /// </summary>
        private IAssBorrowOrderRowRepository _assBorrowOrderRowRepository;

        /// <summary>
        /// 归还单的查询接口
        /// </summary>
        //private IAssReturnOrderRepository _assReturnOrderRepository;

        /// <summary>
        /// 部门的查询接口
        /// </summary>
        private IDepartmentRepository _departmentRepository;
        /// <summary>
        /// 资产操作(借用,归还,领用,退库)的服务实现的构造函数
        /// </summary>
        public AssetsService(IUnitOfWork unitOfWork,
            IAssetsRepository assetsRepository,
            IAssBorrowOrderRepository assBorrowOrderRepository,
            IAssBorrowOrderRowRepository assBorrowOrderRowRepository,
            //IAssReturnOrderRepository assReturnOrderRepository,
            IDepartmentRepository departmentRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _assetsRepository = assetsRepository;
            _assBorrowOrderRepository = assBorrowOrderRepository;
            _assBorrowOrderRowRepository = assBorrowOrderRowRepository;
            //_assReturnOrderRepository = assReturnOrderRepository;
            _departmentRepository = departmentRepository;
            _SMOSECDbContext = (SMOSECDbContext)dbContext;
        }

        #region 查询
        /// <summary>
        /// 根据借用单编号返回借用单信息
        /// </summary>
        /// <param name="id">借用单编号</param>
        /// <returns></returns>
        public AssBorrowOrderOutputDto GetBobyId(int id)
        {
            var dto = from assBorrowOrder in _SMOSECDbContext.AssBorrowOrders
                      join team in _SMOSECDbContext.AssetsTeam on assBorrowOrder.team_id equals team.id
                      join pro in _SMOSECDbContext.AssetsProject on assBorrowOrder.project_id equals pro.id
                      join user in _SMOSECDbContext.Userman on assBorrowOrder.use_man_id equals user.id
                      //join user in _SMOSECDbContext.coreUsers on assBorrowOrder.BORROWER equals user.USER_ID
                      //join user2 in _SMOSECDbContext.coreUsers on assBorrowOrder.BRHANDLEMAN equals user2.USER_ID
                      //join location in _SMOSECDbContext.AssLocations on assBorrowOrder.LOCATIONID equals location.LOCATIONID
                      where assBorrowOrder.id == id
                      select new AssBorrowOrderOutputDto()
                      {
                          //id = assBorrowOrder.id,
                          phone = assBorrowOrder.phone,
                          principal = assBorrowOrder.principal,
                          give_time = assBorrowOrder.give_time,
                          return_time = assBorrowOrder.return_time,
                          expired = assBorrowOrder.expired,
                          position = assBorrowOrder.position,
                          project_id = pro.id,
                          team_id = team.id,
                          use_man_id = user.id,
                          remark = assBorrowOrder.remark,
                          bo_name = user.name,
                          pro_name = pro.name,
                          team_name = team.name
                      };
            return dto.FirstOrDefault();
        }

        /// <summary>
        /// 返回全部借用单信息
        /// </summary>
        public DataTable GetAllBo()
        {
            var list = _assBorrowOrderRepository.GetAllBo().AsNoTracking();
            var result = from borrowOrder in list
                         join user in _SMOSECDbContext.Userman on borrowOrder.use_man_id equals user.id
                         select new
                         {
                             BORROWER = user.name,
                             BOID = borrowOrder.id,
                             BORROWDATE = borrowOrder.give_time,
                             LOCATIONNAME = borrowOrder.position
                         };
            return LINQToDataTable.ToDataTable(result.OrderByDescending(a => a.BOID));
        }

        /// <summary>
        /// 得到对应的借用单行项列表
        /// <param name="boid">借用单编号</param>
        /// </summary>
        /// <returns></returns>
        public DataTable GetRowsByBoid(int boid)
        {
            var result = from bo in _SMOSECDbContext.AssBorrowOrders
                         from row in _SMOSECDbContext.AssBorrowOrderRows where bo.id == row.use_log_id
                         join ass in _SMOSECDbContext.Assetss on row.asset_id equals ass.id
                         where bo.id == boid
                         //from ass in _SMOSECDbContext.Assetss
                         //         from bo in _SMOSECDbContext.AssBorrowOrders
                         //         from row in _SMOSECDbContext.AssBorrowOrderRows
                         //         where ass.id == row.asset_id &&  row.use_log_id == boid
                         //where ass.id == row.asset_id && bo.id == boid && bo.id == row.use_log_id
                         join type in _SMOSECDbContext.AssetsTypes on ass.asset_type_id equals type.id
                         join brand in _SMOSECDbContext.AssetsBrands on ass.brand_id equals brand.id
                         select new OperDetailSnOutputDto()
                         {
                             Assid = ass.id,
                             Sn = ass.sn,
                             Type = type.name,
                             Brand = brand.name
                         };
            return LINQToDataTable.ToDataTable(result);
        }
     
        #endregion

        #region 操作
        /// <summary>
        /// 添加借用单
        /// </summary>
        /// <param name="borrowOrderInput">借用单信息</param>
        /// <returns></returns>
        public ReturnInfo AddAssBorrowOrder(AssBorrowOrderInputDto borrowOrderInput)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            //string maxId = _assBorrowOrderRepository.GetMaxId();
            //string boId = Helper.GenerateIDEx("BO", maxId);
            //borrowOrderInput.id = int.Parse(boId);
            sb.Append(Helper.BasicValidate(borrowOrderInput).ToString());
            if (sb.Length == 0)
            {
                var assbo = Mapper.Map<AssBorrowOrderInputDto, cmdb_uselog>(borrowOrderInput);
                //Console.WriteLine(assbo.phone);
                //Console.WriteLine(assbo.principal);
                //Console.WriteLine(assbo.give_time);
                //Console.WriteLine(assbo.return_time);
                //Console.WriteLine(assbo.expired);
                //Console.WriteLine(assbo.position);
                //Console.WriteLine(assbo.project_id);
                //Console.WriteLine(assbo.team_id);
                //Console.WriteLine(assbo.use_man_id);
                //Console.WriteLine(assbo.remark);

                //assbo.CREATEDATE = DateTime.Now;
                //assbo.MODIFYDATE = DateTime.Now;
                try
                {
                    _unitOfWork.RegisterNew(assbo);

                    //foreach (var id in borrowOrderInput.Assids)
                    //{

                    //    //修改Asset的状态
                    //    //fixme
                    //    cmdb_asset assets = _assetsRepository.GetByID(id.ToString()).FirstOrDefault();
                    //    if (assets != null)
                    //    {
                    //        assets.status = (int)STATUS.外借;
                    //        assets.use_man_id = borrowOrderInput.use_man_id;

                    //        ////得到借用人的区域，并修改资产的区域为借用人的区域                           
                    //        //var User = _SMOSECDbContext.coreUsers.Where(a => a.USER_ID == assbo.BORROWER)
                    //        //    .AsNoTracking().FirstOrDefault();
                    //        //if (User != null)
                    //        //{
                    //        //    assets.LOCATIONID = User.USER_LOCATIONID;
                    //        //    assets.DEPARTMENTID = User.USER_DEPARTMENTID;
                    //        //}
                    //        //else
                    //        //{

                    //        //    throw new Exception("该用户不存在。");
                    //        //}
                    //        _unitOfWork.RegisterDirty(assets);
                    //    }
                    //    //添加行项
                    //    var corow = new cmdb_assettouselog
                    //    {
                    //        asset_id = id,
                    //        use_log_id = borrowOrderInput.project_id//fixme 此处应该先提交表单，获取use_log_id后再添加资产
                    //    };
                    //    _unitOfWork.RegisterNew(corow);

                    //    ////添加处理记录
                    //    //var pr = new AssProcessRecord
                    //    //{
                    //    //    ASSID = assId,
                    //    //    CREATEDATE = DateTime.Now,
                    //    //    CREATEUSER = borrowOrderInput.CREATEUSER,
                    //    //    HANDLEDATE = DateTime.Now,
                    //    //    HANDLEMAN = borrowOrderInput.BRHANDLEMAN,
                    //    //    MODIFYDATE = DateTime.Now,
                    //    //    MODIFYUSER = borrowOrderInput.MODIFYUSER,
                    //    //    PROCESSCONTENT = borrowOrderInput.BORROWER + "借用了" + assId,
                    //    //    PROCESSMODE = (int)PROCESSMODE.借用,
                    //    //    QUANTITY = 1
                    //    //};
                    //    //_unitOfWork.RegisterNew(pr);
                    //}
                    bool result = _unitOfWork.Commit();
                    rInfo.IsSuccess = result;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
            }
            else
            {
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }


        }

        /// <summary>
        /// 添加借用资产条目
        /// </summary>
        /// <param name="borrowOrderInputrow">借用单信息</param>
        /// <returns></returns>
        public ReturnInfo AddAssBorrowOrderRow(AssBorrowOrderRowInputDto borrowOrderInputrow)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            sb.Append(Helper.BasicValidate(borrowOrderInputrow).ToString());
            if (sb.Length == 0)
            {
                var assbo = Mapper.Map<AssBorrowOrderRowInputDto, cmdb_assettouselog>(borrowOrderInputrow);
                try
                {
                    AssBorrowOrderOutputDto assBorrowOrderOutput = GetBobyId(borrowOrderInputrow.use_log_id);//fixme
                    //_unitOfWork.RegisterNew(assbo);
                    foreach (var sn in borrowOrderInputrow.Sns)
                    {
                        //修改Asset的状态
                        cmdb_asset assets = _assetsRepository.GetByID(sn).FirstOrDefault();
                        if (assets != null)
                        {
                            assets.status = (int)STATUS.外借;
                            assets.use_man_id = assBorrowOrderOutput.use_man_id;
                            assets.project_id = assBorrowOrderOutput.project_id;
                            assets.team_id = assBorrowOrderOutput.team_id;
                            assets.give_time = assBorrowOrderOutput.give_time;
                            assets.return_time = assBorrowOrderOutput.return_time;
                            _unitOfWork.RegisterDirty(assets);
                        }
                        //添加行项
                        var corow = new cmdb_assettouselog
                        {
                            asset_id = assets.id,
                            use_log_id = borrowOrderInputrow.use_log_id
                        };
                        _unitOfWork.RegisterNew(corow);

                        ////添加处理记录
                        //var pr = new AssProcessRecord
                        //{
                        //    ASSID = assId,
                        //    CREATEDATE = DateTime.Now,
                        //    CREATEUSER = borrowOrderInput.CREATEUSER,
                        //    HANDLEDATE = DateTime.Now,
                        //    HANDLEMAN = borrowOrderInput.BRHANDLEMAN,
                        //    MODIFYDATE = DateTime.Now,
                        //    MODIFYUSER = borrowOrderInput.MODIFYUSER,
                        //    PROCESSCONTENT = borrowOrderInput.BORROWER + "借用了" + assId,
                        //    PROCESSMODE = (int)PROCESSMODE.借用,
                        //    QUANTITY = 1
                        //};
                        //_unitOfWork.RegisterNew(pr);
                    }

                    bool result = _unitOfWork.Commit();
                    rInfo.IsSuccess = result;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
            }
            else
            {
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
        }

        /// <summary>
        /// 删除借用资产条目
        /// </summary>
        /// <param name="borrowOrderInputrow">借用单信息</param>
        /// <returns></returns>
        public ReturnInfo DelAssBorrowOrderRow(string sn, int use_log_id)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            //sb.Append(Helper.BasicValidate(borrowOrderInputrow).ToString());
            if (sb.Length == 0)
            {
                //var assbo = Mapper.Map<AssBorrowOrderRowInputDto, cmdb_assettouselog>(borrowOrderInputrow);
                try
                {
                    //修改Asset的状态
                    cmdb_asset assets = _assetsRepository.GetByID(sn).FirstOrDefault();
                    if (assets != null)
                    {
                        assets.status = (int)STATUS.闲置;
                        assets.use_man_id = null;
                        assets.project_id = null;
                        assets.team_id = null;
                        assets.role_id = null;
                        assets.give_time = null;
                        assets.return_time = null;
                        _unitOfWork.RegisterDirty(assets);
                    }
                    //删除行项
                    List<cmdb_assettouselog> Rows = _assBorrowOrderRowRepository.GetByBoId(use_log_id).ToList();
                    foreach (var row in Rows)
                    {
                        if (row.asset_id == assets.id)
                        {
                            _unitOfWork.RegisterDeleted(row);
                            break;
                        }
                    }
                    ////添加处理记录
                    //var pr = new AssProcessRecord
                    //{
                    //    ASSID = assId,
                    //    CREATEDATE = DateTime.Now,
                    //    CREATEUSER = borrowOrderInput.CREATEUSER,
                    //    HANDLEDATE = DateTime.Now,
                    //    HANDLEMAN = borrowOrderInput.BRHANDLEMAN,
                    //    MODIFYDATE = DateTime.Now,
                    //    MODIFYUSER = borrowOrderInput.MODIFYUSER,
                    //    PROCESSCONTENT = borrowOrderInput.BORROWER + "借用了" + assId,
                    //    PROCESSMODE = (int)PROCESSMODE.借用,
                    //    QUANTITY = 1
                    //};
                    //_unitOfWork.RegisterNew(pr);
                    

                    bool result = _unitOfWork.Commit();
                    rInfo.IsSuccess = result;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
            }
            else
            {
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
        }

        /// <summary>
        /// 归还借用资产
        /// </summary>
        /// <param name="borrowOrderInputrow">借用单信息</param>
        /// <returns></returns>
        public ReturnInfo ReturnAss(AssBorrowOrderRowInputDto borrowOrderInputrow)
        {
            //验证
            ReturnInfo rInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            if (sb.Length == 0)
            {
                cmdb_uselog use_row = _assBorrowOrderRepository.GetById(borrowOrderInputrow.use_log_id).FirstOrDefault();
                use_row.expired = 0;
                _unitOfWork.RegisterDirty(use_row);

                try
                {
                    foreach (var sn in borrowOrderInputrow.Sns)
                    {
                        //修改Asset的状态
                        cmdb_asset assets = _assetsRepository.GetByID(sn).FirstOrDefault();
                        if (assets != null)
                        {
                            assets.status = (int)STATUS.闲置;
                            assets.use_man_id = null;
                            assets.project_id = null;
                            assets.team_id = null;
                            assets.role_id = null;
                            assets.give_time = null;
                            assets.return_time = null;
                            _unitOfWork.RegisterDirty(assets);
                        }
                    }
                    ////删除行项
                    List<cmdb_assettouselog> Rows = _assBorrowOrderRowRepository.GetByBoId(borrowOrderInputrow.use_log_id).ToList();
                    foreach (var row in Rows)
                    {
                        _unitOfWork.RegisterDeleted(row);
                    }

                    ////添加处理记录
                    //var pr = new AssProcessRecord
                    //{
                    //    ASSID = assId,
                    //    CREATEDATE = DateTime.Now,
                    //    CREATEUSER = borrowOrderInput.CREATEUSER,
                    //    HANDLEDATE = DateTime.Now,
                    //    HANDLEMAN = borrowOrderInput.BRHANDLEMAN,
                    //    MODIFYDATE = DateTime.Now,
                    //    MODIFYUSER = borrowOrderInput.MODIFYUSER,
                    //    PROCESSCONTENT = borrowOrderInput.BORROWER + "借用了" + assId,
                    //    PROCESSMODE = (int)PROCESSMODE.借用,
                    //    QUANTITY = 1
                    //};
                    //_unitOfWork.RegisterNew(pr);


                    bool result = _unitOfWork.Commit();
                    rInfo.IsSuccess = result;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    rInfo.IsSuccess = false;
                    rInfo.ErrorInfo = sb.ToString();
                    return rInfo;
                }
            }
            else
            {
                rInfo.IsSuccess = false;
                rInfo.ErrorInfo = sb.ToString();
                return rInfo;
            }
        }



        #endregion
    }
}
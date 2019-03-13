using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using AutoMapper;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.Domain.IRepository;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;
using SMOSEC.Infrastructure;
using SMOSEC.Application.IServices;


namespace SMOSEC.Application.Services
{
    /// <summary>
    /// 主数据的服务实现
    /// </summary>
    public class SettingService : ISettingService
    {
        /// <summary>
        /// 工作单元的接口
        /// </summary>
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// 资产信息的查询接口
        /// </summary>
        private IAssetsRepository _AssetsRepository;

        /// <summary>
        /// 数据库上下文
        /// </summary>
        private SMOSECDbContext SMOSECDbContext;
        /// <summary>
        /// 用户查询接口
        /// </summary>
        private IcoreUserRepository _coreUserRepository;
        /// <summary>
        /// 资产记录查询接口
        /// </summary>
        //private IAssProcessRecordRepository _AssProcessRecordRepository;
        /// <summary>
        /// 资产分类查询接口
        /// </summary>
        private IAssetsTypeRepository _assetsTypeRepository;
        /// <summary>
        /// 资产品牌型号查询接口
        /// </summary>
        private IAssetsBrandRepository _assetsBrandRepository;
        /// <summary>
        /// 部门的查询接口
        /// </summary>
        private IDepartmentRepository _departmentRepository;

        private IAssetsProRepository _assetsProRepository;
        private IAssetsRoleRepository _assetsRoleRepository;
        private IAssetsTeamRepository _assetsTeamRepository;
        private IAssetsUserRepository _assetsUserRepository;

        /// <summary>
        /// 主数据服务实现的构造函数
        /// </summary>
        public SettingService(IUnitOfWork unitOfWork,
            IAssetsRepository AssetsRepository,
            //IAssProcessRecordRepository AssProcessRecordRepository,
            IDepartmentRepository departmentRepository,
            IcoreUserRepository coreUserRepository,
            IAssetsTypeRepository assetsTypeRepository,
            IAssetsBrandRepository assetsBrandRepository,
            IAssetsProRepository assetsProRepository,
            IAssetsRoleRepository assetsRoleRepository,
            IAssetsTeamRepository assetsTeamRepository,
            IAssetsUserRepository assetsUserRepository,
            IDbContext dbContext)
        {
            _unitOfWork = unitOfWork;
            _AssetsRepository = AssetsRepository;
            //_AssProcessRecordRepository = AssProcessRecordRepository;
            _departmentRepository = departmentRepository;
            _coreUserRepository = coreUserRepository;
            _assetsTypeRepository = assetsTypeRepository;
            _assetsBrandRepository = assetsBrandRepository;
            _assetsProRepository = assetsProRepository;
            _assetsRoleRepository = assetsRoleRepository;
            _assetsTeamRepository = assetsTeamRepository;
            _assetsUserRepository = assetsUserRepository;
            SMOSECDbContext = (SMOSECDbContext)dbContext;
        }

        #region 查询

        /// <summary>
        /// 根据资产编号返回资产信息
        /// </summary>
        /// <param name="ID">资产编号</param>
        /// <returns></returns>
        public AssetsOutputDto GetAssetsBysn(string ID)
        {
            var dto = from assetse in SMOSECDbContext.Assetss
                      //join user in SMOSECDbContext.Userman on assetse.use_man_id equals user.id
                      join type in SMOSECDbContext.AssetsTypes on assetse.asset_type_id equals type.id
                      join location in SMOSECDbContext.AssLocations on assetse.machine_room_id equals location.id
                      join brand in SMOSECDbContext.AssetsBrands on assetse.brand_id equals brand.id
                      //join team in SMOSECDbContext.AssetsTeam on assetse.team_id equals team.id
                      //join pro in SMOSECDbContext.AssetsProject on assetse.project_id equals pro.id
                      join payman in SMOSECDbContext.AssetPayman on assetse.pay_man_id equals payman.id
                      //join role in SMOSECDbContext.AssetRole on assetse.role_id equals role.id
                      where assetse.sn == ID
                      select new AssetsOutputDto
                      {
                          id = assetse.id,
                          AssId = assetse.uuid,
                          IP = assetse.IP,
                          Num = assetse.asset_number,
                          SN = assetse.sn,
                          TypeId = assetse.asset_type_id,
                          TypeName = type.name,
                          Brandname = brand.name,
                          LocationId = assetse.machine_room_id,
                          LocationName = location.name,
                          Position = assetse.position,
                          Status = assetse.status,
                          //StatusName = "",
                          Payman = payman.name,
                          //Project = pro.name,
                          //Team = team.name,
                          //Role = role.name,
                          CurrentUser = assetse.use_man_id,
                          //CurrentUserName = user.name,

                          //BorrowDate = DateTime.Now,
                          //ReturnDate = DateTime.Now,
                          BorrowDate = assetse.give_time,
                          ReturnDate = assetse.return_time,
                          Note = assetse.remark,

                          Brandid = assetse.brand_id,
                          pay_man_id = assetse.pay_man_id,
                          project_id = assetse.project_id,
                          role_id = assetse.role_id,
                          team_id = assetse.team_id,
                    

        };
            
            var assdto = dto.AsNoTracking().FirstOrDefault();
            if (assdto != null)
            {
                if(assdto.project_id != null)
                {
                    var project = _assetsProRepository.GetByID((int)assdto.project_id);
                    var firstOrDefault = project.FirstOrDefault();
                    if (firstOrDefault != null)
                        assdto.Project = firstOrDefault.name;
                }
                if (assdto.role_id != null)
                {
                    var role = _assetsRoleRepository.GetByID((int)assdto.role_id);
                    var firstOrDefault = role.FirstOrDefault();
                    if (firstOrDefault != null)
                        assdto.Role = firstOrDefault.name;
                }
                if (assdto.team_id != null)
                {
                    var team = _assetsTeamRepository.GetByID((int)assdto.team_id);
                    var firstOrDefault = team.FirstOrDefault();
                    if (firstOrDefault != null)
                        assdto.Team = firstOrDefault.name;
                }
                if (assdto.CurrentUser != null)
                {
                    var user = _assetsUserRepository.GetByID((int)assdto.CurrentUser);
                    var firstOrDefault = user.FirstOrDefault();
                    if (firstOrDefault != null)
                        assdto.CurrentUserName = firstOrDefault.name;
                }

            }
            return assdto;
            //return dto.AsNoTracking().FirstOrDefault();
        }

        /// <summary>
        /// 根据资产编号得到资产信息
        /// </summary>
        /// <param name="Id">资产编号</param>
        /// <returns></returns>
        public AssetsOutputDto GetAssetsByid(int id)
        {
            var dto = from assetse in SMOSECDbContext.Assetss
                          //join user in SMOSECDbContext.Userman on assetse.use_man_id equals user.id
                      join type in SMOSECDbContext.AssetsTypes on assetse.asset_type_id equals type.id
                      join location in SMOSECDbContext.AssLocations on assetse.machine_room_id equals location.id
                      join brand in SMOSECDbContext.AssetsBrands on assetse.brand_id equals brand.id
                      //join team in SMOSECDbContext.AssetsTeam on assetse.team_id equals team.id
                      //join pro in SMOSECDbContext.AssetsProject on assetse.project_id equals pro.id
                      join payman in SMOSECDbContext.AssetPayman on assetse.pay_man_id equals payman.id
                      //join role in SMOSECDbContext.AssetRole on assetse.role_id equals role.id
                      where assetse.id == id
                      select new AssetsOutputDto
                      {
                          id = assetse.id,
                          AssId = assetse.uuid,
                          IP = assetse.IP,
                          Num = assetse.asset_number,
                          SN = assetse.sn,
                          TypeId = assetse.asset_type_id,
                          TypeName = type.name,
                          Brandname = brand.name,
                          LocationId = assetse.machine_room_id,
                          LocationName = location.name,
                          Position = assetse.position,
                          Status = assetse.status,
                          //StatusName = "",
                          Payman = payman.name,
                          //Project = pro.name,
                          //Team = team.name,
                          //Role = role.name,
                          CurrentUser = assetse.use_man_id,
                          //CurrentUserName = user.name,

                          //BorrowDate = DateTime.Now,
                          //ReturnDate = DateTime.Now,
                          BorrowDate = assetse.give_time,
                          ReturnDate = assetse.return_time,
                          Note = assetse.remark,

                          Brandid = assetse.brand_id,
                          pay_man_id = assetse.pay_man_id,
                          project_id = assetse.project_id,
                          role_id = assetse.role_id,
                          team_id = assetse.team_id,


                      };

            var assdto = dto.AsNoTracking().FirstOrDefault();
            if (assdto != null)
            {
                if (assdto.project_id != null)
                {
                    var project = _assetsProRepository.GetByID((int)assdto.project_id);
                    var firstOrDefault = project.FirstOrDefault();
                    if (firstOrDefault != null)
                        assdto.Project = firstOrDefault.name;
                }
                if (assdto.role_id != null)
                {
                    var role = _assetsRoleRepository.GetByID((int)assdto.role_id);
                    var firstOrDefault = role.FirstOrDefault();
                    if (firstOrDefault != null)
                        assdto.Role = firstOrDefault.name;
                }
                if (assdto.team_id != null)
                {
                    var team = _assetsTeamRepository.GetByID((int)assdto.team_id);
                    var firstOrDefault = team.FirstOrDefault();
                    if (firstOrDefault != null)
                        assdto.Team = firstOrDefault.name;
                }
                if (assdto.CurrentUser != null)
                {
                    var user = _assetsUserRepository.GetByID((int)assdto.CurrentUser);
                    var firstOrDefault = user.FirstOrDefault();
                    if (firstOrDefault != null)
                        assdto.CurrentUserName = firstOrDefault.name;
                }

            }
            return assdto;
            //return dto.AsNoTracking().FirstOrDefault();
        }

        /// <summary>
        /// 得到某区域所有的固定资产
        /// </summary>
        /// <param name="LocationId">区域编号</param>
        /// <returns></returns>
        public DataTable GetAllAss()
        {
            var list = _AssetsRepository.GetAll().Where(x=>x.status !=6);


            //list = list.OrderByDescending(a => a.id);
            var result = from assetse in list
                         join location in SMOSECDbContext.AssLocations on assetse.machine_room_id equals location.id
                         join type in SMOSECDbContext.AssetsTypes on assetse.asset_type_id equals type.id
                         join brand in SMOSECDbContext.AssetsBrands on assetse.machine_room_id equals brand.id
                         join team in SMOSECDbContext.AssetsTeam on assetse.machine_room_id equals team.id
                         select new
                         {
                             uuid = assetse.uuid,
                             //Image = assetse.IMAGE,
                             //DEPARTMENTID = assetse.DEPARTMENTID,
                             //DepName = "",
                             status = assetse.status,
                             StatusName = "",
                             LocationName = location.name,
                             //Name = assetse.NAME,
                             //Price = assetse.PRICE,
                             sn = assetse.sn,
                             TypeName = type.name,
                             remark = assetse.remark,
                             Brand = brand.name,
                             Team = team.name
                        };
            DataTable table = LINQToDataTable.ToDataTable(result);
            foreach (DataRow row in table.Rows)
            {
                row["StatusName"] = Enum.GetName(typeof(STATUS), row["status"]);           
            }
            return table;
        }

        /// <summary>
        /// 查询借用的资产数据,资产选择时用到
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="Name">名称</param>
        /// <param name="UserID">用户编号</param>
        /// <returns></returns>
        public DataTable GetBorrowedAss()
        {
            int status = 3;
            var result = _AssetsRepository.GetAssByStatus(status);
            var dtos = Mapper.Map<List<cmdb_asset>, List<AssSelectOutputDto>>(result.ToList());
            //foreach (var dto in dtos)
            //{
            //    dto.IsChecked = false;
            //}
            return LINQToDataTable.ToDataTable(dtos);            
        }

        /// <summary>
        /// 查询借用的资产信息,通过扫码添加时用到
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="SN">序列号</param>
        /// <param name="UserID">用户名称</param>
        /// <returns></returns>
        public DataTable GetBorrowedAssEx(string SN)
        { 
            int status = 3;
            var result = _AssetsRepository.GetAssByStatusEx(SN, status);
            //var ass = from assetse in result
            //          join user in SMOSECDbContext.Userman on assetse.use_man_id equals user.id
            //          select new AssSelectOutputDto()
            //          {
            //              IsChecked = false,
            //              //IMAGE = assetse.IMAGE,
            //              //NAME = assetse.IMAGE,
            //              ASSID = assetse.uuid,
            //              SN = assetse.sn,
            //              USERNAME = user.name

            //          };
            return LINQToDataTable.ToDataTable(result);
        }


        /// <summary>
        /// 查询在用的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="Name">资产名称</param>
        /// <param name="UserID">当前所有者</param>
        /// <returns></returns>
        //public DataTable GetInUseAss(int LocationID)
        //{
        //    int status = 0;
        //    var result = _AssetsRepository.GetAssByStatus(LocationID,status);
        //    var dtos = Mapper.Map<List<cmdb_asset>, List<AssSelectOutputDto>>(result.ToList());
        //    foreach (var dto in dtos)
        //    {
        //        dto.IsChecked = false;
        //    }
        //    return LINQToDataTable.ToDataTable(dtos);            
        //}

        /// <summary>
        /// 查询在用的资产数据,扫码添加时使用
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="SN">序列号</param>
        /// <param name="UserID">用户名称</param>
        /// <returns></returns>
        //public DataTable GetInUseAssEx(string LocationID, string SN, string UserID)
        //{
        //    int status = (int)STATUS.使用中;
        //    var result = _AssetsRepository.GetAssByStatusEx(LocationID, SN, UserID, status);
        //    var ass = from assetse in result
        //              join user in SMOSECDbContext.coreUsers on assetse.CURRENTUSER equals user.USER_ID
        //              select new AssSelectOutputDto()
        //              {
        //                  IsChecked = false,
        //                  IMAGE = assetse.IMAGE,
        //                  NAME = assetse.IMAGE,
        //                  ASSID = assetse.ASSID,
        //                  SN = assetse.SN,
        //                  USERNAME = user.USER_NAME
        //              };
        //    return LINQToDataTable.ToDataTable(ass);
        //}

        /// <summary>
        /// 查询空闲的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="Name">资产名称</param>
        public DataTable GetUnUsedAss(int LocationID)
        {
            int status = 1;
            var result = _AssetsRepository.GetAssByStatus(status);
            var dtos = Mapper.Map<List<cmdb_asset>, List<AssSelectOutputDto>>(result.ToList());
            foreach (var dto in dtos)
            {
                dto.IsChecked = false;
            }
            return LINQToDataTable.ToDataTable(dtos);
        }

        /// <summary>
        /// 查询空闲的资产数据
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="SN">资产编号</param>
        /// <returns></returns>
        public DataTable GetUnUsedAssEx(string SN)
        {
            int status = (int)STATUS.闲置;
            var result = _AssetsRepository.GetAssByStatusEx(SN, status);
            return LINQToDataTable.ToDataTable(result);
        }

        /// <summary>
        /// 查询空闲的资产数据(除调入区域外的)
        /// </summary>
        /// <param name="LocationID">区域编号</param>
        /// <param name="Name">资产名称</param>
        /// <returns></returns>
        //public DataTable GetUnUsedAssOther(string LocationID, string Name)
        //{
        //    //var result = _AssetsRepository.GetUnUsedAssOther(LocationID, Name);
        //    //var dtos = Mapper.Map<List<Assets>, List<AssSelectOutputDto>>(result.ToList());
        //    //foreach (var dto in dtos)
        //    //{
        //    //    dto.IsChecked = false;
        //    //}
        //    //return LINQToDataTable.ToDataTable(dtos);
        //}

        /// <summary>
        /// 根据SN或者名称或者部门或者状态查询资产
        /// </summary>
        /// <param name="SNOrName">SN或者名称</param>
        /// <param name="LocationId">区域</param>
        /// <param name="DepId">部门编号</param>
        /// <param name="Status">资产状态</param>
        /// <param name="Type">资产类型</param>
        /// <returns></returns>
        public DataTable QueryAssets(string SNOrName, int LocationId, int Status, int Type, int Pro)
        {
            var result = _AssetsRepository.QueryAssets(SNOrName).AsNoTracking();

            if (LocationId != -1)
                result = result.Where(a => a.machine_room_id == LocationId);
            if (Status != -1)
                result = result.Where(a => a.status == Status);
            if (Type != -1)
                result = result.Where(a => a.asset_type_id == Type);
            if (Pro != -1)
                result = result.Where(a => a.project_id == Pro);

            DataTable table = LINQToDataTable.ToDataTable(result);
            table.Columns.Add("StatusName");
            table.Columns.Add("Brand");
            //table.Columns.Add("LocationName");

            foreach (DataRow row in table.Rows)
            {
                row["StatusName"] = Enum.GetName(typeof(STATUS), row["status"]);

                //cmdb_machineroom dep = _departmentRepository.GetByID(LocationId).FirstOrDefault();
                //if (dep != null)
                //{
                //    row["LocationName"] = dep.name;
                //}

                //cmdb_assettype type = _assetsTypeRepository.GetByID(int.Parse(row["asset_type_id"].ToString())).AsNoTracking().FirstOrDefault();
                //if (type != null)
                //{
                //    row["TypeName"] = type.name;
                //}

                cmdb_brand brand = _assetsBrandRepository.GetByID(int.Parse(row["brand_id"].ToString())).AsNoTracking().FirstOrDefault();
                if (brand != null)
                {
                    row["Brand"] = brand.name;
                }

            }

                return table;
        }

        /// <summary>
        /// 根据SN得到资产信息
        /// </summary>
        /// <param name="SN">SN编号</param>
        /// <param name="LocationId">区域编号</param>
        /// <returns></returns>
        public DataTable GetAssetsBySN(string SN)
        {
            //var result = _AssetsRepository.GetAssetsBySN(SN).AsNoTracking();
            var result = _AssetsRepository.QueryAssets(SN).AsNoTracking();
            //return LINQToDataTable.ToDataTable(result);
            DataTable table = LINQToDataTable.ToDataTable(result);

            table.Columns.Add("StatusName");
            table.Columns.Add("Brand");
            //table.Columns.Add("LocationName");

            foreach (DataRow row in table.Rows)
            {
                row["StatusName"] = Enum.GetName(typeof(STATUS), row["status"]);
                cmdb_brand brand = _assetsBrandRepository.GetByID(int.Parse(row["brand_id"].ToString())).AsNoTracking().FirstOrDefault();
                if (brand != null)
                {
                    row["Brand"] = brand.name;
                }
            }
            return table;

            
        }

        /// <summary>
        /// 得到所有的Sn
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllSns()
        {
            var lists=new List<string>();
            lists = _AssetsRepository.GetAll().Select(a => a.sn).ToList();
            return lists;
        }
        /// <summary>
        /// 得到所有的唯一号
        /// </summary>
        /// <returns></returns>
        public List<string> GetAlluuid()
        {
            var lists = new List<string>();
            lists = _AssetsRepository.GetAll().Select(a => a.uuid).ToList();
            return lists;
        }

        #endregion

        #region 操作
        /// <summary>
        /// 添加资产
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ReturnInfo AddAssets(AssetsInputDto entity, string dealman)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            //if (entity.id == 0)
            //{
            //    int MaxId = _AssetsRepository.GetMaxID();
            //    int id = MaxId + 1;
            //    //string AssId = Helper.GenerateID("ASS", MaxId);
            //    //产生资产编号
            //    entity.id = id;
            //}
            
            string ValidateInfo = Helper.ValidateAssets(entity).ToString();
            sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    cmdb_asset assets = Mapper.Map<AssetsInputDto, cmdb_asset>(entity);
                    //Console.WriteLine(assets.IP);
                    //Console.WriteLine(assets.asset_number);
                    //Console.WriteLine(assets.sn);
                    //Console.WriteLine(assets.position);
                    //Console.WriteLine(assets.status);
                    //Console.WriteLine(assets.give_time);
                    //Console.WriteLine(assets.return_time);
                    //Console.WriteLine(assets.remark);
                    //Console.WriteLine(assets.asset_type_id);

                    //Console.WriteLine(assets.brand_id);
                    //Console.WriteLine(assets.machine_room_id);
                    //Console.WriteLine(assets.pay_man_id);
                    //Console.WriteLine(assets.project_id);
                    //Console.WriteLine(assets.role_id);
                    //Console.WriteLine(assets.use_man_id);
                    //Console.WriteLine(assets.team_id);
                    //Console.WriteLine(assets.modify_date);

                    //assets.status = (int)status.闲置;
                    //assets.MODIFYDATE=DateTime.Now;
                    _unitOfWork.RegisterNew(assets);

                    cmdb_assettype type = _assetsTypeRepository.GetByID(entity.asset_type_id).AsNoTracking().FirstOrDefault();
                    string type_name = type.name;

                    var pr = new cmdb_modityhistory
                    {
                        username = dealman,
                        m_time = DateTime.Now,
                        content = "添加--> 资产-->" + type_name + "--> 唯一号:" + assets.uuid,
                    };
                    _unitOfWork.RegisterNew(pr);

                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = entity.uuid;
                    return RInfo;
                    
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
            }
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }

        /// <summary>
        /// 更新资产信息
        /// </summary>
        /// <param name="entity">资产信息</param>
        /// <returns></returns>
        public ReturnInfo UpdateAssets(AssetsInputDto entity, string username)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            //产生资产编号
            //string ValidateInfo = Helper.BasicValidate(entity).ToString();
            //sb.Append(ValidateInfo);
            if (sb.Length == 0)
            {
                try
                {
                    cmdb_asset assets = _AssetsRepository.GetByID(entity.SN).AsNoTracking().FirstOrDefault();
                    //var originAss = Mapper.Map<cmdb_asset, AssetsOutputDto>(assets);
                    if (assets != null)
                    {
                        //assets.id = entity.id;
                        assets.uuid = entity.uuid;
                        assets.IP = entity.IP;
                        assets.sn = entity.SN;
                        assets.asset_number = entity.asset_number;
                        assets.position = entity.Position;
                        assets.status = (short)entity.Status;

                        //assets.give_time = entity.BorrowDate;
                        //assets.return_time = entity.BorrowDate;

                        if (entity.give_time.HasValue)
                            assets.give_time = entity.give_time;
                        else
                            assets.give_time = null;

                        if (entity.return_time.HasValue)
                            assets.return_time = entity.return_time;
                        else
                            assets.return_time = null;


                        assets.remark = entity.remark;

                        assets.modify_date = DateTime.Now;
                        assets.asset_type_id = entity.asset_type_id;
                        assets.brand_id = entity.brand_id;
                        assets.machine_room_id = entity.machine_room_id;
                        assets.pay_man_id = entity.pay_man_id;
                        assets.project_id = entity.project_id;
                        assets.role_id = entity.role_id;
                        assets.team_id = entity.team_id;
                        assets.use_man_id = entity.use_man_id;
                        
                        _unitOfWork.RegisterDirty(assets);
                    }

                    cmdb_assettype type = _assetsTypeRepository.GetByID(entity.asset_type_id).AsNoTracking().FirstOrDefault();
                    string type_name = type.name;
                    var pr = new cmdb_modityhistory
                    {
                        username = username,
                        m_time = DateTime.Now,
                        content = "修改--> 资产-->" + type_name + "--> 唯一号:" + assets.uuid,
                    };
                    _unitOfWork.RegisterNew(pr);

                    bool result = _unitOfWork.Commit();
                    RInfo.IsSuccess = result;
                    RInfo.ErrorInfo = sb.ToString();

                    return RInfo;
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    sb.Append(ex.Message);
                    RInfo.IsSuccess = false;
                    RInfo.ErrorInfo = sb.ToString();
                    return RInfo;
                }
            }
            else
            {
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }
        }

        /// <summary>
        /// 删除资产信息
        /// </summary>
        public ReturnInfo DeleteAssets(string sn, string username)
        {
            ReturnInfo RInfo = new ReturnInfo();
            StringBuilder sb = new StringBuilder();
            cmdb_asset assets = _AssetsRepository.GetByID(sn).FirstOrDefault();

            if (assets != null)
            {
                _unitOfWork.RegisterDeleted(assets);
                _unitOfWork.Commit();
                RInfo.IsSuccess = true;
                return RInfo;
            }
            else
            {
                sb.Append("该资产不存在，请检查!");
                RInfo.IsSuccess = false;
                RInfo.ErrorInfo = sb.ToString();
                return RInfo;
            }

        }


        #endregion
    }
}
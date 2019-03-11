using AutoMapper;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;

namespace SMOSEC.UI
{
    /// <summary>
    /// AutoMapper配置类
    /// </summary>
    public static class AutomapperConfig
    {
        public static void Init()
        {
            //映射InputDto到Entity
            Mapper.Initialize(x =>
            {
                //映射InputDto到Entity
                x.CreateMap<AssetsInputDto, cmdb_asset>();
                x.CreateMap<AssBorrowOrderInputDto, cmdb_uselog>();
                x.CreateMap<AssBorrowOrderRowInputDto, cmdb_assettouselog>();
                x.CreateMap<repairInPutDto, cmdb_repairlog>();
                //x.CreateMap<AssCollarOrderInputDto, AssCollarOrder>();
                //x.CreateMap<AssRestoreOrderInputDto, AssRestoreOrder>();
                //x.CreateMap<AssReturnOrderInputDto, AssReturnOrder>();
                //x.CreateMap<ConsumablesInputDto, Consumables>();
                //x.CreateMap<OutboundOrderInputDto, OutboundOrder>();
                //x.CreateMap<WarehouseReceiptInputDto, WarehouseReceipt>();

                //x.CreateMap<AssInventoryInputDto, AssInventory>();
                //x.CreateMap<AssInventoryResultInputDto, AssInventoryResult>();

                ////耗材盘点映射
                //x.CreateMap<ConInventoryInputDto, ConInventory>();
                //x.CreateMap<ConInventoryResultInputDto, ConInventoryResult>();
                //x.CreateMap<ConInventory, ConInventoryOutputDto>();

                ////映射Entity到查询用的Dto
                x.CreateMap<cmdb_uselog, AssBorrowOrderOutputDto>();
                //x.CreateMap<AssCollarOrder, AssCollarOrderOutputDto>();
                x.CreateMap<cmdb_asset, AssetsOutputDto>();
                //x.CreateMap<Assets, AssSelectOutputDto>();
                x.CreateMap<cmdb_userinfo, UserDepDto>();
                //x.CreateMap<Domain.Entity.Department, DepartmentDto>();
                //x.CreateMap<AssRestoreOrder, AssRestoreOrderOutputDto>();
                //x.CreateMap<AssReturnOrder, AssRestoreOrderOutputDto>();
                x.CreateMap<cmdb_repairlog, ROInputDto>();
                //x.CreateMap<AssScrapOrder, SOInputDto>();
                //x.CreateMap<AssTransferOrder, TOInputDto>();

                //x.CreateMap<Consumables, ConsumablesOutputDto>();
                //x.CreateMap<WarehouseReceipt, WarehouseReceiptOutputDto>();
                //x.CreateMap<OutboundOrder, OutboundOrderOutputDto>();

                //x.CreateMap<AssInventory, AssInventoryOutputDto>();
                //x.CreateMap<SMOSEC.Domain.Entity.Department, DepartmentDto>();


            });
        }
    }
}

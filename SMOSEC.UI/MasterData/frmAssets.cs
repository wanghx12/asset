using System;
using System.Data;
using Smobiler.Core.Controls;
using SMOSEC.UI.AssetsManager;
using Smobiler.Device;
using SMOSEC.DTOs.OutputDTO;
using System.Collections.Generic;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;

namespace SMOSEC.UI.MasterData
{

    /// <summary>
    /// 资产列表界面
    /// </summary>
    partial class frmAssets : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public string SelectAssId;  //当前选择的资产

        private string UserId;
        private int LocatinId;

        #endregion
        /// <summary>
        /// 按回退键，关闭客户端
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssets_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        public void Bind()
        {
            try
            {
                LocatinId = 0;
                //if (Client.Session["Role"].ToString() != "ADMIN")
                //{
                //    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                //    LocatinId = user.USER_LOCATIONID;
                //}

                DataTable table = _autofacConfig.SettingService.GetAllAss();
                gridAssRows.Cells.Clear();
                Label1.Text = "总共 " + table.Rows.Count + " 条数据";
                //table.Columns.Add("IsChecked");
                //foreach (DataRow Row in table.Rows)
                //{
                //    if (Row["sn"].ToString() == SelectAssId)
                //    {
                //        Row["IsChecked"] = true;
                //    }
                //    else
                //    {
                //        Row["IsChecked"] = false;
                //    }
                //}
                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }     

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssets_Load(object sender, EventArgs e)
        {
            try
            {
                //UserId = Client.Session["UserID"].ToString();
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// 点击ActionButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssets_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {

            try
            {
                switch (e.Index)
                {
                    case 0:     //资产新增
                        try
                        {
                            if (Client.Session["permission"].ToString() == "guest") throw new Exception("对不起，您没有权限添加资产!");
                            frmAssetsCreate assetsCreate = new frmAssetsCreate();
                            Show(assetsCreate, (MobileForm sender1, object args) =>
                            {
                                if (assetsCreate.ShowResult == ShowResult.Yes)
                                {
                                    Bind();
                                }

                            });
                        }
                        catch (Exception ex)
                        {
                            Toast(ex.Message);
                        }
                        break;
                    //case 1:
                    //    //资产复制
                    //    try
                    //    {
                    //        //if (Client.Session["Role"].ToString() == "SMOSECUser") throw new Exception("当前用户没有权限添加资产!");
                    //        if (string.IsNullOrEmpty(SelectAssId))//SelectAssId is sn
                    //        {
                    //            throw new Exception("请先选择资产.");
                    //        }
                    //        var assets = _autofacConfig.SettingService.GetAssetsBysn(SelectAssId);

                    //        frmAssetsCreate assetsCreate = new frmAssetsCreate
                    //        {
                    //            txtAssID = { Text = assets.AssId },
                    //            txtName = { Text = assets.IP },
                    //            txtNUm = { Text = assets.Num },
                    //            txtSN = { Text = assets.SN  },
                    //            btnType = { Text = assets.TypeName + "   > ", Tag = assets.TypeId },
                    //            btnBrand = { Text = assets.Brandname + "   > ", Tag = assets.Brandid },
                    //            txtSpe = { Text = assets.LocationName + "   > ", Tag = assets.LocationId },
                    //            txtLocation = { Text = assets.Position },
                    //            txtStatus1 = { Text = Enum.GetName(typeof(STATUS), assets.Status) + "   > ", Tag = assets.Status },
                    //            txtPayman1 = { Text = assets.Payman + "   > ", Tag = assets.pay_man_id },
                    //            txtPro1 = { Text = assets.Project + "   > ", Tag = assets.project_id == null ? true : false},
                    //            txtTeam1 = { Text = assets.Team + "   > ", Tag = assets.team_id == null ? true : false },
                    //            txtRole1 = { Text = assets.Role + "   > ", Tag = assets.role_id == null ? true : false },
                    //            txtUserman1 = { Text = assets.CurrentUserName + "   > ", Tag = assets.CurrentUser == null ? true : false },
                    //            //txtBordate1 = null,
                    //            //txtRedate1 = null,
                    //            txtBordate1 = { Value = DateTime.Now },
                    //            txtRedate1 = { Value = DateTime.Now },
                    //            //txtBordate1 = {Value = (DateTime)assets.BorrowDate },
                    //            //txtRedate1 = {Value = (DateTime)assets.BorrowDate },
                    //            //txtBordate1 = { Value = (DateTime)assets.BorrowDate != null ? (DateTime)assets.BorrowDate : Convert.ToDateTime(null) },
                    //            //txtRedate1 = { Value = (DateTime)assets.ReturnDate != null ? (DateTime)assets.ReturnDate : Convert.ToDateTime(null) },

                    //            txtNote = { Text = assets.Note },
                    //            TypeId = assets.TypeId,
                    //            Brandid = assets.Brandid,
                    //            LocationId = assets.LocationId,
                    //            Pay_man_id = assets.pay_man_id,

                    //            Project_id = assets.project_id,
                    //            Role_id = assets.role_id,
                    //            Team_id = assets.team_id,
                    //            CurrentUser = assets.CurrentUser,


                    //            //txtAssID = { Text = assets.AssId + "   > " },
                    //            //txtName = { Text = assets.IP + "   > " },
                    //            //txtNUm = { Text = assets.Num + " >" },
                    //            //txtSN = { Text = assets.SN + "   > " },
                    //            //btnType = { Tag = assets.TypeId },
                    //            //btnBrand = { Tag = assets.Brandid },
                    //            //txtSpe = { Tag = assets.LocationId },
                    //            //txtLocation = { Text = assets.Brandname },
                    //            //txtStatus1 = {  Tag = assets.Status },
                    //            //txtPayman1 = { Tag = assets.pay_man_id },
                    //            //txtPro1 = {  Tag = assets.project_id },
                    //            //txtTeam1 = {  Tag = assets.team_id },
                    //            //txtRole1 = {  Tag = assets.role_id },
                    //            //txtUserman1 = {  Tag = assets.CurrentUser },
                    //            //txtBordate1 = { Value = (DateTime)assets.BorrowDate },
                    //            ////txtBordate1 = { Value = (DateTime)assets.BorrowDate != null ? (DateTime)assets.BorrowDate : new DateTime() },
                    //            //txtRedate1 = { Value = (DateTime)assets.ReturnDate },
                    //            //txtNote = { Text = assets.Note },
                    //        };

                    //        Show(assetsCreate, (MobileForm sender1, object args) =>
                    //        {
                    //            if (assetsCreate.ShowResult == ShowResult.Yes)
                    //            {
                    //                Bind();
                    //            }

                    //        });
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        Toast(ex.Message);
                    //    }
                    //    break;
                    //case 2:
                        //资产领用
                        //frmCollarOrder frmCO = new frmCollarOrder();
                        //Form.Show(frmCO);
                        //break;
                    case 1:
                        //资产借用
                        frmBorrowOrder frmBO = new frmBorrowOrder();
                        Form.Show(frmBO);
                        break;
                    case 2:
                        //维修登记
                        frmRepairRowsSN frmR = new frmRepairRowsSN();
                        this.Form.Show(frmR);
                        break;
                        //case 5:
                        //    //报废
                        //    frmScrapRowsSN frmS = new frmScrapRowsSN();
                        //    this.Form.Show(frmS);
                        //    break;
                        //case 6:
                        //    //调拨
                        //    frmTransferRowsSN frmT = new frmTransferRowsSN();
                        //    this.Form.Show(frmT);
                        //    break;
                        //case 7:
                        //    try
                        //    {
                        //        if (string.IsNullOrEmpty(SelectAssId))
                        //        {
                        //            throw new Exception("请先选择资产.");
                        //        }
                        //        AssetsOutputDto outputDto = _autofacConfig.SettingService.GetAssetsBysn(SelectAssId);
                        //        PosPrinterEntityCollection Commands = new PosPrinterEntityCollection();
                        //        Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Initial));
                        //        Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledBarcode));
                        //        Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.AbsoluteLocation));
                        //        Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128Height, "62"));
                        //        Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, outputDto.SN));
                        //        Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, "E2000017320082231027BD"));
                        //        Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.DisabledBarcode));
                        //        Commands.Add(new PosPrinterContentEntity(System.Environment.NewLine));
                        //        Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Cut));

                        //        posPrinter1.Print(Commands, (obj, args) =>
                        //        {
                        //            if (args.isError == true)
                        //                this.Toast("Error: " + args.error);
                        //            else
                        //                this.Toast("打印成功");
                        //        });
                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        Toast(ex.Message);
                        //    }
                        //    break;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// 手机二维码扫描到二维码信息时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcodeScanner1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                DataTable table = _autofacConfig.SettingService.GetAssetsBySN(barCode);
                gridAssRows.Cells.Clear();
                //table.Columns.Add("IsChecked");
                //foreach (DataRow Row in table.Rows)
                //{
                //    if (Row["uuid"].ToString() == SelectAssId)
                //    {
                //        Row["IsChecked"] = true;
                //    }
                //    else
                //    {
                //        Row["IsChecked"] = false;
                //    }
                //}
                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();
                }
                Label1.Text = "总共 " + table.Rows.Count + " 条数据";
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 按照SN或者名称模糊匹配查询资产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFactor_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }
        /// <summary>
        /// 手机扫描二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageButton1_Press(object sender, EventArgs e)
        {
            try
            {
                barcodeScanner1.GetBarcode();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageButton2_Press(object sender, EventArgs e)
        {
            try
            {
                frmAssets frm = new frmAssets();
                Show(frm);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 机房选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDep_Press(object sender, EventArgs e)
        {
            try
            {
                popDep.Groups.Clear();       //数据清空
                PopListGroup poli = new PopListGroup();
                popDep.Groups.Add(poli);
                poli.AddListItem("全部", "-1");
                List<cmdb_machineroom> deps = _autofacConfig.DepartmentService.GetAll();
                foreach (cmdb_machineroom Row in deps)
                {
                    poli.AddListItem(Row.name, Row.id.ToString());
                }
                if (btnDep.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in poli.Items)
                    {
                        if (Item.Value == btnDep.Tag.ToString())
                            popDep.SetSelections(Item);
                    }
                }
                popDep.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 选择了部门
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popDep_Selected(object sender, EventArgs e)
        {
            setBtnTag(popDep, btnDep);
        }
        /// <summary>
        /// 资产状态选择
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        private void btnStatus_Press(object sender, EventArgs e)
        {
            popStatus.ShowDialog();
        }
        /// <summary>
        /// 选择了状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popStatus_Selected(object sender, EventArgs e)
        {
            setBtnTag(popStatus, btnStatus);
        }
        /// <summary>
        /// 资产类别选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnType_Press(object sender, EventArgs e)
        {
            try
            {
                popType.Groups.Clear();       //数据清空
                PopListGroup poli = new PopListGroup();
                popType.Groups.Add(poli);
                //Smobiler.Core.Controls.PopListItem popListItem1 = new Smobiler.Core.Controls.PopListItem();
                //popListItem1.Text = "全部";
                //popListItem1.Value = "-1";
                poli.AddListItem("全部", "-1");
                List<cmdb_assettype> types = _autofacConfig.assTypeService.GetAllFirstLevel();
                foreach (cmdb_assettype Row in types)
                {
                    poli.AddListItem(Row.name, Row.id.ToString());
                }
                if (btnType.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in poli.Items)
                    {
                        if (Item.Value == btnType.Tag.ToString())
                            popType.SetSelections(Item);
                    }
                }
                popType.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 选择了资产大类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popType_Selected(object sender, EventArgs e)
        {
            setBtnTag(popType, btnType);
        }

        /// <summary>
        /// 选择了项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popPro_Selected(object sender, EventArgs e)
        {
            setBtnTag(popPro, btnPro);
        }
        private void popPayman_Selected(object sender, EventArgs e)
        {
            setBtnTag(popPayman, btnPayman);
        }
        private void popUseman_Selected(object sender, EventArgs e)
        {
            setBtnTag(popUseman, btnUseman);
        }

        /// <summary>
        /// 选择了部门/资产状态/资产大类
        /// </summary>
        /// <param name="popList"></param>
        /// <param name="button"></param>
        public void setBtnTag(PopList popList, Button button)
        {
            //MessageBox.Show(popList.Selection.Text);
            if (String.IsNullOrEmpty(popList.Selection.Text) == false)
            //if (popList.Selection.Text != "-1")
            {
                if (button.Tag == null)
                {
                    button.Tag = popList.Selection.Value;         //选择大类编号
                    SearchData();
                }
                else if (popList.Selection.Value == "")
                {
                    button.Tag = null;
                    SearchData();
                }
                else if (popList.Selection.Value != button.Tag.ToString())
                {
                    button.Tag = popList.Selection.Value;         //选择大类编号
                    SearchData();
                }
                
            }
        }

        /// <summary>
        /// 项目选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPro_Press(object sender, EventArgs e)
        {
            try
            {
                popPro.Groups.Clear();       //数据清空
                PopListGroup poli = new PopListGroup();
                popPro.Groups.Add(poli);
                //Smobiler.Core.Controls.PopListItem popListItem1 = new Smobiler.Core.Controls.PopListItem();
                //popListItem1.Text = "全部";
                //popListItem1.Value = "-1";
                poli.AddListItem("全部", "-1");
                List<cmdb_project> types = _autofacConfig.assProService.GetAll();
                foreach (cmdb_project Row in types)
                {
                    poli.AddListItem(Row.name, Row.id.ToString());
                }
                if (btnPro.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in poli.Items)
                    {
                        if (Item.Value == btnPro.Tag.ToString())
                            popPro.SetSelections(Item);
                    }
                }
                popPro.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        ///挂账人选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPayman_Press(object sender, EventArgs e)
        {
            try
            {
                popPayman.Groups.Clear();       //数据清空
                PopListGroup poli = new PopListGroup();
                popPayman.Groups.Add(poli);
                poli.AddListItem("全部", "-1");
                List<cmdb_payman> deps = _autofacConfig.assPaymanService.GetAll();
                foreach (cmdb_payman Row in deps)
                {
                    poli.AddListItem(Row.name, Row.id.ToString());
                }
                if (btnPayman.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in poli.Items)
                    {
                        if (Item.Value == btnPayman.Tag.ToString())
                            popPayman.SetSelections(Item);
                    }
                }
                popPayman.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        ///挂账人选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUseman_Press(object sender, EventArgs e)
        {
            try
            {
                popUseman.Groups.Clear();       //数据清空
                PopListGroup poli = new PopListGroup();
                popUseman.Groups.Add(poli);
                poli.AddListItem("全部", "-1");
                List<cmdb_useman> deps = _autofacConfig.assUserService.GetAll();
                foreach (cmdb_useman Row in deps)
                {
                    poli.AddListItem(Row.name, Row.id.ToString());
                }
                if (btnUseman.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in poli.Items)
                    {
                        if (Item.Value == btnUseman.Tag.ToString())
                            popUseman.SetSelections(Item);
                    }
                }
                popUseman.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        public void SearchData()
        {
            try
            {
                String DepId = btnDep.Tag == null ? "-1" : btnDep.Tag.ToString();     //选择机房编号
                String Status = btnStatus.Tag == null ? "-1" : btnStatus.Tag.ToString();   //选择资产状态
                String Type = btnType.Tag == null ? "-1" : btnType.Tag.ToString();
                String Pro = btnPro.Tag == null ? "-1" : btnPro.Tag.ToString();
                String Payman = btnPayman.Tag == null ? "-1" : btnPayman.Tag.ToString();
                String Useman = btnUseman.Tag == null ? "-1" : btnUseman.Tag.ToString();

                DateTime dt1 = DateTime.Now;
                DataTable table = _autofacConfig.SettingService.QueryAssets(txtNote.Text, int.Parse(DepId), int.Parse(Status), int.Parse(Type),
                    int.Parse(Pro),int.Parse(Payman), int.Parse(Useman));
                gridAssRows.Cells.Clear();
                Label1.Text = "总共 " + table.Rows.Count + " 条数据";
                DateTime dt2 = DateTime.Now;
                double use1 = (dt2 - dt1).TotalMilliseconds;
                //table.Columns.Add("IsChecked");
                //foreach (DataRow Row in table.Rows)
                //{
                //    if (Row["uuid"].ToString() == SelectAssId)
                //    {
                //        Row["IsChecked"] = true;
                //    }
                //    else
                //    {
                //        Row["IsChecked"] = false;
                //    }
                //}
                if (table.Rows.Count > 0)
                {
                    gridAssRows.DataSource = table;
                    gridAssRows.DataBind();
                }
                DateTime dt3 = DateTime.Now;
                double use2 = (dt3 - dt2).TotalMilliseconds;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
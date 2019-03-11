using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.UI.Layout;
using SMOSEC.DTOs.Enum;

namespace SMOSEC.UI.MasterData
{
    /// <summary>
    /// 创建资产界面
    /// </summary>
    partial class frmAssetsCreate : Smobiler.Core.Controls.MobileForm
    {
        #region 变量
        //public string UserId; //用户名
        //public string LocationId; //区域编号
        //public string ManagerId; //管理人编号

        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public int TypeId;
        public int Brandid;
        public int LocationId;
        public int Pay_man_id;
        public int? Project_id;

        public int? Role_id;
        public int? Team_id;
        public int? CurrentUser;
        public short Status;


        #endregion

        /// <summary>
        /// 添加资产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAssID.Text))
                {
                    throw new Exception("请输入唯一号.");
                }
                if (string.IsNullOrEmpty(txtSN.Text))
                {
                    throw new Exception("请输入SN号.");
                }
                if (btnBrand.Text == "选择（必填）   > ")
                {
                    throw new Exception("请选择品牌型号.");
                }
                if (btnType.Text == "选择（必填）   > ")
                {
                    throw new Exception("请选择资产类型.");
                }
                if (txtSpe.Text == "选择（必填）   > ")
                {
                    throw new Exception("请选择机房.");
                }
                if (string.IsNullOrEmpty(txtLocation.Text))
                {
                    throw new Exception("请输入正确的位置.");
                }
                if (txtStatus1.Text == "选择（必填）   > ")
                {
                    throw new Exception("请选择状态.");
                }
                if (txtPayman1.Text == "选择（必填）   > ")
                {
                    throw new Exception("请选择挂账人.");
                }

                //MessageBox.Show(btnBrand.Tag.ToString());

                AssetsInputDto assetsInputDto = new AssetsInputDto
                {
                    //id = 0,
                    uuid = txtAssID.Text,
                    IP = txtName.Text,
                    asset_number = txtNUm.Text,
                    SN = txtSN.Text,

                    //TypeName = btnType.Text,
                    //Brandname = btnBrand.Text,
                    //LocationName = txtSpe.Text,
                    Position = txtLocation.Text,
                    Status = Status,
                    //Payman = txtPayman1.Text,
                    //Project = txtPro1.Text,
                    //Team = txtTeam1.Text,
                    //Role = txtRole1.Text,
                    //CurrentUserName = txtUserman1.Text,

                    //BorrowDate = txtBordate1.Value,
                    //ReturnDate = txtRedate1.Value,
                    give_time = txtBordate1.Tag != null ? txtBordate1.Value : new Nullable<DateTime>(),
                    return_time = txtRedate1.Tag != null ? txtRedate1.Value : new Nullable<DateTime>(),

                    //give_time = DateTime.Now,
                    //return_time = DateTime.Now,
                    remark = txtNote.Text,

                    asset_type_id = TypeId,
                    brand_id = Brandid,
                    machine_room_id = LocationId,
                    pay_man_id = Pay_man_id,

                    project_id = popPro.Selection != null ? Project_id : null,
                    role_id = popRole.Selection != null ? Role_id : null,
                    team_id = popTeam.Selection != null ? Team_id : null,
                    use_man_id = popUser.Selection != null ? CurrentUser : null,
                    //project_id = (bool)txtPro1.Tag == true ? Project_id : null,
                    //role_id = (bool)txtRole1.Tag == true ? Role_id : null,
                    //team_id = (bool)txtTeam1.Tag == true ? Team_id : null,
                    //use_man_id = (bool)txtUserman1.Tag == true ? CurrentUser : null,

                    modify_date = DateTime.Now

                };

                string username = Client.Session["local_username"].ToString();
                ReturnInfo returnInfo = _autofacConfig.SettingService.AddAssets(assetsInputDto, username);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.No;
                    Close();
                    Toast("添加成功.资产唯一号为" + returnInfo.ErrorInfo);
                }
                else
                {
                    Toast(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
            //try
            //{
            //    if (string.IsNullOrEmpty(LocationId))
            //    {
            //        throw new Exception("请选择区域！");
            //    }
            //    decimal price;
            //    if(btnType.Tag == null)
            //    {
            //        throw new Exception("请选择类别!");
            //    }
            //    if (!decimal.TryParse(txtPrice.Text, out price))
            //    {
            //        throw new Exception("请输入正确的单价！");
            //    }
            //    AssetsInputDto assetsInputDto = new AssetsInputDto
            //    {
            //        AssId = txtAssID.Text,
            //        BuyDate = DatePickerBuy.Value,
            //        CreateUser = UserId,
            //        CurrentUser = "",
            //        DepartmentId = DepId,
            //        ExpiryDate = DatePickerExpiry.Value,
            //        Image = ImgPicture.ResourceID,
            //        LocationId = LocationId,
            //        Manager =ManagerId,
            //        ModifyUser = UserId,
            //        Name = txtName.Text,
            //        Note = txtNote.Text,
            //        Place = txtPlace.Text, 
            //        Price = price,
            //        Specification = txtSpe.Text,
            //        TypeId = btnType.Tag.ToString(),
            //        Unit = txtUnit.Text,
            //        Vendor = txtVendor.Text,
            //        SN = txtSN.Text
            //    };
            //    if (String.IsNullOrEmpty(txtPrice.Text) == false)
            //        assetsInputDto.Price = decimal.Parse(txtPrice.Text);
            //    ReturnInfo returnInfo = _autofacConfig.SettingService.AddAssets(assetsInputDto);
            //    if (returnInfo.IsSuccess)
            //    {
            //        ShowResult = ShowResult.Yes;
            //        Close();
            //        Toast("添加成功.资产编号为"+returnInfo.ErrorInfo);
            //    }
            //    else
            //    {
            //        Toast(returnInfo.ErrorInfo);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}

        }

        /// <summary>
        /// 选择类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnType_Press(object sender, EventArgs e)
        {
            //try
            //{
            //    string TypeId = "";
            //    if (btnType.Tag != null)
            //    {
            //        TypeId = btnType.Tag.ToString();
            //    }
            //    frmAssTypeChooseLayout layout = new frmAssTypeChooseLayout { IsCreate = true, typeId = TypeId };
            //    ShowDialog(layout);
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }
        /// <summary>
        /// 选择区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocation_Press(object sender, EventArgs e)
        {
            //try
            //{
            //    PopLocation.Groups.Clear();
            //    PopListGroup locationGroup = new PopListGroup();
            //    List<AssLocation> locations = _autofacConfig.assLocationService.GetEnableAll();
            //    foreach (var location in locations)
            //    {
            //        PopListItem item = new PopListItem
            //        {
            //            Value = location.LOCATIONID,
            //            Text = location.NAME
            //        };
            //        locationGroup.Items.Add(item);
            //    }
            //    PopLocation.Groups.Add(locationGroup);
            //    if (!string.IsNullOrEmpty(btnLocation.Text))
            //    {
            //        foreach (PopListItem row in PopLocation.Groups[0].Items)
            //        {
            //            if (row.Text == btnLocation.Text)
            //            {
            //                PopLocation.SetSelections(row);
            //            }
            //        }
            //    }
            //    PopLocation.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //   Toast(ex.Message);
            //}

        }
        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelImg_Press(object sender, EventArgs e)
        {
            CamPicture.GetPhoto();
        }
        /// <summary>
        /// 选择区域后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopLocation_Selected(object sender, EventArgs e)
        {
            //try
            //{
            //    if (PopLocation.Selection == null) return;
            //    btnLocation.Text = PopLocation.Selection.Text;
            //    LocationId = PopLocation.Selection.Value;
            //    AssLocation location = _autofacConfig.assLocationService.GetByID(LocationId);
            //    coreUser manager = _autofacConfig.coreUserService.GetUserByID(location.MANAGER);
            //    ManagerId = location.MANAGER;
            //    txtManager.Text = manager.USER_NAME;
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }
        /// <summary>
        /// 图片获取到后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CamPicture_ImageCaptured(object sender, BinaryResultArgs e)
        {
            //try
            //{
            //    if (string.IsNullOrEmpty(e.error))
            //    {
            //        e.SaveFile(UserId + DateTime.Now.ToString("yyyyMMddHHmm") + ".png");
            //        ImgPicture.ResourceID = UserId + DateTime.Now.ToString("yyyyMMddHHmm");
            //        ImgPicture.Refresh();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }

        /// <summary>
        /// 按回退时，关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsCreate_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    DatePickerExpiry.Value = DateTime.Now.AddYears(1);
            //    UserId = Session["UserID"].ToString();
            //    if (Client.Session["Role"].ToString() == "SMOSECAdmin")
            //    {
            //        var user = _autofacConfig.coreUserService.GetUserByID(UserId);
            //        LocationId = user.USER_LOCATIONID;
            //        var location = _autofacConfig.assLocationService.GetByID(LocationId);
            //        btnLocation.Text = location.NAME;
            //        btnLocation.Enabled = false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }

        /// <summary>
        /// 手机扫描二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgBtnForAssId_Press(object sender, EventArgs e)
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
        /// 手机扫描到二维码信息时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcodeScanner1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                txtSN.Text = barCode;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手持物理按键扫描二维码，扫描到二维码时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            try
            {
                string barCode = e.Data;
                txtSN.Text = barCode;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手持物理按键扫描RFID，扫描到RFID时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.R2000RFIDScanEventArgs e)
        {
            try
            {
                string RFID = e.Epc;
                txtSN.Text = RFID;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 选择部门时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDep_Press(object sender, EventArgs e)
        {
            //try
            //{
            //    popDep.Groups.Clear();
            //    PopListGroup depGroup = new PopListGroup { Title = "部门" };
            //    var deplist = _autofacConfig.DepartmentService.GetAllDepartment();
            //    foreach (var dep in deplist)
            //    {
            //        PopListItem item = new PopListItem
            //        {
            //            Value = dep.DEPARTMENTID,
            //            Text = dep.NAME
            //        };
            //        depGroup.Items.Add(item);
            //    }
            //    popDep.Groups.Add(depGroup);
            //    if (!string.IsNullOrEmpty(DepId))
            //    {
            //        foreach (PopListItem row in popDep.Groups[0].Items)
            //        {
            //            if (row.Value == DepId)
            //            {
            //                popDep.SetSelections(row);
            //            }
            //        }
            //    }
            //    popDep.ShowDialog();
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }

        /// <summary>
        /// 选择型号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBrand1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popBrand.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup(); //{ Title = "品牌型号" };

                var brandlist = _autofacConfig.assBrandService.GetAll();
                foreach (var dep in brandlist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = dep.id.ToString(),
                        Text = dep.name
                    };
                    brandGroup.Items.Add(item);
                }
                popBrand.Groups.Add(brandGroup);

                popBrand.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 选择了型号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popBrand_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popBrand.Selection == null) return;
                btnBrand.Text = popBrand.Selection.Text + "   > ";
                Brandid = int.Parse(popBrand.Selection.Value);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        //类型
        private void txtType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popType.Groups.Clear();
                PopListGroup typeGroup = new PopListGroup { Title = "类型" };
                var typelist = _autofacConfig.assTypeService.GetAllFirstLevel();
                foreach (var dep in typelist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = dep.id.ToString(),
                        Text = dep.name
                    };
                    typeGroup.Items.Add(item);
                }
                popType.Groups.Add(typeGroup);

                popType.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void popType_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popType.Selection == null) return;
                
                btnType.Text = popType.Selection.Text + "   > ";
                TypeId = int.Parse(popType.Selection.Value);
                
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        //机房
        private void txtRoom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popRoom.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "品牌型号" };
                var brandlist = _autofacConfig.DepartmentService.GetAll();
                foreach (var dep in brandlist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = dep.id.ToString(),
                        Text = dep.name
                    };
                    brandGroup.Items.Add(item);
                }
                popRoom.Groups.Add(brandGroup);

                popRoom.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void popRoom_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popRoom.Selection == null) return;

                txtSpe.Text = popRoom.Selection.Text + "   > ";
                LocationId = int.Parse(popRoom.Selection.Value);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        //挂账人
        private void txtPayman_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popPayman.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "品牌型号" };
                var brandlist = _autofacConfig.assPaymanService.GetAll();
                foreach (var dep in brandlist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = dep.id.ToString(),
                        Text = dep.name
                    };
                    brandGroup.Items.Add(item);
                }
                popPayman.Groups.Add(brandGroup);

                popPayman.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void popPayman_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popPayman.Selection == null) return;

                txtPayman1.Text = popPayman.Selection.Text + "   > ";
                Pay_man_id = int.Parse(popPayman.Selection.Value);
                
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        //项目
        private void txtPro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popPro.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "品牌型号" };
                var brandlist = _autofacConfig.assProService.GetAll();
                foreach (var dep in brandlist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = dep.id.ToString(),
                        Text = dep.name
                    };
                    brandGroup.Items.Add(item);
                }
                popPro.Groups.Add(brandGroup);

                popPro.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void popPro_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popPro.Selection != null)
                {
                    txtPro1.Text = popPro.Selection.Text + "   > ";
                    Project_id = int.Parse(popPro.Selection.Value);
                    txtPro1.Tag = true;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        //团队
        private void txtTeam_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popTeam.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "品牌型号" };
                var brandlist = _autofacConfig.assTeamService.GetAll();
                foreach (var dep in brandlist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = dep.id.ToString(),
                        Text = dep.name
                    };
                    brandGroup.Items.Add(item);
                }
                popTeam.Groups.Add(brandGroup);

                popTeam.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void popTeam_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popTeam.Selection != null)
                {
                    txtTeam1.Text = popTeam.Selection.Text + "   > ";
                    Team_id = int.Parse(popTeam.Selection.Value);
                    txtTeam1.Tag = true;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        //角色
        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popRole.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "品牌型号" };
                var brandlist = _autofacConfig.assRoleService.GetAll();
                foreach (var dep in brandlist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = dep.id.ToString(),
                        Text = dep.name
                    };
                    brandGroup.Items.Add(item);
                }
                popRole.Groups.Add(brandGroup);

                popRole.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void popRole_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popRole.Selection != null)
                {
                    txtRole1.Text = popRole.Selection.Text + "   > ";
                    Role_id = int.Parse(popRole.Selection.Value);
                    txtRole1.Tag = true;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        //使用人
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popUser.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "品牌型号" };
                var brandlist = _autofacConfig.assUserService.GetAll();
                foreach (var dep in brandlist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = dep.id.ToString(),
                        Text = dep.name
                    };
                    brandGroup.Items.Add(item);
                }
                popUser.Groups.Add(brandGroup);

                popUser.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void popUser_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popUser.Selection != null)
                {
                    txtUserman1.Text = popUser.Selection.Text + "   > ";
                    CurrentUser = int.Parse(popUser.Selection.Value);
                    txtUserman1.Tag = true;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        //状态
        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popStatus.Groups.Clear();
                PopListGroup StatusGroup = new PopListGroup { Title = "类型" };
                for (int i = 0; i < 6; i++)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "在用"
                                };
                                StatusGroup.Items.Add(item);
                                break;
                            }
                        case 1:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "闲置"
                                };
                                StatusGroup.Items.Add(item);
                                break;
                            }
                        case 2:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "送测"
                                };
                                StatusGroup.Items.Add(item);
                                break;
                            }
                        case 3:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "外借"
                                };
                                StatusGroup.Items.Add(item);
                                break;
                            }
                        case 4:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "损坏"
                                };
                                StatusGroup.Items.Add(item);
                                break;
                            }
                        case 5:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "未知"
                                };
                                StatusGroup.Items.Add(item);
                                break;
                            }

                    }

                }

                popStatus.Groups.Add(StatusGroup);

                popStatus.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        private void popStatus_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popStatus.Selection != null)
                {
                    txtStatus1.Text = popStatus.Selection.Text + "   > ";
                    Status = short.Parse(popStatus.Selection.Value);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void txtBordate1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtBordate1.Tag = true;
            }
            catch ( Exception ex)
            {
                Toast(ex.Message);
            }
        }

        private void txtRedate1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtRedate1.Tag = true;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


    }
}
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
    /// �����ʲ�����
    /// </summary>
    partial class frmAssetsCreate : Smobiler.Core.Controls.MobileForm
    {
        #region ����
        //public string UserId; //�û���
        //public string LocationId; //������
        //public string ManagerId; //�����˱��

        private AutofacConfig _autofacConfig = new AutofacConfig();//����������

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
        /// ����ʲ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAssID.Text))
                {
                    throw new Exception("������Ψһ��.");
                }
                if (string.IsNullOrEmpty(txtSN.Text))
                {
                    throw new Exception("������SN��.");
                }
                if (btnBrand.Text == "ѡ�񣨱��   > ")
                {
                    throw new Exception("��ѡ��Ʒ���ͺ�.");
                }
                if (btnType.Text == "ѡ�񣨱��   > ")
                {
                    throw new Exception("��ѡ���ʲ�����.");
                }
                if (txtSpe.Text == "ѡ�񣨱��   > ")
                {
                    throw new Exception("��ѡ�����.");
                }
                if (string.IsNullOrEmpty(txtLocation.Text))
                {
                    throw new Exception("��������ȷ��λ��.");
                }
                if (txtStatus1.Text == "ѡ�񣨱��   > ")
                {
                    throw new Exception("��ѡ��״̬.");
                }
                if (txtPayman1.Text == "ѡ�񣨱��   > ")
                {
                    throw new Exception("��ѡ�������.");
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
                    Toast("��ӳɹ�.�ʲ�Ψһ��Ϊ" + returnInfo.ErrorInfo);
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
            //        throw new Exception("��ѡ������");
            //    }
            //    decimal price;
            //    if(btnType.Tag == null)
            //    {
            //        throw new Exception("��ѡ�����!");
            //    }
            //    if (!decimal.TryParse(txtPrice.Text, out price))
            //    {
            //        throw new Exception("��������ȷ�ĵ��ۣ�");
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
            //        Toast("��ӳɹ�.�ʲ����Ϊ"+returnInfo.ErrorInfo);
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
        /// ѡ������
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
        /// ѡ������
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
        /// �ϴ�ͼƬ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelImg_Press(object sender, EventArgs e)
        {
            CamPicture.GetPhoto();
        }
        /// <summary>
        /// ѡ�������
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
        /// ͼƬ��ȡ����
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
        /// ������ʱ���رյ�ǰ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// �����ʼ��
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
        /// �ֻ�ɨ���ά��
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
        /// �ֻ�ɨ�赽��ά����Ϣʱ
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
        /// �ֳ�������ɨ���ά�룬ɨ�赽��ά��ʱ
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
        /// �ֳ�������ɨ��RFID��ɨ�赽RFIDʱ
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
        /// ѡ����ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDep_Press(object sender, EventArgs e)
        {
            //try
            //{
            //    popDep.Groups.Clear();
            //    PopListGroup depGroup = new PopListGroup { Title = "����" };
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
        /// ѡ���ͺ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBrand1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popBrand.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup(); //{ Title = "Ʒ���ͺ�" };

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
        /// ѡ�����ͺ�
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


        //����
        private void txtType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popType.Groups.Clear();
                PopListGroup typeGroup = new PopListGroup { Title = "����" };
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

        //����
        private void txtRoom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popRoom.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "Ʒ���ͺ�" };
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

        //������
        private void txtPayman_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popPayman.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "Ʒ���ͺ�" };
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
        //��Ŀ
        private void txtPro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popPro.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "Ʒ���ͺ�" };
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
        //�Ŷ�
        private void txtTeam_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popTeam.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "Ʒ���ͺ�" };
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
        //��ɫ
        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popRole.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "Ʒ���ͺ�" };
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
        //ʹ����
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popUser.Groups.Clear();
                PopListGroup brandGroup = new PopListGroup { Title = "Ʒ���ͺ�" };
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


        //״̬
        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                popStatus.Groups.Clear();
                PopListGroup StatusGroup = new PopListGroup { Title = "����" };
                for (int i = 0; i < 6; i++)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "����"
                                };
                                StatusGroup.Items.Add(item);
                                break;
                            }
                        case 1:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "����"
                                };
                                StatusGroup.Items.Add(item);
                                break;
                            }
                        case 2:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "�Ͳ�"
                                };
                                StatusGroup.Items.Add(item);
                                break;
                            }
                        case 3:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "���"
                                };
                                StatusGroup.Items.Add(item);
                                break;
                            }
                        case 4:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "��"
                                };
                                StatusGroup.Items.Add(item);
                                break;
                            }
                        case 5:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),
                                    Text = "δ֪"
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
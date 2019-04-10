using System;
using Smobiler.Core.Controls;
using SMOSEC.CommLib;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;
using SMOSEC.UI.Layout;
using SMOSEC.DTOs.Enum;

namespace SMOSEC.UI.MasterData
{
    /// <summary>
    /// �ʲ��޸�
    /// </summary>
    partial class frmAssetsDetailEdit : Smobiler.Core.Controls.MobileForm
    {
        #region ����
        public string UserId;  //�û����
                               //        public string TypeId; //���ͱ��
                               //public string LocationId;  //������
                               //public string ManagerId;  //����Ա���
                               //public string CurrentUserId;  //��ǰ�û����

        AutofacConfig _autofacConfig = new AutofacConfig();//����������

        //public string DepId; //���ű��
        public string SN;  //�ʲ����
        public int id;

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
        /// �޸��ʲ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Press(object sender, EventArgs e)
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
                if (string.IsNullOrEmpty(btnType.Text))
                {
                    throw new Exception("��ѡ���ʲ�����.");
                }
                if (string.IsNullOrEmpty(btnBrand.Text))
                {
                    throw new Exception("��ѡ��Ʒ���ͺ�.");
                }
                if (string.IsNullOrEmpty(txtSpe.Text))
                {
                    throw new Exception("��ѡ�����.");
                }
                if (string.IsNullOrEmpty(txtLocation.Text))
                {
                    throw new Exception("��������ȷ��λ��.");
                }
                if (string.IsNullOrEmpty(txtStatus1.Text))
                {
                    throw new Exception("��ѡ��״̬.");
                }
                if (string.IsNullOrEmpty(txtPayman1.Text))
                {
                    throw new Exception("��ѡ�������.");
                }


                AssetsInputDto assetsInputDto = new AssetsInputDto
                {
                    //id = id,
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

                    //give_time = txtBordate1.Value,
                    //return_time = txtRedate1.Value,
                    give_time = txtBordate1.Tag != null ? txtBordate1.Value : new Nullable<DateTime>(),
                    return_time = txtRedate1.Tag != null ? txtRedate1.Value : new Nullable<DateTime>(),
                    remark = txtNote.Text,

                    asset_type_id = TypeId,
                    brand_id = Brandid,
                    machine_room_id = LocationId,
                    pay_man_id = Pay_man_id,

                    project_id = popPro.Selection != null ? Project_id : null,
                    role_id = popRole.Selection != null ? Role_id : null,
                    team_id = popTeam.Selection != null ? Team_id : null,
                    use_man_id = popUser.Selection != null ? CurrentUser : null,
                    modify_date = DateTime.Now
                };
                //MessageBox.Show(txtRedate1.Value.ToString());
                string username = Client.Session["local_username"].ToString();
                ReturnInfo returnInfo = _autofacConfig.SettingService.UpdateAssets(assetsInputDto, username);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.No;
                    //ShowResult = ShowResult.Yes;
                    Close();
                    Toast("�޸ĳɹ�.");
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
                if (popBrand.Selection != null)
                {
                    btnBrand.Text = popBrand.Selection.Text + "   > ";
                    Brandid = int.Parse(popBrand.Selection.Value);
                }
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
                if (popType.Selection != null)
                {
                    btnType.Text = popType.Selection.Text + "   > ";
                    TypeId = int.Parse(popType.Selection.Value);
                }
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
                if (popRoom.Selection != null)
                {
                    txtSpe.Text = popRoom.Selection.Text + "   > ";
                    LocationId = int.Parse(popRoom.Selection.Value);
                }
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
                if (popPayman.Selection != null)
                {
                    txtPayman1.Text = popPayman.Selection.Text + "   > ";
                    Pay_man_id = int.Parse(popPayman.Selection.Value);
                }
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
                    switch(i)
                    {
                        case 0:
                            {
                                PopListItem item = new PopListItem
                                {
                                    Value = i.ToString(),Text = "����"
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





        /// <summary>
        /// �ʲ�����ѡ��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnType_Press(object sender, EventArgs e)
        {
            //try
            //{
            //    frmAssTypeChooseLayout layout = new frmAssTypeChooseLayout { IsCreate = false, typeId = btnType.Tag.ToString() };
            //    ShowDialog(layout);
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }

        /// <summary>
        /// ����ϴ�ͼƬʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelImg_Press(object sender, EventArgs e)
        {
            CamPicture.GetPhoto();
        }




        /// <summary>
        /// ��ȡ��ͼƬ���ݺ�
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
        /// ������
        /// </summary>
        private void Bind()
        {
            try
            {
                AssetsOutputDto outputDto = _autofacConfig.SettingService.GetAssetsBysn(SN);
                if (outputDto != null)
                {
                    id = outputDto.id;
                    txtAssID.Text = outputDto.AssId;
                    txtName.Text = outputDto.IP;
                    txtNUm.Text = outputDto.Num;
                    txtSN.Text = outputDto.SN;
                    btnType.Text = outputDto.TypeName + "   > ";
                    TypeId = outputDto.TypeId;
                    //txtBrand1.Text = outputDto.Brandname;
                    btnBrand.Text = outputDto.Brandname + "   > ";
                    txtSpe.Text = outputDto.LocationName + "   > ";
                    txtLocation.Text = outputDto.Position;
                    txtStatus1.Text = Enum.GetName(typeof(STATUS), outputDto.Status) + "   > ";
                    txtPayman1.Text = outputDto.Payman + "   > ";
                    txtPro1.Text = outputDto.Project + "   > ";
                    txtTeam1.Text = outputDto.Team + "   > ";
                    txtRole1.Text = outputDto.Role + "   > ";
                    txtUserman1.Text = outputDto.CurrentUserName + "   > ";


                    if (outputDto.BorrowDate.HasValue)
                    {
                        DateTime boDate = outputDto.BorrowDate.Value;
                        txtBordate1.Value = boDate;
                        txtBordate1.Tag = true;
                    }
                    else
                    {
                        txtBordate1.Tag = null;
                        //txtBordate1 = null;
                        //txtBordate1.Value = Convert.ToDateTime(null);
                    }
                    if (outputDto.ReturnDate.HasValue)
                    {
                        //DateTime reDate = outputDto.ReturnDate.Value;
                        //txtRedate1.Value = reDate;
                        //MessageBox.Show(txtRedate1.Value.ToString());
                        txtRedate1.Value = outputDto.ReturnDate.Value;
                        txtBordate1.Tag = true;
                    }
                    else
                    {
                        txtRedate1.Tag = null;
                        //txtRedate1 = null;

                        //txtRedate1.Visible = false;
                        //txtRedate1.Value = Convert.ToDateTime(now);

                        //txtRedate1.Value = Convert.ToDateTime(null);

                        //txtRedate1.Value = Convert.ToDateTime(new Nullable<DateTime>());
                        //MessageBox.Show(txtRedate1.Value.ToString());
                        //string strDate = string.Empty;
                        //System.ComponentModel.NullableConverter nullableDateTime = new System.ComponentModel.NullableConverter(typeof(DateTime?));
                        //DateTime? dt2 = (DateTime?)nullableDateTime.ConvertFromString(strDate);
                        //txtRedate1.Value = (DateTime)dt2;
                    }


                    txtNote.Text = outputDto.Note;

                    Status = outputDto.Status;
                    Brandid = outputDto.Brandid;
                    LocationId = outputDto.LocationId;
                    Pay_man_id = outputDto.pay_man_id;
                    Project_id = outputDto.project_id;
                    Role_id = outputDto.role_id;
                    Team_id = outputDto.team_id;
                    CurrentUser = outputDto.CurrentUser;

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �����˼�ʱ���رյ�ǰ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsDetailEdit_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();

            }

        }

        /// <summary>
        /// �����ʼ��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsDetailEdit_Load(object sender, EventArgs e)
        {
            try
            {
                Bind();
                //UserId = Session["UserID"].ToString();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �ֻ�ɨ��ά�����SN
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
        /// �ֳ�������ɨ���ά�룬ɨ�赽��ά������ʱ
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
        /// �ֻ�ɨ�赽��ά��ʱ
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

        private void txtBordate1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtBordate1.Tag = true;
            }
            catch (Exception ex)
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


        //private void txtRedate_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Smobiler.Core.Controls.DatePicker datePicker10 = new Smobiler.Core.Controls.DatePicker();
        //        datePicker10.Location = new System.Drawing.Point(100, 600);
        //        datePicker10.Name = "datePicker10";
        //        datePicker10.Size = new System.Drawing.Size(100, 30);
        //        datePicker10.BindDisplayValue = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Toast(ex.Message);
        //    }
        //}


    }
}
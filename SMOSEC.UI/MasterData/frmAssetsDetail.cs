using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.OutputDTO;
using Smobiler.Device;
using SMOSEC.DTOs.Enum;
using SMOSEC.UI.AssetsManager;

namespace SMOSEC.UI.MasterData
{
    /// <summary>
    /// �ʲ��������
    /// </summary>
    partial class frmAssetsDetail : Smobiler.Core.Controls.MobileForm
    {
        #region ����
        public int id;
        public string SN; //�ʲ�SN
        public string AssId; //�ʲ����
        private string LocationId; //������
        private string TypeId; //���ͱ��
        private string ManagerId; //����Ա���
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������
        private string LastUser; //�ʲ������ӵ����
        private string DepId; //���ű��
        #endregion

        /// <summary>
        /// �鿴�����¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLog_Press(object sender, EventArgs e)
        {
            //try
            //{
            //    frmPrShow prShow = new frmPrShow { AssId = AssId };
            //    Show(prShow);
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }

        /// <summary>
        /// ��ת���ʲ��༭����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Press(object sender, EventArgs e)
        {
            try
            {
                if (Client.Session["permission"].ToString() == "guest")
                {
                    throw new Exception("�Բ�����û���޸�Ȩ�ޣ�");
                }
                frmAssetsDetailEdit assetsDetailEdit = new frmAssetsDetailEdit { SN = SN };
                Show(assetsDetailEdit, (MobileForm sender1, object args) =>
                {
                    if (assetsDetailEdit.ShowResult == ShowResult.Yes)
                    {
                        ShowResult = ShowResult.Yes;
                        Bind();
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// ��ת���ʲ��༭����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRepair_Press(object sender, EventArgs e)
        {
            try
            {
                //if (Client.Session["permission"].ToString() == "guest")
                //{
                //    throw new Exception("�Բ�����û���޸�Ȩ�ޣ�");
                //}
                frmRepairCreateSN frm = new frmRepairCreateSN(SN);
                //frmRepairCreateSN assetsDetailEdit = new frmAssetsDetailEdit { SN = SN };
                Show(frm, (MobileForm sender1, object args) =>
                {
                    if (frm.ShowResult == ShowResult.Yes)
                    {
                        ShowResult = ShowResult.Yes;
                        Bind();
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
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
                    txtAssId1.Text = outputDto.AssId;
                    txtIP1.Text = outputDto.IP;
                    txtNUm.Text = outputDto.Num;
                    txtSN1.Text = outputDto.SN;
                    txtType.Text = outputDto.TypeName;
                    txtType.Tag = outputDto.TypeId;

                    txtBrand1.Text = outputDto.Brandname;
                    txtSPE1.Text = outputDto.LocationName;
                    txtLocation1.Text = outputDto.Position;
                    txtStatus1.Text = Enum.GetName(typeof(STATUS), outputDto.Status);
                    txtPayman1.Text = outputDto.Payman;
                    txtPro1.Text = outputDto.Project;
                    txtTeam1.Text = outputDto.Team;
                    txtRole1.Text = outputDto.Role;
                    txtUserman1.Text = outputDto.CurrentUserName;

                    txtNote1.Text = outputDto.Note;

                    txtStatus1.Tag = outputDto.Status;
                    txtBrand1.Tag = outputDto.Brandid;
                    txtSPE1.Tag = outputDto.LocationId;
                    txtPayman1.Tag = outputDto.pay_man_id;
                    txtPro1.Tag = outputDto.project_id;
                    txtRole1.Tag = outputDto.role_id;
                    txtTeam1.Tag = outputDto.team_id;
                    txtUserman1.Tag = outputDto.CurrentUser;

                    //txtBordate1.Text = txtBordate1.Tag != null ? outputDto.BorrowDate.Value.ToString() : "";
                    //txtRedate1.Text = txtRedate1.Tag != null ? outputDto.ReturnDate.Value.ToString() : "";

                    if (outputDto.BorrowDate.HasValue)
                    {
                        DateTime boDate = outputDto.BorrowDate.Value;
                        txtBordate1.Text = boDate.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        txtBordate1.Text = "";
                    }

                    if (outputDto.ReturnDate.HasValue)
                    {
                        DateTime reDate = outputDto.ReturnDate.Value;
                        txtRedate1.Text = reDate.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        txtRedate1.Text = "";
                    }


                    //if (string.IsNullOrEmpty(outputDto.CurrentUser))
                    //{
                    //    btnChange.Visible = false;
                    //    btnChange.Enabled = false;
                    //}
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ������ʱ���رյ�ǰ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                //ShowResult = ShowResult.Yes;
                ShowResult = ShowResult.No;
                Close();

            }

        }

        /// <summary>
        /// �����ʼ��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsDetail_Load(object sender, EventArgs e)
        {
            try
            {
                //if (Client.Session["Role"].ToString() == "SMOSECUser")
                //{
                //    btnChange.Visible = false;
                //    btnEdit.Visible = false;
                //    btnLog.Flex = 1;
                //}

                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �����ʲ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Press(object sender, EventArgs e)
        {
            //try
            //{
            //    frmAssetsCreate assetsCreate = new frmAssetsCreate
            //    {
            //        DatePickerBuy = { Value = Convert.ToDateTime(txtBuyDate.Text) },
            //        DepId = DepId,
            //        btnDep = { Text = txtDep.Text + "   > " },
            //        DatePickerExpiry = { Value = Convert.ToDateTime(txtRole1.Text) },
            //        ImgPicture = { ResourceID = image2.ResourceID },
            //        LocationId = LocationId,
            //        btnLocation = { Text = txtLocation1.Text },
            //        ManagerId = ManagerId,
            //        txtManager = { Text = txtManager.Text },
            //        txtName = { Text = txtName1.Text },
            //        txtNote = { Text = txtNote1.Text },
            //        txtPlace = { Text = txtPlace1.Text },
            //        txtPrice = { Text = txtPrice1.Text },
            //        txtSpe = { Text = txtSPE1.Text },
            //        btnType = { Tag = TypeId, Text = txtType.Text },
            //        txtUnit = { Text = txtUnit1.Text },
            //        txtVendor = { Text = txtVendor1.Text }
            //    };



            //    Show(assetsCreate);
            //    Close();
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}

        }

        /// <summary>
        /// ���ʹ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Press(object sender, EventArgs e)
        {
            //try
            //{
            //    popCurrentUser.Groups.Clear();
            //    PopListGroup poli = new PopListGroup();
            //    popCurrentUser.Groups.Add(poli);
            //    poli.Title = "ʹ���߱��";
            //    List<coreUser> users = _autofacConfig.coreUserService.GetAll();
            //    foreach (coreUser Row in users)
            //    {
            //        poli.AddListItem(Row.USER_NAME, Row.USER_ID);
            //    }
            //    Assets assets = _autofacConfig.orderCommonService.GetAssetsBysn(txtAssId1.Text);
            //    foreach (PopListItem Item in poli.Items)
            //    {
            //        if (Item.Value == assets.CURRENTUSER)
            //        {
            //            popCurrentUser.SetSelections(Item);
            //            LastUser = assets.CURRENTUSER;
            //        }
            //    }
            //    popCurrentUser.ShowDialog();

            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}

        }

        /// <summary>
        /// ��ǰʹ����ѡ�к�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popCurrentUser_Selected(object sender, EventArgs e)
        {
            //try
            //{
            //    if (popCurrentUser.Selection.Value != LastUser)     //���������ʹ����
            //    {
            //        ReturnInfo RInfo = _autofacConfig.AssetsService.ChangeUser(AssId, popCurrentUser.Selection.Value, Client.Session["UserID"].ToString());
            //        if (RInfo.IsSuccess)
            //        {
            //            Toast("����ʹ���߳ɹ�!");
            //            LastUser = popCurrentUser.Selection.Value;
            //        }
            //        else
            //        {
            //            throw new Exception(RInfo.ErrorInfo);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }
        /// <summary>
        /// ��ӡ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Press(object sender, EventArgs e)
        {
            //try
            //{
            //    AssetsOutputDto outputDto = _autofacConfig.SettingService.GetAssetsBysn(AssId);
            //    PosPrinterEntityCollection Commands = new PosPrinterEntityCollection();
            //    Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Initial));
            //    Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.EnabledBarcode));
            //    Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.AbsoluteLocation));
            //    Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128Height, "62"));
            //    Commands.Add(new PosPrinterBarcodeEntity(PosBarcodeType.CODE128, outputDto.SN));
            //    Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.DisabledBarcode));
            //    Commands.Add(new PosPrinterContentEntity(System.Environment.NewLine));
            //    Commands.Add(new PosPrinterProtocolEntity(PosPrinterProtocol.Cut));

            //    posPrinter1.Print(Commands, (obj, args) =>
            //    {
            //        if (args.isError == true)
            //            this.Toast("Error: " + args.error);
            //        else
            //            this.Toast("��ӡ�ɹ�");
            //    });
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }
        /// <summary>
        /// �ʲ�ɾ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Press(object sender, EventArgs e)
        {
            try
            {
                if (Client.Session["permission"].ToString() == "guest")
                {
                    throw new Exception("�Բ�����û��ɾ��Ȩ�ޣ�");
                }
                //AssetsOutputDto ass = _autofacConfig.SettingService.GetAssetsByID(AssId);
                //if (ass.Status != (int)STATUS.����) throw new Exception("�ʲ����ڷǿ���״̬�У��޷�ɾ��!");
                MessageBox.Show("�Ƿ�ȷ��ɾ�����ʲ���", "ϵͳ��ʾ", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.Yes)
                        {
                            ReturnInfo RInfo = _autofacConfig.SettingService.DeleteAssets(SN, Client.Session["local_username"].ToString());
                            if (RInfo.IsSuccess)
                            {
                                Toast("ɾ���ɹ�!");
                                ShowResult = ShowResult.Yes;
                                Close();
                            }
                            else
                            {
                                throw new Exception(RInfo.ErrorInfo);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Toast(ex.Message);
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
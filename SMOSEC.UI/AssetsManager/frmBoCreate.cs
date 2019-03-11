using System;
using System.Collections.Generic;
using System.Data;
using Smobiler.Core.Controls;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using System.Text.RegularExpressions;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmBoCreate : Smobiler.Core.Controls.MobileForm
    {
        #region  �������
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������

        public List<int> AssIdList = new List<int>(); //���������ASSID�ļ���

        public DataTable AssTable = new DataTable();   //�������ݵı��
        public string Position;
        public int BoManId;
        public string HManId;
        private string UserId;
        private short Expired;

        public int Project_id;
        public int Team_id;
        public int Boid;
        #endregion

        /// <summary>
        /// ������õ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                //if (AssIdList.Count == 0)
                //{
                //    throw new Exception("����ӽ��õ��ʲ���");
                //}
                if (String.IsNullOrEmpty(txtManager.Text))
                    throw new Exception("��������˲���Ϊ��");

                if (String.IsNullOrEmpty(btnLocation.Text))
                    throw new Exception("��Դ������Ϊ��");

                if (string.IsNullOrEmpty(btnPro.Text))
                {
                    throw new Exception("��ѡ����Ŀ.");
                }

                if (string.IsNullOrEmpty(btnTeam.Text))
                {
                    throw new Exception("��ѡ���Ŷ�.");
                }
                if (txtphone.Text.Trim().Length <= 0)    //�Ƿ����ֻ�����
                    throw new Exception("������绰����!");

                Regex regex = new Regex(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$");
                if (regex.IsMatch(txtphone.Text) == false)
                    throw new Exception("�ֻ������ʽ����ȷ!");


                if (DPickerRs.Value == DateTime.Now)
                    throw new Exception("��ѡ��Ԥ�ƹ黹����!");

                AssBorrowOrderInputDto assBorrowOrderInput = new AssBorrowOrderInputDto
                {

                    //Assids = AssIdList,
                    phone = txtphone.Text,//fixme
                    principal = txtManager.Text,
                    give_time = DPickerCO.Value,
                    return_time = DPickerRs.Value,//DateTime.Now.AddMonths(1),fixme ʱ�䲻ѡҲ������
                    expired = 1,
                    position = btnLocation.Text,
                    project_id = Project_id,
                    team_id = Team_id,  
                    use_man_id = BoManId,
                    remark = txtNote.Text
                };
                ReturnInfo returnInfo = _autofacConfig.AssetsService.AddAssBorrowOrder(assBorrowOrderInput);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("��ӳɹ�");
                    Close();
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
        /// ������õ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveform_Press(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// ѡ�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBOMan_Press(object sender, EventArgs e)
        {
            try
            {
                PopBOMan.Groups.Clear();
                PopListGroup manGroup = new PopListGroup();
                PopBOMan.Title = "������ѡ��";
                List<cmdb_useman> users = _autofacConfig.assUserService.GetAll();
                foreach (cmdb_useman Row in users)
                {
                    manGroup.AddListItem(Row.name, Row.id.ToString());
                }
                PopBOMan.Groups.Add(manGroup);
                if (btnBOMan.Tag != null)   //�������ѡ�������ʾѡ��Ч��
                {
                    foreach (PopListItem Item in manGroup.Items)
                    {
                        if (Item.Value == btnBOMan.Tag.ToString())
                            PopBOMan.SetSelections(Item);
                    }
                }
                PopBOMan.ShowDialog();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// ѡ����Ŀ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPro_Press(object sender, EventArgs e)
        {
            try
            {
                PopPro.Groups.Clear();
                PopListGroup manGroup = new PopListGroup();
                PopPro.Title = "��Ŀѡ��";
                //List<cmdb_useman> users = _autofacConfig.assUserService.GetAll();
                List<cmdb_project> pros = _autofacConfig.assProService.GetAll();
                foreach (cmdb_project Row in pros)
                {
                    manGroup.AddListItem(Row.name, Row.id.ToString());
                }
                PopPro.Groups.Add(manGroup);
                if (btnPro.Tag != null)   //�������ѡ�������ʾѡ��Ч��
                {
                    foreach (PopListItem Item in manGroup.Items)
                    {
                        if (Item.Value == btnPro.Tag.ToString())
                            PopPro.SetSelections(Item);
                    }
                }
                PopPro.ShowDialog();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// ѡ���Ŷ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTeam_Press(object sender, EventArgs e)
        {
            try
            {
                PopTeam.Groups.Clear();
                PopListGroup manGroup = new PopListGroup();
                PopTeam.Title = "�Ŷ�ѡ��";
                List<cmdb_team> teams = _autofacConfig.assTeamService.GetAll();
                foreach (cmdb_team Row in teams)
                {
                    manGroup.AddListItem(Row.name, Row.id.ToString());
                }
                PopTeam.Groups.Add(manGroup);
                if (btnTeam.Tag != null)   //�������ѡ�������ʾѡ��Ч��
                {
                    foreach (PopListItem Item in manGroup.Items)
                    {
                        if (Item.Value == btnTeam.Tag.ToString())
                            PopTeam.SetSelections(Item);
                    }
                }
                PopTeam.ShowDialog();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// ѡ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocation_Press(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// �ֻ�ɨ����Ӷ�ά��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgBtnForBarcode_Press(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btnLocation.Text))
                {
                    throw new Exception("����ѡ������");
                }
                else
                {
                    barcodeScanner1.GetBarcode();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        /// <summary>
        /// ѡ�������֮��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopBOMan_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopBOMan.Selection != null)
                {
                    btnBOMan.Text = PopBOMan.Selection.Text;
                    BoManId = int.Parse(PopBOMan.Selection.Value);//fixme
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ѡ����Ŀ֮��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopPro_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopPro.Selection != null)
                {
                    btnPro.Text = PopPro.Selection.Text;
                    Project_id = int.Parse(PopPro.Selection.Value);//fixme
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ѡ���Ŷ�֮��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopTeam_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopTeam.Selection != null)
                {
                    btnTeam.Text = PopTeam.Selection.Text;
                    Team_id = int.Parse(PopTeam.Selection.Value);//fixme
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        /// <summary>
        /// ѡ������֮��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopLocation_Selected(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// �ֻ�������ʱ���رյ�ǰ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBOCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// ��ʼ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBOCreate_Load(object sender, EventArgs e)
        {
            try
            {
                if (AssTable.Columns.Count == 0)
                {
                    AssTable.Columns.Add("ASSID");
                    AssTable.Columns.Add("TYPE");
                    AssTable.Columns.Add("BRAND");
                    AssTable.Columns.Add("SN");
                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = AssTable.Columns["ASSID"];
                AssTable.PrimaryKey = keys;

                //UserId = Session["UserID"].ToString();//fixme������䱨�������ؼ��ֲ����ֵ���
                switch (Client.Session["permission"].ToString())
                {
                    case "admin":
                        {
                            //var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                            //Position = user.USER_LOCATIONID;
                            //var location = _autofacConfig.assLocationService.GetByID(LocationId);
                            //btnLocation.Text = "";
                            //btnLocation.Enabled = false;
                            //btnLocation1.Enabled = false;
                        }
                        break;
                    case "guset":
                        {
                            BoManId = int.Parse(UserId);
                            //var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                            //btnBOMan.Text = user.USER_NAME;
                            btnBOMan.Enabled = false;
                            btnBOMan1.Enabled = false;
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ������
        /// </summary>
        public void BindListView()
        {
            try
            {
                ListAss.DataSource = AssTable;
                ListAss.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// ������������
        /// </summary>
        private void ClearInfo()
        {
            AssTable.Rows.Clear();
            AssIdList.Clear();
            BindListView();
        }

        /// <summary>
        /// ����ʲ������
        /// </summary>
        /// <param name="assId">�ʲ����</param>
        /// <param name="sn">���к�</param>
        /// <param name="image">ͼƬ</param>
        /// <param name="name">����</param>
        public void AddAss(int assId, string sn, string type, string brand)
        {
            try
            {
                if (AssIdList.Contains(assId))
                {

                }
                else
                {
                    DataRow row = AssTable.NewRow();
                    row["ASSID"] = assId;
                    row["SN"] = sn;
                    row["TYPE"] = type;
                    row["BRAND"] = brand;
                    AssTable.Rows.Add(row);
                    AssIdList.Add(assId);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// �����������ɾ���ʲ�
        /// </summary>
        /// <param name="assId">�ʲ����</param>
        public void RemoveAss(int assId)
        {
            try
            {
                DataRow row = AssTable.Rows.Find(assId);
                AssTable.Rows.Remove(row);
                AssIdList.Remove(assId);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �ְֳ���ɨ�赽��ά��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btnLocation.Text))
                {
                    throw new Exception("����ѡ������");
                }
                else
                {
                    string barCode = e.Data;
                    DataTable info = _autofacConfig.SettingService.GetUnUsedAssEx(barCode);
                    if (info.Rows.Count == 0)
                    {
                        throw new Exception("δ��������Ʒ���ҵ�����Ʒ");
                    }
                    else
                    {
                        DataRow row = info.Rows[0];
                        var type = _autofacConfig.assTypeService.GetByID(int.Parse(row["asset_type_id"].ToString()));
                        var brand = _autofacConfig.assBrandService.GetByID(int.Parse(row["brand_id"].ToString()));
                        AddAss(int.Parse(row["id"].ToString()), barCode, type.name, brand.name);
                        BindListView(); //���°�����
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �ְֳ���ɨ�赽RFIDʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.R2000RFIDScanEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btnLocation.Text))
                {
                    throw new Exception();
                }
                else
                {
                    string RFID = e.Epc;
                    DataTable info = _autofacConfig.SettingService.GetUnUsedAssEx(RFID);
                    if (info.Rows.Count == 0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        DataRow row = info.Rows[0];
                        var type = _autofacConfig.assTypeService.GetByID(int.Parse(row["asset_type_id"].ToString()));
                        var brand = _autofacConfig.assBrandService.GetByID(int.Parse(row["brand_id"].ToString()));
                        AddAss(int.Parse(row["id"].ToString()), RFID, type.name, brand.name);
                        BindListView(); //���°�����
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != "��������Ϊ��System.Exception�����쳣��")
                {
                    Toast(ex.Message);
                }
            }
        }

        /// <summary>
        /// �ֻ�ɨ�赽��ά��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcodeScanner1_BarcodeScanned_1(object sender, BarcodeResultArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btnLocation.Text))
                {
                    throw new Exception("����ѡ������");
                }
                else
                {
                    string barCode = e.Value;
                    DataTable info = _autofacConfig.SettingService.GetUnUsedAssEx(barCode);
                    if (info.Rows.Count == 0)
                    {
                        throw new Exception("δ��������Ʒ���ҵ�����Ʒ");
                    }
                    else
                    {
                        DataRow row = info.Rows[0];
                        var type = _autofacConfig.assTypeService.GetByID(int.Parse(row["asset_type_id"].ToString()));
                        var brand = _autofacConfig.assBrandService.GetByID(int.Parse(row["brand_id"].ToString()));
                        AddAss(int.Parse(row["id"].ToString()), barCode, type.name, brand.name);
                        BindListView(); //���°�����
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ���ɨ�����ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelScan_Press(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btnLocation.Text))
                {
                    throw new Exception("����ѡ������");
                }
                else
                {
                    barcodeScanner1.GetBarcode();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
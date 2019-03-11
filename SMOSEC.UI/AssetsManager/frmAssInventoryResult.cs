using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.CommLib;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.UI.Layout;
using ListView = Smobiler.Core.Controls.ListView;

namespace SMOSEC.UI.AssetsManager
{
    /// <summary>
    /// �̵㵥����
    /// </summary>
    partial class frmAssInventoryResult : Smobiler.Core.Controls.MobileForm
    {
        #region  �������
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������
        public string IID; //�̵㵥���
        private string UserId;  //�û����
        private DataTable waiTable = new DataTable(); //���̵���ʲ�
        private DataTable alreadyTable = new DataTable(); //���̵���ʲ�
        private Dictionary<string, int> assDictionary = new Dictionary<string, int>();  //�ʲ�
        private List<string> assList;  //�ʲ��ĳ�ʼ�б�
        //private List<string> RFIDlist;    //RFID��ɨ�����ݼ���

        private ListView waitListView = new ListView();
        private ListView alreadyListView = new ListView();

        public string LocationId;
        public string typeId;
        public string DepartmentId;
        public InventoryStatus Status;
        private DataTable allAssTable = new DataTable(); //ȫ���ʲ�
        #endregion

        /// <summary>
        /// ��ʼ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventoryResult_Load(object sender, EventArgs e)
        {
            try
            {
                //��Ӹ�������
                if (waiTable.Columns.Count == 0)
                {

                    waiTable.Columns.Add("RESULTNAME");
                    waiTable.Columns.Add("ASSID");
                    waiTable.Columns.Add("Image");
                    waiTable.Columns.Add("LocationName");
                    waiTable.Columns.Add("Name");
                    waiTable.Columns.Add("Price");
                    waiTable.Columns.Add("SN");
                    waiTable.Columns.Add("TypeName");
                    waiTable.Columns.Add("Specification");


                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = waiTable.Columns["ASSID"];
                waiTable.PrimaryKey = keys;

                //��Ӹ�������
                if (alreadyTable.Columns.Count == 0)
                {

                    alreadyTable.Columns.Add("RESULTNAME");
                    alreadyTable.Columns.Add("ASSID");
                    alreadyTable.Columns.Add("Image");
                    alreadyTable.Columns.Add("LocationName");
                    alreadyTable.Columns.Add("Name");
                    alreadyTable.Columns.Add("Price");
                    alreadyTable.Columns.Add("SN");
                    alreadyTable.Columns.Add("TypeName");
                    alreadyTable.Columns.Add("Specification");
                }
                DataColumn[] keys2 = new DataColumn[1];
                keys2[0] = alreadyTable.Columns["ASSID"];
                alreadyTable.PrimaryKey = keys2;

                UserId = Client.Session["UserID"].ToString();

                //��Ӹ�������
                if (allAssTable.Columns.Count == 0)
                {

                    //                    allAssTable.Columns.Add("RESULTNAME");
                    allAssTable.Columns.Add("ASSID");
                    allAssTable.Columns.Add("Image");
                    allAssTable.Columns.Add("LocationName");
                    allAssTable.Columns.Add("Name");
                    allAssTable.Columns.Add("Price");
                    allAssTable.Columns.Add("SN");
                    allAssTable.Columns.Add("TypeName");
                    allAssTable.Columns.Add("Specification");


                }
                DataColumn[] keys3 = new DataColumn[1];
                keys[0] = allAssTable.Columns["SN"];
                allAssTable.PrimaryKey = keys;

                var allAssTable1 = _autofacConfig.SettingService.GetAllAss("");
                foreach (DataRow row in allAssTable1.Rows)
                {
                    DataRow Row = allAssTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["LocationName"] = row["LocationName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();


                    allAssTable.Rows.Add(Row);
                }


                //���ListView��tabpageview
                waitListView.TemplateControlName = "frmAIResultLayout";
                waitListView.ShowSplitLine = true;
                waitListView.SplitLineColor = Color.FromArgb(230, 230, 230);
                waitListView.Dock = DockStyle.Fill;
                tabPageView1.Controls.Add(waitListView);

                alreadyListView.TemplateControlName = "frmAIResultLayout";
                alreadyListView.ShowSplitLine = true;
                alreadyListView.SplitLineColor = Color.FromArgb(230, 230, 230);
                alreadyListView.Dock = DockStyle.Fill;
                tabPageView1.Controls.Add(alreadyListView);

                var inventory = _autofacConfig.AssInventoryService.GetAssInventoryById(IID);
                txtName.Text = inventory.NAME;
                txtHandleMan.Text = inventory.HANDLEMANNAME;
                txtCount.Text = inventory.TOTAL.ToString();
                txtLocatin.Text = inventory.LOCATIONNAME;
                txtDep.Text = string.IsNullOrEmpty(inventory.DEPARTMENTID) ? "ȫ��" : inventory.DEPARTMENTNAME;
                txtType.Text = string.IsNullOrEmpty(inventory.TYPEID) ? "ȫ��" : inventory.TYPENAME;
                Status = (InventoryStatus)inventory
                    .STATUS;

                //�����Ҫ�̵���ʲ��б�
                assList = _autofacConfig.AssInventoryService.GetPendingInventoryList(IID);

                //�õ��̵㵥��ǰ����������
                assDictionary = _autofacConfig.AssInventoryService.GetResultDictionary(IID);

                //�õ����̵���ʲ��б�
                var waiTable1 = _autofacConfig.AssInventoryService.GetPendingInventoryTable(IID, LocationId, typeId,
                    DepartmentId);
                foreach (DataRow row in waiTable1.Rows)
                {
                    DataRow Row = waiTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["LocationName"] = row["LocationName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();


                    waiTable.Rows.Add(Row);
                }
                if (inventory.TOTAL == 0)
                {
                    txtCount.Text = waiTable1.Rows.Count.ToString();
                }


                //�õ����̵���ʲ��б�
                var alreadyTable1 = _autofacConfig.AssInventoryService.GetAssInventoryResultsByIID(IID, ResultStatus.����);
                foreach (DataRow row in alreadyTable1.Rows)
                {
                    DataRow Row = alreadyTable.NewRow();
                    Row["ASSID"] = row["ASSID"].ToString();
                    Row["RESULTNAME"] = row["RESULTNAME"].ToString();
                    Row["Image"] = row["Image"].ToString();
                    Row["LocationName"] = row["LocationName"].ToString();
                    Row["Name"] = row["Name"].ToString();
                    Row["Price"] = row["Price"].ToString();
                    Row["SN"] = row["SN"].ToString();
                    Row["TypeName"] = row["TypeName"].ToString();
                    Row["Specification"] = row["Specification"].ToString();

                    alreadyTable.Rows.Add(Row);
                }

                if (Status == InventoryStatus.�̵���� || Status == InventoryStatus.�̵�δ��ʼ)
                {
                    Form.ActionButton.Enabled = false;
                    plButton.Visible = false;
                }

                //������
                Bind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �����˼�,�͹رմ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventoryResult_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();

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
                string assId = "";
                //����sn�õ�Assid
                var asset = _autofacConfig.SettingService.GetAssetsBySN(barCode, "");
                if (asset != null && asset.Rows.Count == 1)
                {
                    assId = asset.Rows[0]["ASSID"].ToString();
                    AddAssToDictionary(assId, barCode);

                }
                else
                {
                    Toast("δ�ҵ���SN��Ӧ���ʲ����.");
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �ֳ��豸ɨ�赽��ά��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            try
            {
                string barCode = e.Data;
                string assId = "";
                //����sn�õ�Assid
                var asset = _autofacConfig.SettingService.GetAssetsBySN(barCode, "");
                if (asset != null && asset.Rows.Count == 1)
                {
                    assId = asset.Rows[0]["ASSID"].ToString();
                    AddAssToDictionary(assId, barCode);

                }
                else
                {
                    Toast("δ�ҵ���SN��Ӧ���ʲ����.");
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ��ɨ�赽���ʲ���ӵ���Ӧ��Dictionary
        /// </summary>
        /// <param name="assid">�ʲ����</param>
        private void AddAssToDictionary(string assid, string SN)
        {
            lock (lockobj)
            {
                if (assList.Contains(assid))
                {
                    //���״̬�Ǵ��̵㣬�������̵�
                    DataRow row = waiTable.Rows.Find(assid);
                    if (row != null)
                    {
                        DataRow newRow = getNewRow(row, ResultStatus.����);
                        assDictionary[assid] = (int)ResultStatus.����;
                        alreadyTable.Rows.Add(newRow);

                        var newdt = alreadyTable.Clone();
                        newdt.ImportRow(newRow);

                        alreadyListView.NewRow(newdt, "");
                        waitListView.Rows.RemoveAt(waiTable.Rows.IndexOf(row));
                        waiTable.Rows.Remove(row);
                    }
                }
                else
                {
                    //��������ǲ���Ҫ�̵�ģ�״̬��Ϊ��ӯ
                    if (!assDictionary.ContainsKey(assid))
                    {
                        assDictionary.Add(assid, (int)ResultStatus.��ӯ);
                    }
                    DataRow row = alreadyTable.Rows.Find(assid);
                    if (row == null)
                    {
                        DataRow asset = allAssTable.Rows.Find(SN);
                        if (asset != null)
                        {
                            DataRow newRow = getNewRow(asset,ResultStatus.��ӯ);
                            alreadyTable.Rows.Add(newRow);

                            var newdt = alreadyTable.Clone();
                            newdt.ImportRow(newRow);
                            ((frmAIResultLayout)alreadyListView.NewRow(newdt, "")[0].Control).label2.ForeColor = Color.FromArgb(43, 140, 255);
                        }
                    }
                }
                string[] titleStrings = new string[2];
                titleStrings[0] = "���̵�(" + waiTable.Rows.Count.ToString() + ")";
                titleStrings[1] = "���̵�(" + alreadyTable.Rows.Count.ToString() + ")";
                tabPageView1.Titles = titleStrings;
            }
        }
        private DataRow getNewRow(DataRow datarow, ResultStatus status)
        {
            DataRow newRow = alreadyTable.NewRow();
            newRow["ASSID"] = datarow["ASSID"].ToString();
            newRow["Image"] = datarow["Image"].ToString();
            newRow["LocationName"] = datarow["LocationName"].ToString();
            newRow["Name"] = datarow["Name"].ToString();
            newRow["Price"] = datarow["Price"].ToString();
            newRow["SN"] = datarow["SN"].ToString();
            newRow["TypeName"] = datarow["TypeName"].ToString();
            newRow["Specification"] = datarow["Specification"].ToString();
            if (status == ResultStatus.��ӯ)
                newRow["RESULTNAME"] = "��ӯ";
            else
                newRow["RESULTNAME"] = "";
            return newRow;
        }
        /// <summary>
        /// ���ActionButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventoryResult_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            try
            {
                ReturnInfo rInfo = new ReturnInfo();
                switch (e.Index)
                {
                    case 0:
                        //�ϴ����
                        AssInventoryInputDto inputDto = new AssInventoryInputDto
                        {
                            IID = IID,
                            IsEnd = false,
                            AssDictionary = assDictionary
                        };
                        inputDto.IsEnd = false;
                        rInfo = _autofacConfig.AssInventoryService.UpdateInventory(inputDto);
                        Toast(rInfo.IsSuccess ? "�ϴ�����ɹ�." : rInfo.ErrorInfo);
                        break;
                    case 1:
                        //�̵����
                        Dictionary<string, int> assDictionary2 = new Dictionary<string, int>();
                        foreach (var key in assDictionary.Keys)
                        {

                            if (assDictionary[key] == (int)ResultStatus.���̵�)
                            {
                                assDictionary2.Add(key, (int)ResultStatus.�̿�);
                            }
                            else
                            {
                                assDictionary2.Add(key, assDictionary[key]);
                            }
                        }


                        AssInventoryInputDto inputDto2 = new AssInventoryInputDto
                        {
                            IID = IID,
                            IsEnd = false,
                            AssDictionary = assDictionary2
                        };
                        inputDto2.IsEnd = true;
                        rInfo = _autofacConfig.AssInventoryService.UpdateInventory(inputDto2);
                        if (rInfo.IsSuccess)
                        {
                            ShowResult = ShowResult.Yes;
                            Close();
                            Toast("�̵�����ɹ�.");
                        }
                        else
                        {
                            Toast(rInfo.ErrorInfo);
                        }
                        break;
                    default:
                        break;

                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }


        }
        private static object lockobj = new object();
        /// <summary>
        /// ������
        /// </summary>
        private void Bind()
        {
            lock (lockobj)
            {
                try
                {
                    waitListView.Rows.Clear();
                    waitListView.DataSource = waiTable;
                    waitListView.DataBind();

                    alreadyListView.Rows.Clear();
                    alreadyListView.DataSource = alreadyTable;
                    alreadyListView.DataBind();
                    string[] titleStrings = new string[2];
                    titleStrings[0] = "���̵�(" + waiTable.Rows.Count.ToString() + ")";
                    titleStrings[1] = "���̵�(" + alreadyTable.Rows.Count.ToString() + ")";
                    tabPageView1.Titles = titleStrings;

                    foreach (var row in alreadyListView.Rows)
                    {
                        frmAIResultLayout layout = (frmAIResultLayout)row.Control;
                        if (layout.label2.Text == "�̿�")
                            layout.label2.ForeColor = Color.Red;
                        if (layout.label2.Text == "��ӯ")
                            layout.label2.ForeColor = Color.FromArgb(43, 140, 255);
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message);
                }
            }

        }

        /// <summary>
        /// ���"ɨ�����"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelScan_Press(object sender, EventArgs e)
        {
            if (Status == InventoryStatus.�̵���� || Status == InventoryStatus.�̵�δ��ʼ)
            {
                Toast("�̵�δ��ʼ���Ѿ�����.");
            }
            else
            {
                barcodeScanner1.GetBarcode();
            }
        }
        /// <summary>
        /// ɨ�赽RFIDʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.R2000RFIDScanEventArgs e)
        {
            string RFID = e.Epc;
            string assId = "";

            DataRow row = allAssTable.Rows.Find(RFID);
            if (row != null)
            {
                assId = row["ASSID"].ToString();
                if ((assList.Contains(assId) && waiTable.Rows.Find(assId) != null) ||
                    (!assDictionary.ContainsKey(assId) && alreadyTable.Rows.Find(assId) == null))
                {
                    AddAssToDictionary(assId, RFID);
                }
            }
        }
    }
}
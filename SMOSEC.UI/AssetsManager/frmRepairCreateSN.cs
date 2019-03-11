using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.Domain.Entity;
using System.Data;
using SMOSEC.UI.Layout;
using SMOSEC.CommLib;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.OutputDTO;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmRepairCreateSN : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        //public List<AssetsOrderRow> SNRowData;   //����SN����
        public ROInputDto RepairData = new ROInputDto();         //ά�޵���Ϣ
        public DataTable AssTable = new DataTable();   //�������ݵı��
        public List<string> SNRowData = new List<string>(); //���������ASSID�ļ���
        private String SN;       //���к�
        #endregion
        /// <summary>
        /// �������޵�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(btnDealMan.Text))
                    throw new Exception("�����˲���Ϊ��");

                if (String.IsNullOrEmpty(txtrepairman.Text))
                    throw new Exception("ά���˲���Ϊ��");

                if (String.IsNullOrEmpty(txtContent.Text))
                    throw new Exception("ά�����ݲ���Ϊ��!");

                if (String.IsNullOrEmpty(txtNote.Text))
                    throw new Exception("�����߲���Ϊ��");

                if (String.IsNullOrEmpty(txtsns.Text))
                    throw new Exception("ά���ʲ�SN�Ų���Ϊ��");

                if (String.IsNullOrEmpty(SN))
                {
                    List<string> sn_list = autofacConfig.SettingService.GetAllSns();
                    if (!sn_list.Contains(txtsns.Text))
                        throw new Exception("���������к�Ϊ" + txtsns.Text + "�������ʲ�");
                }


                AssetsOutputDto outputDto = autofacConfig.SettingService.GetAssetsBysn(txtsns.Text);

                repairInPutDto repairs = new repairInPutDto
                {
                    //id = 0,
                    find_man = txtNote.Text,
                    call_man = btnDealMan.Text,
                    call_date = DatePicker.Value,
                    repair_man = txtrepairman.Text,
                    repair_content = txtContent.Text,
                    repair_status = "�ȴ�ά��",
                    asset_id = outputDto.id
                };

                //List<AssRepairOrderRow> Data = new List<AssRepairOrderRow>();
                //if (ListAssetsSN.Rows.Count == 0) throw new Exception("ά�������Ϊ��!");
                //foreach (ListViewRow Row in ListAssetsSN.Rows)
                //{
                //    frmOrderCreateSNLayout Layout = Row.Control as frmOrderCreateSNLayout;
                //    AssetsOrderRow RowData = Layout.getData();
                //    AssRepairOrderRow assRow = new AssRepairOrderRow();

                //    assRow.IMAGE = RowData.IMAGE;
                //    assRow.ASSID = RowData.ASSID;
                //    assRow.WAITREPAIRQTY = RowData.QTY;
                //    assRow.SN = RowData.SN;
                //    assRow.LOCATIONID = RowData.LOCATIONID;
                //    assRow.STATUS = RowData.STATUS;
                //    assRow.CREATEDATE = DateTime.Now;
                //    Data.Add(assRow);
                //}
                //RepairData.Rows = Data;
                ReturnInfo r = autofacConfig.assRepairOrderService.AddAssRepairOrder(repairs);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Form.Close();          //�����ɹ�
                    Toast("����ά�޵��ɹ�!");
                }
                else
                {
                    throw new Exception(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// ������ѡ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDealMan_Press(object sender, EventArgs e)
        {
            try
            {
                //popDealMan.Groups.Clear();       //�������
                //PopListGroup poli = new PopListGroup();
                //popDealMan.Groups.Add(poli);
                //poli.Title = "������ѡ��";
                ////List<coreUser> users = autofacConfig.coreUserService.GetAdmin();
                ////foreach (coreUser Row in users)
                ////{
                ////    poli.AddListItem(Row.USER_NAME, Row.USER_ID);
                ////}
                //if (btnDealMan.Tag != null)   //�������ѡ�������ʾѡ��Ч��
                //{
                //    foreach (PopListItem Item in poli.Items)
                //    {
                //        if (Item.Value == btnDealMan.Tag.ToString())
                //            popDealMan.SetSelections(Item);
                //    }
                //}
                //popDealMan.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// �������
        /// </summary>
        public void Bind()
        {
            try
            {
                //DataTable tableAssets = new DataTable();       //δ����SN���ʲ��б�
                //if (SNRowData.Count > 0)
                //{
                //    //DataRow row = AssTable.NewRow();
                //    //row["ASSID"] = assId;
                //    //row["SN"] = sn;
                //    //row["TYPE"] = type;
                //    //row["BRAND"] = brand;
                //    //AssTable.Rows.Add(row);
                //    //AssIdList.Add(sn);

                //    foreach (var data_sn  in SNRowData)
                //    {
                //        AssetsOutputDto outputDto = autofacConfig.SettingService.GetAssetsBysn(data_sn);
                //        AssTable.Rows.Add(outputDto.AssId, outputDto.id, data_sn);
                //    }
                //}
                ListAssetsSN.DataSource = AssTable;
                ListAssetsSN.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// ɾ����ǰ��ѡ����
        /// </summary>
        /// <param name="ASSID"></param>
        /// <param name="SN"></param>
        public void ReMoveAssSN(String ASSID, String SN)
        {
            //try
            //{
            //    foreach (AssetsOrderRow Row in SNRowData)
            //    {
            //        if (Row.ASSID == ASSID && Row.SN == SN)
            //        {
            //            SNRowData.Remove(Row);
            //            break;
            //        }
            //    }
            //    Bind();       //ˢ�µ�ǰҳ��
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }
        /// <summary>
        /// ɨ������ʲ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void betGet_Press(object sender, EventArgs e)
        {
            BarcodeScanner1.GetBarcode();
        }
        /// <summary>
        /// ������ѡ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popDealMan_Selected(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(popDealMan.Selection.Text) == false)
            {
                btnDealMan.Text = popDealMan.Selection.Text + "   > ";
                btnDealMan.Tag = popDealMan.Selection.Value;         //�����˱��
            }
        }
        /// <summary>
        /// ɨ�赽����ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarcodeScanner1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.error))
                {
                    SN = e.Value;
                    txtsns.Text = e.Value;
                }
                else
                    throw new Exception(e.error);
                List<string> sn_list = autofacConfig.SettingService.GetAllSns();
                if (!sn_list.Contains(SN))
                    throw new Exception("���������к�Ϊ" + SN + "�������ʲ�");

                AssetsOutputDto outputDto = autofacConfig.SettingService.GetAssetsBysn(SN);

                DataRow row = AssTable.NewRow();
                row["ASSID"] = outputDto.AssId;
                row["SN"] = SN;
                row["ID"] = outputDto.id;

                //Data.Assid = assets.ASSID;
                //Data.LOCATIONID = assets.LOCATIONID;
                //Data.IMAGE = assets.IMAGE;
                //Data.QTY = 0;
                //Data.SN = SN;
                foreach (var sn in SNRowData)
                {
                    if (sn == SN)
                        throw new Exception("���ʲ�����ӣ������ظ����!");
                }
                AssTable.Rows.Add(row);
                SNRowData.Add(SN);

                //if (SNRowData != null)
                //{
                //    foreach (var sn in SNRowData)
                //    {
                //        if (sn == SN)
                //            throw new Exception("���ʲ�����ӣ������ظ����!");
                //    }
                //    AssTable.Rows.Add(row);
                //    SNRowData.Add(SN);
                //}
                //else
                //{
                //    List<AssetsOrderRow> Datas = new List<AssetsOrderRow>();
                //    AssTable.Add(Data);
                //    SNRowData = Datas;
                //}
                Bind();        //���°�����
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// �ְֳ���ɨ�赽����ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            //try
            //{
            //    AssetsOrderRow Data = new AssetsOrderRow();
            //    SN = e.Data;
            //    Assets assets = autofacConfig.orderCommonService.GetUnusedAssetsBySN(SN);
            //    if (assets == null) throw new Exception("���������к�Ϊ" + SN + "�������ʲ�");
            //    Data.ASSID = assets.ASSID;
            //    Data.LOCATIONID = assets.LOCATIONID;
            //    Data.IMAGE = assets.IMAGE;
            //    Data.QTY = 0;
            //    Data.SN = SN;
            //    if (SNRowData != null)
            //    {
            //        foreach (AssetsOrderRow Row in SNRowData)
            //        {
            //            if (Data.ASSID == Row.ASSID)
            //                throw new Exception("���ʲ�����ӣ������ظ����!");
            //        }
            //        SNRowData.Add(Data);
            //    }
            //    else
            //    {
            //        List<AssetsOrderRow> Datas = new List<AssetsOrderRow>();
            //        Datas.Add(Data);
            //        SNRowData = Datas;
            //    }
            //    Bind();        //���°�����
            //}
            //catch(Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }
        /// <summary>
        /// �ְֳ���ɨ�赽RFIDʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.R2000RFIDScanEventArgs e)
        {
            //try
            //{
            //    AssetsOrderRow Data = new AssetsOrderRow();
            //    SN = e.Epc;
            //    Assets assets = autofacConfig.orderCommonService.GetUnusedAssetsBySN(SN);
            //    if (assets == null) throw new Exception();
            //    Data.ASSID = assets.ASSID;
            //    Data.LOCATIONID = assets.LOCATIONID;
            //    Data.IMAGE = assets.IMAGE;
            //    Data.QTY = 0;
            //    Data.SN = SN;
            //    if (SNRowData != null)
            //    {
            //        foreach (AssetsOrderRow Row in SNRowData)
            //        {
            //            if (Data.ASSID == Row.ASSID)
            //                throw new Exception();
            //        }
            //        SNRowData.Add(Data);
            //    }
            //    else
            //    {
            //        List<AssetsOrderRow> Datas = new List<AssetsOrderRow>();
            //        Datas.Add(Data);
            //        SNRowData = Datas;
            //    }
            //    Bind();        //���°�����
            //}
            //catch (Exception ex)
            //{
            //    if(ex.Message!= "��������Ϊ��System.Exception�����쳣��")
            //    {
            //        Toast(ex.Message);
            //    }                
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
                BarcodeScanner1.GetBarcode();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
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
                    AssTable.Columns.Add("ID");
                    AssTable.Columns.Add("SN");
                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = AssTable.Columns["ASSID"];
                AssTable.PrimaryKey = keys;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


    }
}
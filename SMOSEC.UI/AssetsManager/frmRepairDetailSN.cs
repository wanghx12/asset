using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.Domain.Entity;
using System.Data;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;
using SMOSEC.CommLib;



namespace SMOSEC.UI.AssetsManager
{
    partial class frmRepairDetailSN : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        public DataTable AssTable = new DataTable();   //�������ݵı��
        public int ROID;     //���޵����
        #endregion
        /// <summary>
        /// ά�޵�ȷ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                ReturnInfo r = autofacConfig.assRepairOrderService.UpdateAssRepairOrder(ROID, "�޺�");
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    ClearInfo();
                    ((frmRepairDetailSN)Form).Bind();
                    Toast("�޸�״̬�ɹ�");
                }
                else
                {
                    Toast(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ά��ʧ��ȷ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave1_Press(object sender, EventArgs e)
        {
            try
            {
                ReturnInfo r = autofacConfig.assRepairOrderService.UpdateAssRepairOrder(ROID, "δ�޺�");
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    ClearInfo();
                    ((frmRepairDetailSN)Form).Bind();
                    Toast("�޸�״̬�ɹ�");
                }
                else
                {
                    Toast(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        //frmRepairDealSN frm = new frmRepairDealSN();
        //frm.ROID = ROID;
        //Show(frm, (MobileForm sender1, object args) =>
        //{
        //    if (frm.ShowResult == ShowResult.Yes)
        //        Bind();   //ˢ��������ʾ
        //});

        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRepairDetailSN_Load(object sender, EventArgs e)
        {
            if (AssTable.Columns.Count == 0)
            {
                AssTable.Columns.Add("ASSID");             //�ʲ����
                AssTable.Columns.Add("SN");                //���к�
                AssTable.Columns.Add("STATUS");            //����״̬
            }
            DataColumn[] keys = new DataColumn[1];
            keys[0] = AssTable.Columns["SN"];
            AssTable.PrimaryKey = keys;
            //DataTable tableAssets = new DataTable();      //δ����SN���ʲ��б�
            
            Bind();
        }
        /// <summary>
        /// ��������
        /// </summary>
        public void Bind()
        {
            try
            {
                ROInputDto ROData = autofacConfig.assRepairOrderService.GetByID(ROID);
                if (ROData != null)
                {
                    lblDealMan.Text = ROData.call_man;
                    DatePicker.Value = ROData.call_date;
                    lblPrice.Text = ROData.repair_man;
                    lblContent.Text = ROData.repair_content;
                    lblNote.Text = ROData.find_man;
                }
                //coreUser User = autofacConfig.coreUserService.GetUserByID(ROData.HANDLEMAN);
                //lblDealMan.Text = User.USER_NAME;

                AssetsOutputDto assets = autofacConfig.SettingService.GetAssetsByid(ROData.asset_id);

                DataRow row = AssTable.NewRow();
                row["ASSID"] = assets.AssId;
                row["SN"] = assets.SN;
                row["STATUS"] = ROData.repair_status;

                AssTable.Rows.Add(row);
                //AssIdList.Add(sn);

                //foreach (AssRepairOrderRow Row in ROData.Rows)
                //{
                //    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                //    if (Row.STATUS == 0)
                //    {
                //        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN, "�ȴ���");
                //    }
                //    else
                //    {
                //        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN, "ά�����");
                //    }
                //}

                if (AssTable.Rows.Count > 0)
                {
                    BindListView();
                }
                
                //if (Client.Session["Role"].ToString() == "SMOSECUser") plButton.Visible = false;
                //���ά�޵�����ɣ�������ά�޵�����ť
                if (ROData.repair_status != "�ȴ���")
                    plButton.Visible = false;


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
                ListAssetsSN.DataSource = AssTable;
                ListAssetsSN.DataBind();
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
            BindListView();
        }

    }
}
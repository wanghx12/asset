using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.Domain.Entity;
using System.Data;
using SMOSEC.UI.Layout;
using SMOSEC.CommLib;
using SMOSEC.DTOs.Enum;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmRepairDealSN : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        public String ROID;     //���޵����
        #endregion
        /// <summary>
        /// ȫѡ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkall_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewRow Row in ListAssetsSN.Rows)
            {
                frmAssSNRDLayout Layout = Row.Control as frmAssSNRDLayout;
                Layout.setCheck(Checkall.Checked);
            }
        }
        /// <summary>
        /// ����ȫѡ��״̬
        /// </summary>
        public void upCheckState()
        {
            if (getNum() == ListAssetsSN.Rows.Count)
                Checkall.Checked = true;          //ѡ����������ʱ
            else
                Checkall.Checked = false;        //û��ѡ����������
        }
        /// <summary>
        /// ���㵱ǰѡ������
        /// </summary>
        /// <returns></returns>
        public Int32 getNum()
        {
            Int32 selectQty = 0;        //��ǰѡ��������
                                        //if (tpvAssets.PageIndex == 0)
                                        //{
            foreach (ListViewRow Row in ListAssetsSN.Rows)
            {
                frmAssSNRDLayout Layout = Row.Control as frmAssSNRDLayout;
                selectQty += Layout.checkNum();
            }
            return selectQty;
        }
        /// <summary>
        /// ȷ��ά��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (getNum() == 0) throw new Exception("��ѡ��ȷ������!");

                ROInputDto BasicData = new ROInputDto();
                BasicData.MODIFYDATE = DateTime.Now;
                BasicData.MODIFYUSER = Client.Session["UserID"].ToString();
                BasicData.ROID = ROID;

                List<AssRepairOrderRow> Data = new List<AssRepairOrderRow>();
                foreach (ListViewRow Row in ListAssetsSN.Rows)
                {
                    frmAssSNRDLayout Layout = Row.Control as frmAssSNRDLayout;
                    Data.Add(Layout.getData());
                }
                BasicData.Rows = Data;
                ReturnInfo r = autofacConfig.assRepairOrderService.UpdateAssRepairOrder(BasicData);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Form.Close();
                    Toast("ȷ��ά�޳ɹ�!");
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
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRepairDealSN_Load(object sender, EventArgs e)
        {
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
                coreUser User = autofacConfig.coreUserService.GetUserByID(ROData.HANDLEMAN);
                lblDealMan.Text = User.USER_NAME;
                DatePicker.Value = ROData.APPLYDATE;
                if (ROData.COST != 0)
                    lblPrice.Text = ROData.COST.ToString();
                lblContent.Text = ROData.REPAIRCONTENT;
                if (String.IsNullOrEmpty(ROData.NOTE)) lblNote.Text = ROData.NOTE;

                DataTable tableAssets = new DataTable();       //δ����SN���ʲ��б�
                tableAssets.Columns.Add("ROROWID");           //���޵�������
                tableAssets.Columns.Add("ASSID");              //�ʲ����
                tableAssets.Columns.Add("NAME");               //�ʲ�����
                tableAssets.Columns.Add("IMAGE");              //ͼƬ���
                tableAssets.Columns.Add("SN");                 //���к�
                foreach (AssRepairOrderRow Row in ROData.Rows)
                {
                    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                    if (Row.STATUS == 0)
                    {
                        tableAssets.Rows.Add(Row.ROROWID, Row.ASSID, assets.NAME , Row.IMAGE, Row.SN);
                    }
                }
                if (tableAssets.Rows.Count > 0)
                {
                    ListAssetsSN.DataSource = tableAssets;
                    ListAssetsSN.DataBind();
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
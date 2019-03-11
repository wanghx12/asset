using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.UI.Layout;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using System.Data;
using SMOSEC.DTOs.Enum;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmScrapDealSN : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        public String SOID;     //���ϵ����
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
                frmAssSNSDLayout Layout = Row.Control as frmAssSNSDLayout;
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
                frmAssSNSDLayout Layout = Row.Control as frmAssSNSDLayout;
                selectQty += Layout.checkNum();
            }
            return selectQty;
        }
        /// <summary>
        /// ȷ�ϻ�ԭ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (getNum() == 0) throw new Exception("��ѡ��ȷ������!");

                SOInputDto BasicData = new SOInputDto();
                BasicData.MODIFYDATE = DateTime.Now;
                BasicData.MODIFYUSER = Client.Session["UserID"].ToString();
                BasicData.SOID = SOID;

                List<AssScrapOrderRow> Data = new List<AssScrapOrderRow>();
                foreach (ListViewRow Row in ListAssetsSN.Rows)
                {
                    frmAssSNSDLayout Layout = Row.Control as frmAssSNSDLayout;
                    Data.Add(Layout.getData());
                }
                BasicData.Rows = Data;
                ReturnInfo r = autofacConfig.assScrapOrderService.UpdateAssScrapOrder(BasicData);
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Form.Close();
                    Toast("�ʲ���ԭ�ɹ�!");
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
        private void frmScrapDealSN_Load(object sender, EventArgs e)
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
                SOInputDto SOData = autofacConfig.assScrapOrderService.GetByID(SOID);
                coreUser User = autofacConfig.coreUserService.GetUserByID(SOData.SCRAPMAN);
                lblDealMan.Text = User.USER_NAME;
                lblDealMan.Tag = SOData.SCRAPMAN;
                DatePicker.Value = SOData.SCRAPDATE;

                if (String.IsNullOrEmpty(SOData.NOTE)) lblNote.Text = SOData.NOTE;

                DataTable tableAssets = new DataTable();       //δ����SN���ʲ��б�
                tableAssets.Columns.Add("SOROWID");           //���޵�������
                tableAssets.Columns.Add("ASSID");              //�ʲ����
                tableAssets.Columns.Add("NAME");               //�ʲ�����
                tableAssets.Columns.Add("IMAGE");              //ͼƬ���
                tableAssets.Columns.Add("SN");                 //���к�
                foreach (AssScrapOrderRow Row in SOData.Rows)
                {
                    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                    if (Row.STATUS == 0)
                    {
                        tableAssets.Rows.Add(Row.SOROWID, Row.ASSID, assets.NAME, Row.IMAGE, Row.SN);
                    }
                }
                if (tableAssets.Rows.Count > 0)
                {
                    ListAssetsSN.DataSource = tableAssets;
                    ListAssetsSN.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
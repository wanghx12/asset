using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmScrapDetailSN : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        public String SOID;     //���ϵ����
        #endregion
        /// <summary>
        /// �ʲ���ԭ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Press(object sender, EventArgs e)
        {
            frmScrapDealSN frm = new frmScrapDealSN();
            frm.SOID = SOID;
            Show(frm, (MobileForm sender1, object args) =>
            {
                if (frm.ShowResult == ShowResult.Yes)
                    Bind();   //ˢ��������ʾ
            });
        }
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmScrapDetailSN_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// ���ݼ���
        /// </summary>
        public void Bind()
        {
            try
            {
                SOInputDto SOData = autofacConfig.assScrapOrderService.GetByID(SOID);
                coreUser User = autofacConfig.coreUserService.GetUserByID(SOData.SCRAPMAN);
                lblDealMan.Text = User.USER_NAME;
                DatePicker.Value = SOData.SCRAPDATE;
                if (String.IsNullOrEmpty(SOData.NOTE)) lblNote.Text = SOData.NOTE;

                DataTable tableAssets = new DataTable();      //δ����SN���ʲ��б�
                tableAssets.Columns.Add("ASSID");             //�ʲ����
                tableAssets.Columns.Add("NAME");              //�ʲ�����
                tableAssets.Columns.Add("IMAGE");             //�ʲ�ͼƬ
                tableAssets.Columns.Add("SN");                //���к�
                tableAssets.Columns.Add("STATUS");            //����״̬
                foreach (AssScrapOrderRow Row in SOData.Rows)
                {
                    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                    if (Row.STATUS == 0)
                    {
                        tableAssets.Rows.Add(Row.ASSID, assets.NAME , assets.IMAGE , Row.SN, "�ѱ���");
                    }
                    else
                    {
                        tableAssets.Rows.Add(Row.ASSID, assets.NAME , assets.IMAGE , Row.SN, "�ѻ�ԭ");
                    }
                }
                if (tableAssets.Rows.Count > 0)
                {
                    ListAssetsSN.DataSource = tableAssets;
                    ListAssetsSN.DataBind();
                }
                if (Client.Session["Role"].ToString() == "SMOSECUser") plButton.Visible = false;
                //���ά�޵�����ɣ�������ά�޵�����ť
                if (SOData.STATUS == 1) plButton.Visible = false;
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmTransferRowsSN : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        #endregion
        /// <summary>
        /// ����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Press(object sender, EventArgs e)
        {
            frmTransferCreateSN frm = new frmTransferCreateSN();
            Show(frm, (MobileForm sender1, object args) => {
                if (frm.ShowResult == ShowResult.Yes)
                {
                    Bind();   //���¼�������
                }
            });
        }
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTransferRowsSN_Load(object sender, EventArgs e)
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
                List<AssTransferOrder> Data = new List<AssTransferOrder>();
                if (Client.Session["Role"].ToString() == "SMOSECUser")
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(Client.Session["UserID"].ToString(),OperateType.�ʲ�);
                }
                else
                {
                    Data = autofacConfig.assTransferOrderService.GetByUser(null, OperateType.�ʲ�);
                }
                if (Data.Count > 0)
                {
                    listTransferOrder.DataSource = Data;
                    listTransferOrder.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// �ֻ��Դ����ؼ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTransferRowsSN_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back) Client.Exit();
        }
    }
}
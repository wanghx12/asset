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
    partial class frmRepairRowsSN : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        #endregion
        /// <summary>
        /// ����ά�޵�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Press(object sender, EventArgs e)
        {
            frmRepairCreateSN frm = new frmRepairCreateSN();
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
        private void frmRepairRowsSN_Load(object sender, EventArgs e)
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
                //List<cmdb_repairlog> Data = new List<cmdb_repairlog>();
                //if (Client.Session["Role"].ToString() == "SMOSECUser")
                //{
                //    Data = autofacConfig.assRepairOrderService.GetByUser(Client.Session["UserID"].ToString());
                //}
                //else
                //{
                //    Data = autofacConfig._assRepairOrderService.GetByUser(null);
                //}
                List<cmdb_repairlog> Data = autofacConfig.assRepairOrderService.GetAll();
                if (Data.Count > 0)
                {
                    listRepairOrder.DataSource = Data;
                    listRepairOrder.DataBind();
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
        private void frmRepairRowsSN_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back) Client.Exit();
        }
    }
}
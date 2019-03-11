using System;
using System.Data;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmCollarOrder : Smobiler.Core.Controls.MobileForm
    {
        #region ����
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������
       
        #endregion

        /// <summary>
        /// ��ת��������õ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Press(object sender, EventArgs e)
        {
            try
            {
                frmCoCreate frmCoCreate= new frmCoCreate();
                Show(frmCoCreate, (MobileForm sender1, object args) =>
                {
                    if (frmCoCreate.ShowResult == ShowResult.Yes)
                    {
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
        /// ������ʱ�رտͻ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCollarOrder_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }

        /// <summary>
        /// �����ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCollarOrder_Load(object sender, EventArgs e)
        {
            Bind();
        }

        /// <summary>
        /// ������
        /// </summary>
        private void Bind()
        {
            try
            {
                string LocationId = "";
                string UserId = Session["UserID"].ToString();
                if (Client.Session["Role"].ToString() == "SMOSECAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                }
                if (Client.Session["Role"].ToString() == "SMOSECUser")
                {
                    plButton.Visible = false;
                }
                DataTable assborrowTable = _autofacConfig.AssetsService.GetCoByUserId(Client.Session["Role"].ToString() == "SMOSECUser" ? Client.Session["UserID"].ToString() : "",LocationId);
                ListViewCO.Rows.Clear();
                if (assborrowTable.Rows.Count > 0)
                {
                    ListViewCO.DataSource = assborrowTable;
                    ListViewCO.DataBind();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
    }
}
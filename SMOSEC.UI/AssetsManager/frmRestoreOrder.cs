using System;
using System.Data;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmRestoreOrder : Smobiler.Core.Controls.MobileForm
    {
        #region ����
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������       
        #endregion

        /// <summary>
        /// ����˿ⵥ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Press(object sender, EventArgs e)
        {
            try
            {
                frmRsoCreate frmRsoCreate = new frmRsoCreate();
                Show(frmRsoCreate, (MobileForm sender1, object args) =>
                {
                    if (frmRsoCreate.ShowResult == ShowResult.Yes)
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
        /// �����˼�ʱ�رտͻ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRestoreOrder_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }

        /// <summary>
        /// ҳ���ʼ��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRestoreOrder_Load(object sender, EventArgs e)
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
                DataTable assborrowTable = _autofacConfig.AssetsService.GetRsoByUserId(Client.Session["Role"].ToString() == "SMOSECUser" ? Client.Session["UserID"].ToString() : "",LocationId);
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
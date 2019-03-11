using System;
using System.Data;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmBorrowOrder : Smobiler.Core.Controls.MobileForm
    {
        #region
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������
        #endregion

        /// <summary>
        /// ��ת����ӽ��õ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Press(object sender, EventArgs e)
        {
            try
            {
                frmBoCreate frmBoCreate=new frmBoCreate();
                Show(frmBoCreate, (MobileForm sender1, object args) =>
                {
                    if (frmBoCreate.ShowResult == ShowResult.Yes)
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
        /// �ֻ�������ʱ�رտͻ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBorrowOrder_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }

        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBorrowOrder_Load(object sender, EventArgs e)
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
                //string LocationId = "";
                //string UserId = Session["UserID"].ToString();
                //if (Client.Session["Role"].ToString() == "SMOSECAdmin")
                //{
                //    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                //    LocationId = user.USER_LOCATIONID;
                //}
                if (Client.Session["permission"].ToString() == "guset")
                {
                    plButton.Visible = false;
                }
                //DataTable assborrowTable = _autofacConfig.SettingService.GetBorrowedAss();
                DataTable assborrowTable = _autofacConfig.AssetsService.GetAllBo();     
                ListViewBorrow.Rows.Clear();
                if (assborrowTable.Rows.Count > 0)
                {
                    ListViewBorrow.DataSource = assborrowTable;
                    ListViewBorrow.DataBind();
                }
                
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
    }
}
using Smobiler.Core.Controls;
using System;
using SMOSEC.UI.MasterData;
using SMOSEC.UI.UserInfo;
using SMOSEC.CommLib;
using Smobiler.Core;

namespace SMOSEC.UI
{
    partial class frmLogon : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//����������
        private DateTime toasttime;
        #endregion
        /// <summary>
        /// ��¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogon_Click(object sender, EventArgs e)
        {
            try
            {
                String userID = txtUserName.Text.Trim();
                String PassWord = txtPassWord.Text.Trim();
                if (userID.Length <= 0)
                    throw new Exception("�������û���");
                if (PassWord.Length <= 0)
                    throw new Exception("����������");
                LoadClientData(MobileServer.ServerID + "user", userID);
                if (checkRemb.Checked == true)
                {
                    //��ס����
                    LoadClientData(MobileServer.ServerID + "pwd", PassWord);
                }
                else
                {
                    //ɾ���ͻ�������
                    RemoveClientData(MobileServer.ServerID + "pwd", (object s, ClientDataResultHandlerArgs args) => txtPassWord.Text = "");
                }

                ReturnInfo result = autofacConfig.coreUserService.Login(userID, PassWord);

                if (result.IsSuccess)
                {
                    //MessageBox.Show("��ȷ");
                    String Role = autofacConfig.coreUserService.GetUserByID(userID).permission;
                    Client.Session["local_username"] = userID;
                    Client.Session["permission"] = Role;
                    frmAssets frm = new frmAssets();
                    Show(frm);
                }
                else
                {
                    //MessageBox.Show("����ȷ");
                    throw new Exception(result.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// �˳��ͻ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogon_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                if (toasttime.AddSeconds(3) > DateTime.Now)
                {
                    Client.Exit(false);
                }
                else
                {
                    toasttime = DateTime.Now;
                    Toast("�ٰ�һ���˳�Ӧ��", ToastLength.SHORT);
                }
            }
        }
        /// <summary>
        /// ��ȡ�ͻ�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogon_Load(object sender, EventArgs e)
        {
            //��ȡ�û���
            ReadClientData(MobileServer.ServerID + "user", (object sender1, ClientDataResultHandlerArgs e1) =>
            {
                if (String.IsNullOrEmpty(e1.error))
                {
                    txtUserName.Text = e1.Value;
                }
            });
            //��ȡ����
            ReadClientData(MobileServer.ServerID + "pwd", (object sender1, ClientDataResultHandlerArgs e1) =>
            {
                if (String.IsNullOrEmpty(e1.error))
                {
                    txtPassWord.Text = e1.Value;
                    if (txtPassWord.Text.Length > 0)
                    {
                        checkRemb.Checked = true;
                    }
                }
            });
        }
        /// <summary>
        /// �˺�ע��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegist_Press(object sender, EventArgs e)
        {
            //frmRegisterTel frm = new frmRegisterTel();
            //this.Show(frm);
        }
        /// <summary>
        /// Demo�˺ŵ�¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemo_Press(object sender, EventArgs e)
        {
            //try
            //{
            //    ReturnInfo result = autofacConfig.coreUserService.Login("12345678917", "123456");

            //    if (result.IsSuccess)
            //    {
            //        String Role = autofacConfig.coreUserService.GetUserByID("12345678917").permission;
            //        Client.Session["UserID"] = "12345678917";
            //        Client.Session["Role"] = Role;
            //        frmAssets frm = new frmAssets();
            //        Show(frm);
            //    }
            //    else
            //    {
            //        throw new Exception(result.ErrorInfo);
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForget_Press(object sender, EventArgs e)
        {
            //frmRegisterTel frm = new frmRegisterTel();
            //frm.isForgetPwd = true;
            //frm.UserID = txtUserName.Text.Trim();
            //this.Show(frm);
        }
    }
}
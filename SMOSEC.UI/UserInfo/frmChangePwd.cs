using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.CommLib;

namespace SMOSEC.UI.UserInfo
{
    partial class frmChangePwd : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        //public String oldPwd;        //������
        #endregion
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChangePwd_Load(object sender, EventArgs e)
        {
            lblUserID.Text = Client.Session["UserID"].ToString();
        }
        /// <summary>
        /// �޸ı�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSure_Press(object sender, EventArgs e)
        {
            //try
            //{
            //    String newPwd1 = txtPassWord1.Text.Trim();
            //    String newPwd2 = txtPassWord2.Text.Trim();
            //    if (newPwd1.Length < 0) throw new Exception("������������!");
            //    if (newPwd1.Length < 6 || newPwd1.Length > 12) throw new Exception("���������Ϊ6-12λ!");
            //    if (newPwd2.Length < 0) throw new Exception("������ȷ������!");
            //    if (newPwd2.Length < 6 || newPwd2.Length > 12) throw new Exception("���������Ϊ6-12λ!");
            //    if (newPwd1.Equals(newPwd2) == false) throw new Exception("�����������벻һ�£�����!");
            //    if (oldPwd.Equals(newPwd1)) throw new Exception("�����벻����ԭ������ͬ������������!");
            //    ReturnInfo RInfo = autofacConfig.coreUserService.ChangePwd(lblUserID.Text, oldPwd, newPwd1);
            //    if (RInfo.IsSuccess == true)
            //    {
            //        Form.Close();
            //        Toast("�����޸ĳɹ�");
            //    }
            //    else
            //    {
            //        throw new Exception(RInfo.ErrorInfo);
            //    }
            // }
            //catch(Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }
    }
}
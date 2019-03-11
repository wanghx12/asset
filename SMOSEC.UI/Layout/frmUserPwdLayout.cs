using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.Domain.Entity;
using SMOSEC.UI.UserInfo;
using SMOSEC.DTOs.Enum;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmUserPwdLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        #endregion
        /// <summary>
        /// ȡ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Press(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// ȷ�ϲ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Press(object sender, EventArgs e)
        {
            try
            {
                coreUser user=autofacConfig.coreUserService.GetUserByID(Client.Session["UserID"].ToString());
                if (user.USER_PASSWORD == txtPwd.Text)
                {
                    this.Close();
                    if (((frmSet)Form).eInfo == EuserInfo.�޸�����)
                    {
                        frmChangePwd frm = new frmChangePwd();
                        frm.oldPwd = txtPwd.Text;
                        Form.Show(frm);
                    }
                    else
                    {
                        frmChangeMeg frm = new frmChangeMeg();
                        frm.eInfo = ((frmSet)Form).eInfo;
                        Form.Show(frm);
                    }
                }
                else
                {
                    txtPwd.Text = "";
                    throw new Exception("�����ԭ���벻��ȷ������������!");
                }
            }
            catch(Exception ex)
            {
                Form.Toast(ex.Message);
            }
        } 
    }
}
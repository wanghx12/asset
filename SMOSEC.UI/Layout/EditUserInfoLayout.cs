using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.UI.UserInfo;
using SMOSEC.DTOs.Enum;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class EditUserInfoLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// �������ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditUserInfoLayout_Load(object sender, EventArgs e)
        {
            try
            {
                String editLbltxt=((frmMessage)Form).eInfo.ToString();
                if (((frmMessage)Form).eInfo == EuserInfo.�޸��ǳ�)
                {
                    if (((frmMessage)Form).lblName.Text.Trim().Length > 0)
                        txtEditInfo.Text = ((frmMessage)Form).lblName.Text;
                    else
                        txtEditInfo.Text = "";
                }
            }
            catch(Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// ȡ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// �ύ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Press(object sender, EventArgs e)
        {
            try
            {
                if (((frmMessage)Form).eInfo == EuserInfo.�޸��ǳ�)
                {
                    if (String.IsNullOrEmpty(txtEditInfo.Text.Trim()) == false)
                    {
                        ((frmMessage)Form).UpdateUserInfo(EuserInfo.�޸��ǳ�, txtEditInfo.Text);
                        ((frmMessage)Form).lblName.Text = txtEditInfo.Text;
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("��ǰ��δ�����ǳ�!");
                    }
                }
            }
            catch(Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}
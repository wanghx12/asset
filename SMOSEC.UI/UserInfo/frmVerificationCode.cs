using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.UserInfo
{
    partial class frmVerificationCode : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        public String  tel;       //�ֻ�����
        public Boolean  isForgetPwd;             //�Ƿ���������
        public String code;             //�ֻ���֤��
        #endregion
        private void frmVerificationCode_Load(object sender, EventArgs e)
        {
            lblTel.Text = "������֤���ѷ����ֻ���" + tel;
        }
        /// <summary>
        /// �ֻ��Դ����ؼ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVerificationCode_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back) Close();
        }
        /// <summary>
        /// ��ת����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Press(object sender, EventArgs e)
        {
            try
            {
                String vcode = txtVcode.Text.Trim();
                if (vcode.Length > 0)
                {
                    if (vcode != code) throw new Exception("���������֤�����!");
                    if (isForgetPwd)
                    {
                        frmSettingPWD frm = new frmSettingPWD();
                        frm.isForgetPwd = isForgetPwd;
                        frm.tel = tel;
                        frm.vcode = vcode;
                        Show(frm);
                    }
                    else
                    {
                        frmRegister frm = new frmRegister();
                        frm.Tel = tel;
                        frm.VCode = vcode;
                        Show(frm);
                    }
                }
                else
                {
                    throw new Exception("�������ֻ���֤��!");
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
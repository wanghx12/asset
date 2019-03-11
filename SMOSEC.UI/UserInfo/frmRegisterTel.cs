using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Text.RegularExpressions;

namespace SMOSEC.UI.UserInfo
{
    partial class frmRegisterTel : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        public Boolean isForgetPwd;       //�Ƿ������ֻ�����
        public String UserID;             //�û����(�ֻ������������)
        #endregion
        private void frmRegisterTel_Load(object sender, EventArgs e)
        {
            try
            {
                if (isForgetPwd)
                {
                    if (String.IsNullOrEmpty(UserID) == false)
                    {
                        if (UserID.Contains("@") || (UserID.Length == 11 && Regex.IsMatch(UserID, @"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$")))
                        {
                            txtTel.Text = UserID;
                        }
                        else
                        {
                            lblTitle.Text = "�������ֻ����������";
                        }
                    }
                    else
                    {
                        lblTitle.Text = "�������ֻ������������";
                    }
                    txtTel.WaterMarkText = "�ֻ����������";
                }
                else
                {
                    lblTitle.Text = "�������ֻ�����";
                    txtTel.WaterMarkText = "�ֻ�����";
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// �ֻ��Դ����ؼ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegisterTel_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back) Close();
        }
        /// <summary>
        /// ��һ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Press(object sender, EventArgs e)
        {
            try
            {
                Boolean isPhone = false;
                if (txtTel.Text.Trim().Length <= 0)    //�Ƿ����ֻ�����
                    throw new Exception("������绰����!");
                else
                {
                    UserID = txtTel.Text.Trim();
                    if (isForgetPwd)
                    {
                        if (UserID.Contains("@"))
                        {
                            Regex regex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                            if (regex.IsMatch(UserID) == false)
                                throw new Exception("�����ʽ����ȷ!");
                        }
                        else
                        {
                            Regex regex = new Regex(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$");
                            if (regex.IsMatch(UserID) == false)
                                throw new Exception("�ֻ������ʽ����ȷ!");
                            else
                                isPhone = true;
                        }
                    }
                    else
                    {
                        isPhone = true;
                    }
                    if (isPhone)
                    {
                        //��֤�ֻ������Ƿ���ע��
                        Boolean isRegister = autofacConfig.coreUserService.PhoneIsExit(UserID);
                        //�ֻ�ע��ʱ����֤�ֻ������Ƿ���ע�ᣬ������trueʱ�����׳�����
                        if (isRegister == true) throw new Exception("�绰����"+UserID+"��ע��!");
                        if (isRegister == false && isForgetPwd == true) throw new Exception("�˺�" + UserID + "������!");
                    }
                    int result = autofacConfig.ValidateCodeService.SendVCode(UserID,Client.DeviceID);
                    if (result !=0)
                    {
                        if (isPhone)
                        {
                            frmVerificationCode frm = new frmVerificationCode
                            {
                                tel = UserID,
                                isForgetPwd = isForgetPwd,
                                code = result.ToString()
                            };
                            Show(frm);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
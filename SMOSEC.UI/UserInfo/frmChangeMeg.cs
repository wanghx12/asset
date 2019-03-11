using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.DTOs.Enum;
using System.Text.RegularExpressions;

namespace SMOSEC.UI.UserInfo
{
    partial class frmChangeMeg : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        public String UserID;        //�û����
        public EuserInfo eInfo;          //ѡ���޸���Ŀ
        #endregion
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChangeMeg_Load(object sender, EventArgs e)
        {
            try
            {
                if (eInfo ==EuserInfo.�޸ĵ绰)
                {
                    title1.TitleText = "�����ֻ�����";
                    lblInfo.Text = "�ֻ�����";
                    txtInfo.WaterMarkText = "�������µ��ֻ�����";
                    btnNext.Text = "���";
                }
                else
                {
                    title1.TitleText = "��������";
                    lblInfo.Text = "����";
                    txtInfo.WaterMarkText = "�������µ�����";
                    btnNext.Text = "���";
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
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
                if (eInfo == EuserInfo.�޸ĵ绰)
                {
                    Regex regex = new Regex(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$");
                    if (String.IsNullOrEmpty(txtInfo.Text))
                        throw new Exception("�绰����Ϊ��");
                    else if (regex.IsMatch(txtInfo.Text) == false)
                        throw new Exception("�ֻ������ʽ����ȷ!");
                    Boolean isExit = autofacConfig.coreUserService.PhoneIsExit(txtInfo.Text);
                    if (isExit) throw new Exception("���ֻ�������ע��!");
                    if (autofacConfig.ValidateCodeService.SendVCode(txtInfo.Text, Client.DeviceID) !=0)
                    {
                        frmVCode frm = new frmVCode();
                        frm.tel = txtInfo.Text;
                        this.Close();
                        this.Show(frm);
                    }
                }
                else if (eInfo == EuserInfo.�޸�����)
                {
                    Regex regex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                    if (String.IsNullOrEmpty(txtInfo.Text))
                        throw new Exception("���䲻��Ϊ��");
                    else if (regex.IsMatch(txtInfo.Text) == false)
                        throw new Exception("�����ʽ����ȷ!");
                    Boolean isExit = autofacConfig.coreUserService.PhoneIsExit(txtInfo.Text);
                    if (isExit) throw new Exception("��������ע��!");
                    if (autofacConfig.ValidateCodeService.SendEmail(txtInfo.Text, Client.DeviceID))
                    {
                        this.Close();
                        Toast("�ѷ����������䣬��ǰ����֤!");
                    }
                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }


    }
}
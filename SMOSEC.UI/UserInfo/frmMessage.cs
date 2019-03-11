using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.UI.Layout;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SMOSEC.CommLib;

namespace SMOSEC.UI.UserInfo
{
    partial class frmMessage : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        public String UserID;        //�û���
        //private EditUserInfoLayout Dialog = new EditUserInfoLayout();     //�޸���Ϣ
        #endregion
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMessage_Load(object sender, EventArgs e)
        {
            try
            {
                UserID = Client.Session["local_username"].ToString();
                cmdb_userinfo UserData = autofacConfig.coreUserService.GetUserByID(UserID);
                lblID.Text = UserData.local_username;
                lblPhone.Text = UserData.permission;
                switch (UserData.permission)
                {
                    case "super":
                        lblPhone.Text = "��������Ա";
                        break;
                    case "admin":
                        lblPhone.Text = "����Ա";
                        break;
                    case "guest":
                        lblPhone.Text = "��ͨ�û�";
                        break;

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
 
        /// <summary>
        /// �˻�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMessage_Press(object sender, EventArgs e)
        {
            //frmSet frm = new frmSet();
            //frm.eInfo = eInfo;
            //frm.isDemo = isDemo;
            //this.Show(frm);
        }
        /// <summary>
        /// �����û���Ϣ
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Value"></param>
        public void UpdateUserInfo(EuserInfo Type, String Value)
        {
            //try
            //{
            //    coreUser UserInfo = new coreUser();
            //    UserInfo.USER_ID = UserID;
            //    switch (Type)
            //    {
            //        case EuserInfo.�޸ĵ�ַ:
            //            UserInfo.USER_ADDRESS = Value;
            //            break;
            //        case EuserInfo.�޸�ͷ��:
            //            UserInfo.USER_IMAGEID = Value;
            //            break;
            //        case EuserInfo.�޸��Ա�:
            //            UserInfo.USER_SEX = Convert.ToInt32(Value);
            //            break;
            //        case EuserInfo.�޸��ǳ�:
            //            UserInfo.USER_NAME = Value;
            //            break;
            //        case EuserInfo.�޸�����:
            //            UserInfo.USER_BIRTHDAY = Convert.ToDateTime(Value);
            //            break;
            //        case EuserInfo.�޸���������:
            //            UserInfo.USER_LOCATIONID = Value;
            //            break;
            //    }
            //    ReturnInfo RInfo = autofacConfig.coreUserService.UpdateUser(UserInfo, Type);
            //    if (RInfo.IsSuccess)
            //    {
            //        Toast("�޸���Ϣ�ɹ�!");
            //    }
            //    else
            //    {
            //        throw new Exception(RInfo.ErrorInfo);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Toast(ex.Message);
            //}
        }
    }
}
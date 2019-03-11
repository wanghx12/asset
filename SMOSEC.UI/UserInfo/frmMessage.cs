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
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public String UserID;        //用户名
        //private EditUserInfoLayout Dialog = new EditUserInfoLayout();     //修改信息
        #endregion
        /// <summary>
        /// 页面初始化
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
                        lblPhone.Text = "超级管理员";
                        break;
                    case "admin":
                        lblPhone.Text = "管理员";
                        break;
                    case "guest":
                        lblPhone.Text = "普通用户";
                        break;

                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
 
        /// <summary>
        /// 账户设置
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
        /// 更新用户信息
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
            //        case EuserInfo.修改地址:
            //            UserInfo.USER_ADDRESS = Value;
            //            break;
            //        case EuserInfo.修改头像:
            //            UserInfo.USER_IMAGEID = Value;
            //            break;
            //        case EuserInfo.修改性别:
            //            UserInfo.USER_SEX = Convert.ToInt32(Value);
            //            break;
            //        case EuserInfo.修改昵称:
            //            UserInfo.USER_NAME = Value;
            //            break;
            //        case EuserInfo.修改生日:
            //            UserInfo.USER_BIRTHDAY = Convert.ToDateTime(Value);
            //            break;
            //        case EuserInfo.修改所属区域:
            //            UserInfo.USER_LOCATIONID = Value;
            //            break;
            //    }
            //    ReturnInfo RInfo = autofacConfig.coreUserService.UpdateUser(UserInfo, Type);
            //    if (RInfo.IsSuccess)
            //    {
            //        Toast("修改信息成功!");
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
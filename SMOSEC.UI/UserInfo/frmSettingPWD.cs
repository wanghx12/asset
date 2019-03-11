//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Smobiler.Core;
//using Smobiler.Core.Controls;
//using SMOSEC.Domain.Entity;
//using SMOSEC.CommLib;
//using SMOSEC.UI.MasterData;

//namespace SMOSEC.UI.UserInfo
//{
//    partial class frmSettingPWD : Smobiler.Core.Controls.MobileForm
//    {
//        #region "definition"
//        AutofacConfig autofacConfig = new AutofacConfig();     //����������
//        public String tel;              //�ֻ�����
//        public String  vcode;           //�ֻ���֤��
//        public Boolean isForgetPwd;     //�Ƿ���������
//        #endregion
//        /// <summary>
//        /// ҳ���ʼ��
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void frmSettingPWD_Load(object sender, EventArgs e)
//        {
//            if(isForgetPwd)    //�������룬�ֻ���֤
//            {
//                lblID1.Visible = false;
//                lblID2.Visible = false;
//                txtID.Visible = false;
//            }
//            else          //������ֻ�ע��
//            {
//                lblID1.Visible = true;
//                lblID2.Visible = true;
//                txtID.Visible = true;
//            }
//        }
//        /// <summary>
//        /// �ֻ��Դ����ؼ�����
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void frmSettingPWD_KeyDown(object sender, KeyDownEventArgs e)
//        {
//            if (e.KeyCode == KeyCode.Back) Close();
//        }

//        private void btnNext_Press(object sender, EventArgs e)
//        {
//            try
//            {
//                String UserID = txtID.Text.Trim();
//                if (isForgetPwd == false)
//                {
//                    if (UserID.Length < 0) throw new Exception("�������˺�!");
//                    if (UserID.Length < 6 || UserID.Length > 18) throw new Exception("�˺ű���Ϊ6-18λ!");
//                }
//                String pwd = txtPwd.Text.Trim();
//                if (pwd.Length <= 0) throw new Exception("����������!");
//                if (pwd.Length < 6 || pwd.Length > 12) throw new Exception("�������Ϊ6-12λ!");
//                if (isForgetPwd)    //�������룬�ֻ���֤
//                {
//                    coreUser coreUser= autofacConfig.coreUserService.GetUserByID(UserID);
//                    if(coreUser != null)
//                    {
//                        String OldPwd = coreUser.USER_PASSWORD;
//                        ReturnInfo RInfo= autofacConfig.coreUserService.ChangePwd(UserID,OldPwd,pwd);
//                        if (RInfo.IsSuccess)
//                        {
//                            ReturnInfo result=  autofacConfig.coreUserService.Login(UserID,pwd);
//                            if (result.IsSuccess)
//                            {
//                                String Role = autofacConfig.coreUserService.GetUserByID(UserID).USER_ROLE;
//                                Client.Session["UserID"] = UserID;
//                                Client.Session["Role"] = Role;
//                                frmAssets frm = new frmAssets();
//                                Show(frm);
//                            }
//                            else
//                            {
//                                throw new Exception(result.ErrorInfo);
//                            }
//                        }
//                    }
//                    else
//                    {
//                        throw new Exception("δ�ҵ����û�!");
//                    }
//                }
//            }
//            catch(Exception ex)
//            {
//                Toast(ex.Message);
//            }
//        }
//    }
//}
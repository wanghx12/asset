//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Smobiler.Core;
//using Smobiler.Core.Controls;

//namespace SMOSEC.UI.UserInfo
//{
//    partial class frmVCode : Smobiler.Core.Controls.MobileForm
//    {
//        #region "definition"
//        AutofacConfig autofacConfig = new AutofacConfig();     //����������
//        public String UserID;        //�û����
//        public String tel;          //�ֻ�����
//        #endregion
//        /// <summary>
//        /// ҳ���ʼ��
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void frmVCode_Load(object sender, EventArgs e)
//        {
//            try
//            {
//                UserID = Client.Session["UserID"].ToString();
//                lblTel.Text = "������֤���ѷ������ֻ�" + tel;
//            }
//            catch(Exception ex)
//            {
//                Toast(ex.Message);
//            }
//        }
//        /// <summary>
//        /// ����
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void btnSave_Press(object sender, EventArgs e)
//        {
//            try
//            {
//                if (String.IsNullOrEmpty(txtVcode.Text)) throw new Exception("��֤�벻��Ϊ��!");
//                if (autofacConfig.ValidateCodeService.isValidate(UserID, tel, txtVcode.Text))
//                {
//                    Close();
//                    Toast("�޸ĵ绰�ɹ�!");
//                }
//            }
//            catch(Exception ex)
//            {
//                Toast(ex.Message);
//            }
//        }
//    }
//}
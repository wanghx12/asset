//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Smobiler.Core;
//using Smobiler.Core.Controls;
//using SMOSEC.DTOs.Enum;
//using SMOSEC.UI.Layout;

//namespace SMOSEC.UI.UserInfo
//{
//    partial class frmSet : Smobiler.Core.Controls.MobileForm
//    {
//        #region "definition"
//        AutofacConfig autofacConfig = new AutofacConfig();     //����������
//        public EuserInfo eInfo;            //�û��޸���
//        public Boolean isDemo;       //�Ƿ�����ʾ�˺�
//        #endregion
//        /// <summary>
//        /// �޸�����
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void tpChangePwd_Press(object sender, EventArgs e)
//        {
//            try
//            {
//                if (isDemo)
//                {
//                    throw new Exception("��ǰΪ��ʾ�˺ţ����ܽ��������޸�!");
//                }
//                else
//                {
//                    frmUserPwdLayout UserLayout = new frmUserPwdLayout();
//                    eInfo = EuserInfo.�޸�����;
//                    Form.ShowDialog(UserLayout);
//                }
//            }
//            catch (Exception ex)
//            {
//                Toast(ex.Message);
//            }
//        }
//        /// <summary>
//        /// �޸ĵ绰
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void tpChangePhone_Press(object sender, EventArgs e)
//        {
//            if (isDemo == false)
//            {
//                frmUserPwdLayout UserLayout = new frmUserPwdLayout();
//                eInfo = EuserInfo.�޸ĵ绰;
//                Form.ShowDialog(UserLayout);
//            }
//            else
//            {
//                Toast("��ǰΪ��ʾ�˺ţ����ܽ��е绰�޸�!");
//            }
//        }
//        /// <summary>
//        /// �޸�����
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void tpChangeEmail_Press(object sender, EventArgs e)
//        {
//            if (isDemo == false)
//            {
//                frmUserPwdLayout UserLayout = new frmUserPwdLayout();
//                eInfo = EuserInfo.�޸�����;
//                Form.ShowDialog(UserLayout);
//            }
//            else
//            {
//                Toast("��ǰΪ��ʾ�˺ţ����ܽ��������޸�!");
//            }
//        }
//        /// <summary>
//        /// ע���û�
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void btnExit_Press(object sender, EventArgs e)
//        {
//            MessageBox.Show("�Ƿ�ע����ǰ�û���", "ϵͳ����", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
//             {
//                 if (args.Result == ShowResult.OK)
//                 {
//                     Client.ReStart();
//                 }
//             });
//        }
//    }
//}
//using System;
//using System.Data;
//using Smobiler.Core.Controls;

//namespace SMOSEC.UI.MasterData
//{
//    /// <summary>
//    /// �����¼չʾ����
//    /// </summary>
//    partial class frmPrShow : Smobiler.Core.Controls.MobileForm
//    {
//        #region ����
//        public string AssId;  //�ʲ����
//        AutofacConfig _autofacConfig = new AutofacConfig();//����������
        

//        #endregion

//        /// <summary>
//        /// �����˼����رյ�ǰ����
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void frmPRShow_KeyDown(object sender, KeyDownEventArgs e)
//        {
//            try
//            {
//                if (e.KeyCode == KeyCode.Back)
//                    Close();
//            }
//            catch (Exception ex)
//            {
//                Toast(ex.Message);
//            }
//        }

//        /// <summary>
//        /// �����ʼ��
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void frmPRShow_Load(object sender, EventArgs e)
//        {
//            //try
//            //{
//            //    DataTable table = _autofacConfig.SettingService.GetRecords(AssId,"");
//            //    if (table != null)
//            //    {
//            //        GridView1.DataSource = table;
//            //        GridView1.DataBind();
//            //    }

//            //}
//            //catch (Exception ex)
//            //{
//            //    Toast(ex.Message);
//            //}
//        }
//    }
//}
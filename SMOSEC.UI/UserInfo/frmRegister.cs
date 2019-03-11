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
//    partial class frmRegister : Smobiler.Core.Controls.MobileForm
//    {
//        #region "definition"
//        AutofacConfig autofacConfig = new AutofacConfig();     //����������
//        public String Tel;        //�绰����
//        public String VCode;      //��֤��
//        public Boolean isPwd1;       //�������Ƿ���ʾ�����ַ�����
//        private Boolean isPwd2;     //ȷ�������Ƿ���ʾ�����ַ�����
//        #endregion
//        /// <summary>
//        /// �������Ƿ���ʾ�����ַ�
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void tpPwd1_Press(object sender, EventArgs e)
//        {
//            if (isPwd1 == false)
//            {
//                txtPwd1.SecurityMode = true;
//                //����textboxΪ�����ַ�
//                fontPwd1.ResourceID = "eye-slash";
//                isPwd1 = true;
//            }
//            {
//                txtPwd1.SecurityMode = false;
//                //textbox�����ַ�Ϊ��ʱ����ʾ����
//                fontPwd1.ResourceID = "eye";
//                isPwd1 = false;
//            }
//        }
//        /// <summary>
//        /// ȷ�������Ƿ���ʾ�����ַ�
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void tpPwd2_Press(object sender, EventArgs e)
//        {
//            if (isPwd2 == false)
//            {
//                txtPwd2.SecurityMode = false;
//                //����textboxΪ�����ַ�
//                fontPwd2.ResourceID = "eye-slash";
//                isPwd2 = true;
//            }
//            else
//            {
//                txtPwd2.SecurityMode = false;
//                //textbox�����ַ�Ϊ��ʱ����ʾ����
//                fontPwd2.ResourceID = "eye";
//            }
//        }
//        /// <summary>
//        /// �����û�
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void btnSave_Press(object sender, EventArgs e)
//        {
//            try
//            {
//                if (txtName.Text.Trim().Length < 0) throw new Exception("�������ǳ�");
//                String pwd1 = txtPwd1.Text.Trim();
//                String pwd2 = txtPwd2.Text.Trim();
//                if (pwd1.Length <= 0) throw new Exception("������������!");
//                if (pwd1.Length < 6 || pwd1.Length > 12) throw new Exception("���������Ϊ6-12λ!");
//                if (pwd2.Length <= 0) throw new Exception("������ȷ������!");
//                if (pwd2.Length < 6 || pwd2.Length > 12) throw new Exception("���������Ϊ6-12λ!");
//                if (pwd1.Equals(pwd2) == false) throw new Exception("�����������벻һ�£�����!");
//                if(String.IsNullOrEmpty(radioGroup1.CheckedButton.Value)) throw new Exception("��ѡ���ɫ!");
//                if(radioGroup1.CheckedButton.Value != "ADMIN")     //�û�����ѡ�����򣬹�·Ա���Բ�ѡ
//                {
//                    if (btnLocation.Tag == null) throw new Exception("��ѡ����������");
//                }
                

//                coreUser UserData = new coreUser();
//                UserData.USER_ID = Tel;
//                if(btnLocation.Tag !=null)
//                    UserData.USER_LOCATIONID = btnLocation.Tag.ToString();
//                UserData.USER_NAME = txtName.Text;
//                UserData.USER_PASSWORD = pwd1;
//                UserData.USER_PHONE = Tel;
//                UserData.USER_LANGUAGE = 0;
//                UserData.USER_ROLE = radioGroup1.CheckedButton.Value;

//                ReturnInfo RInfo = autofacConfig.coreUserService.AddUser(UserData);
//                if (RInfo.IsSuccess)
//                {
//                    Client.Session["UserID"] = Tel;
//					Client.Session["Role"] = radioGroup1.CheckedButton.Value;
//                    //�رյ�ǰ����
//                    this.Close();
//                    frmAssets frm = new frmAssets();
//                    //��ת���ʲ�������
//                    Show(frm);
//                }
//                else
//                {
//                    throw new Exception(RInfo.ErrorInfo);
//                }
//            }
//            catch(Exception ex)
//            {
//                Toast(ex.Message);
//            }
//        }
//        /// <summary>
//        /// ѡ������
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void btnLocation_Press(object sender, EventArgs e)
//        {
//            try
//            {
//                popLocation.Groups.Clear();       //�������
//                PopListGroup poli = new PopListGroup();
//                popLocation.Groups.Add(poli);
//                poli.Title = "��������ѡ��";
//                List<AssLocation> users = autofacConfig.assLocationService.GetEnableAll();
//                foreach (AssLocation Row in users)
//                {
//                    poli.AddListItem(Row.NAME, Row.LOCATIONID);
//                }
//                if (btnLocation.Tag != null)   //�������ѡ�������ʾѡ��Ч��
//                {
//                    foreach (PopListItem Item in poli.Items)
//                    {
//                        if (Item.Value == btnLocation.Tag.ToString())
//                            popLocation.SetSelections(Item);
//                    }
//                }
//                popLocation.ShowDialog();
//            }
//            catch (Exception ex)
//            {
//                Toast(ex.Message);
//            }
//        }
//        /// <summary>
//        /// ѡ�����������
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void popLocation_Selected(object sender, EventArgs e)
//        {
//            try
//            {
//                if (String.IsNullOrEmpty(popLocation.Selection.Text) == false)
//                {
//                    btnLocation.Text = popLocation.Selection.Text + "   > ";
//                    btnLocation.Tag = popLocation.Selection.Value;         //������
//                }
//            }
//            catch (Exception ex)
//            {
//                Toast(ex.Message);
//            }
//        }
//    }
//}
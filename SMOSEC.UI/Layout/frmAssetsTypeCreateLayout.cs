using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.Domain.Entity;
using SMOSEC.CommLib;
using SMOSEC.UI.MasterData;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsTypeCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region
        public String ID;    //������
        public Boolean isCreate;     //ҳ���Ƿ�Ϊ����״̬
        public Boolean isEdit;       //ҳ���Ƿ�Ϊ�༭״̬
        public Boolean isCreateSon;  //ҳ���Ƿ�Ϊ�����ӷ��� 
        AutofacConfig autofacConfig = new AutofacConfig();     //����������
        #endregion
        /// <summary>
        /// �رյ�ǰ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// �ύ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtID.Text)) throw new Exception("�����Ų���Ϊ��");
                if (String.IsNullOrEmpty(txtName.Text)) throw new Exception("�������Ʋ���Ϊ��");
                if (String.IsNullOrEmpty(txtDate.Text)) throw new Exception("���޲���Ϊ��");

                AssetsType at = new AssetsType();
                if (isCreate == true || isCreateSon == true)        //�½�����
                {                
                    at.TYPEID = txtID.Text;       //������
                    at.NAME = txtName.Text;       //��������
                    at.EXPIRYDATE = Convert.ToInt32(txtDate.Text);   //������Ч����
                    at.PARENTTYPEID = txtFID.Text;      //��������
                    if (isCreate == true) at.TLEVEL = 1;       //���༶��
                    if (isCreateSon == true) at.TLEVEL = autofacConfig.assTypeService.GetByID(txtFID.Text).TLEVEL+1;

                    ReturnInfo r = autofacConfig.assTypeService.AddAssetsType(at);
                    if (r.IsSuccess == true)
                    {
                        this.Close();      //�رմ���������
                        this.Form.Toast("�����ʲ�����ɹ�");
                        //ˢ��ҳ������
                        ((frmAssetsTypeRows)Form).Bind();
                    }
                    else
                    {
                        throw new Exception(r.ErrorInfo);
                    }
                }
                else if (isEdit == true)      //�޸ķ���
                {
                    at.TYPEID = txtID.Text;           //������
                    at.NAME = txtName.Text;          //��������
                    at.EXPIRYDATE = Convert.ToInt32(txtDate.Text);     //������Ч����
                    at.PARENTTYPEID = txtFID.Text;              //��������

                    ReturnInfo r = autofacConfig.assTypeService.UpdateAssetsType(at);
                    if (r.IsSuccess == true)
                    {
                        this.Close();      //�رմ���������
                        this.Form.Toast("�ʲ�������Ϣ�޸ĳɹ�");
                        //ˢ��ҳ������
                        ((frmAssetsTypeRows)Form).Bind();
                    }
                    else
                    {
                        throw new Exception(r.ErrorInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsTypeCreateLayout_Load(object sender, EventArgs e)
        {
            try
            {
                AssetsType at = autofacConfig.assTypeService.GetByID(ID);
                if (isEdit == true)    //�༭�˷���
                {
                    txtID.ReadOnly = true;
                    txtID.Text = at.TYPEID;             //������
                    txtName.Text = at.NAME;             //��������
                    txtDate.Text = at.EXPIRYDATE.ToString();    //������Ч����
                    if (String.IsNullOrEmpty(at.PARENTTYPEID) == false)        //����и��࣬����ʾ������Ϣ
                    {
                        AssetsType parentAt = autofacConfig.assTypeService.GetByID(at.PARENTTYPEID);
                        txtFID.Text = parentAt.TYPEID;       //��������
                        txtFName.Text = parentAt.NAME;       //����������
                        txtFDate.Text = parentAt.EXPIRYDATE.ToString();       //��������Ч����
                    }
                }
                else if (isCreateSon == true)     //�����ӷ���
                {
                    txtFID.Text = at.TYPEID;    //��������
                    txtFName.Text = at.NAME;    //����������
                    txtFDate.Text = at.EXPIRYDATE.ToString();    //��������Ч����
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}
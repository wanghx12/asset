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
    partial class frmLocationCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "define"
        AutofacConfig autofacConfig = new AutofacConfig();
        public String ID;        //������
        public Boolean isCreate = false;       //ҳ���Ƿ�Ϊ����״̬
        public Boolean isEdit = false;      //ҳ���Ƿ�Ϊ�༭״̬
        private String OldManger;          //����ԭ����Ա
        #endregion
        /// <summary>
        /// ȡ������
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
                if (btnManager.Tag == null) throw new Exception("�������˲���Ϊ��");

                AssLocation ass = autofacConfig.assLocationService.GetByManager(btnManager.Tag.ToString());
                String[] data= btnManager.Text.Split(' ');
                if (ass != null) throw new Exception(data[0] + "�Ѿ����������Ա,��ѡ�������û���");
                //��ȡ����������Ϣ
                AssLocation AssLoc = new AssLocation
                {
                    LOCATIONID = txtID.Text,
                    NAME = txtName.Text,
                    MANAGER = btnManager.Tag.ToString(),
                };
                if (isCreate == true)     //�½�����
                {
                    ReturnInfo r = autofacConfig.assLocationService.AddAssLocation(AssLoc);
                    if (r.IsSuccess == false)
                    {
                        throw new Exception(r.ErrorInfo);
                    }
                    else
                    {
                        this.Close();
                        Form.Toast("���򴴽��ɹ�");
                    }
                }
                else      //��������
                {
                    ReturnInfo r = autofacConfig.assLocationService.UpdateAssLocation(AssLoc,OldManger);
                    if (r.IsSuccess == false)
                    {
                        throw new Exception(r.ErrorInfo);
                    }
                    else
                    {
                        this.Close();
                        Form.Toast("�޸�������Ϣ�ɹ�");
                    }
                }
                //ˢ����ʾ�б�
                ((frmLocationRows)Form).Bind();
            }
            catch (Exception ex)
            {
                this.Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLocationCreateLayout_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ID) == false)    //������Ϣ�༭
            {
                AssLocation location = autofacConfig.assLocationService.GetByID(ID);
                coreUser core = autofacConfig.coreUserService.GetUserByID(location.MANAGER);
                txtID.ReadOnly = true;                //�����Ų������޸�
                this.txtID.Text = ID;                 //������
                this.txtName.Text = location.NAME;          //��������
                this.btnManager.Text = core.USER_NAME + "   > ";     //�������������
                this.btnManager.Tag = location.MANAGER;    //��������߱��
                OldManger = location.MANAGER;        //�����ԭ����Ա
            }
        }
        /// <summary>
        /// ��������ѡ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManager_Press(object sender, EventArgs e)
        {
            try
            {
                popManager.Groups.Clear();
                popManager.Groups.Clear();       //�������
                PopListGroup poli = new PopListGroup();
                popManager.Groups.Add(poli);
                poli.Title = "������ѡ��";
                List<coreUser> users = autofacConfig.coreUserService.GetAll();
                foreach (coreUser Row in users)
                {
                    poli.AddListItem(Row.USER_NAME, Row.USER_ID);
                }
                if (btnManager.Tag != null)   //�������ѡ�������ʾѡ��Ч��
                {
                    foreach (PopListItem Item in poli.Items)
                    {
                        if (Item.Value == btnManager.Tag.ToString())
                            popManager.SetSelections(Item);
                    }
                }
                popManager.ShowDialog();
            }
            catch(Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// ������ѡ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popManager_Selected(object sender, EventArgs e)
        {
            if(btnManager.Tag == null)
            {
                btnManager.Tag = popManager.Selection.Value;
                btnManager.Text = popManager.Selection.Text + "   > ";
            }
            else if(popManager.Selection.Value != btnManager.Tag.ToString())
            {
                btnManager.Tag = popManager.Selection.Value;
                btnManager.Text = popManager.Selection.Text + "   > ";
            }
        }
    }
}
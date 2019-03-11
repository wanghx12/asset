using System;
using System.Collections.Generic;
using Smobiler.Core.Controls;
using SMOSEC.UI;
using SMOSEC.DTOs.OutputDTO;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SMOSEC.UI.UserInfo;

namespace SMOSEC.UI.Department
{
    // ******************************************************************
    // �ļ��汾�� SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // ����ʱ�䣺 2016/11
    // ��Ҫ���ݣ�  �����б����
    // ******************************************************************
    partial class frmDepartment : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        public DepartmentMode Mode; //�ͻ�չʾģʽ
        AutofacConfig AutofacConfig = new AutofacConfig();//����������
        #endregion

        /// <summary>
        /// ��ʼ���¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartment_Load(object sender, EventArgs e)
        {
            Mode = DepartmentMode.�б�;
            Bind();
        }
        /// <summary>
        /// ��ʼ������
        /// </summary>
        public void Bind()
        {
            try
            {
                //��ȡ���в�������
                List<DepartmentDto> listDep = AutofacConfig.DepartmentService.GetAllDepartment();
                switch (Mode)
                {
                    case DepartmentMode.�б�:
                        gridDepData.Rows.Clear();//��ղ����б�����
                        btnDMode.Text = DepartmentMode.�㼶 + "չʾ";
                        break;
                    case DepartmentMode.�㼶:
                        treeDepData.Nodes.Clear();//��ղ��Ų㼶����
                        btnDMode.Text = DepartmentMode.�б� + "չʾ";
                        break;
                }

                if (listDep.Count > 0)
                {
                    btnDMode.Visible = true;

                    lblInfor.Visible = false;
                    foreach (DepartmentDto dep in listDep)
                    {
                        if (string.IsNullOrEmpty(dep.IMAGEID) == true)
                        {
                            dep.IMAGEID = "bumenicon";
                        }

                    }
                    switch (Mode)
                    {
                        case DepartmentMode.�б�:
                            gridDepData.Visible = true;
                            treeDepData.Visible = false;
                            gridDepData.DataSource = listDep;
                            gridDepData.DataBind();
                            break;
                        case DepartmentMode.�㼶:
                            gridDepData.Visible = false;
                            treeDepData.Visible = true;
                            foreach (DepartmentDto dep in listDep)
                            {
                                TreeViewNode node = new TreeViewNode(dep.NAME, null, dep.IMAGEID, (int)TreeMode.dep + "," + dep.DEPARTMENTID);
                                node.TextColor = System.Drawing.Color.FromArgb(45, 45, 45);
                                List<coreUser> listDepUser = AutofacConfig.coreUserService.GetUserByDepID(dep.DEPARTMENTID);
                                if (listDepUser.Count > 0)
                                {
                                    foreach (coreUser user in listDepUser)
                                    {
                                        string Name = "";
                                        if (dep.MANAGER.Equals(user.USER_ID))
                                        {
                                            Name = user.USER_NAME + "  ������";
                                        }
                                        else
                                        {
                                            Name = user.USER_NAME;
                                        }
                                        string portrait = "";
                                        if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                        {
                                            switch (user.USER_SEX)
                                            {
                                                case (int)Sex.��:
                                                    portrait = "male";
                                                    break;
                                                case (int)Sex.Ů:
                                                    portrait = "female";
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            portrait = user.USER_IMAGEID;
                                        }
                                        TreeViewNode node1 = new TreeViewNode(Name, null, portrait, (int)TreeMode.user + "," + user.USER_ID);
                                        node1.TextColor = System.Drawing.Color.FromArgb(145, 145, 145);
                                        node.Nodes.Add(node1);
                                    }

                                }
                                treeDepData.Nodes.Add(node);
                            }
                            break;
                    }

                }
                else
                {
                    // btnDMode.Visible = false;
                    lblInfor.Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// �ֻ��Դ����˰�ť�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartment_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }
        /// <summary>
        /// ������ͼƬ��ť����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartment_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// ��ת���������Ž���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmDepartmentCreate frm = new frmDepartmentCreate();
            Show(frm, (MobileForm form, object args) =>
                {
                    if (frm.ShowResult == ShowResult.Yes)
                    {
                        Bind();
                    }
                });

        }

        /// <summary>
        /// treeDepData����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeDepData_NodeSelected(object sender, TreeViewClickEventArgs e)
        {

            // string ID = treeDepData.SelectedNode.Value;
            string ID = e.Value;
            switch (Convert.ToInt32(ID.Split(',')[0]))
            {
                case (int)TreeMode.dep:
                    frmDepartmentDetail frm = new frmDepartmentDetail();
                    frm.D_ID = ID.Split(',')[1];
                    Show(frm, (MobileForm form, object args) =>
                    {
                        if (frm.ShowResult == ShowResult.Yes)
                        {
                            Mode = DepartmentMode.�㼶;
                            Bind();
                        }
                    });
                    break;
                case (int)TreeMode.user:
                    frmDepPerMessage frmMes = new frmDepPerMessage();
                    frmMes.UserID = ID.Split(',')[1];
                    Show(frmMes);
                    break;
            }

        }

        /// <summary>
        /// ������ʾģʽ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDLayout_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case DepartmentMode.�б�:
                    Mode = DepartmentMode.�㼶;
                    break;
                case DepartmentMode.�㼶:
                    Mode = DepartmentMode.�б�;
                    break;
            }
            Bind();
        }
    }
}
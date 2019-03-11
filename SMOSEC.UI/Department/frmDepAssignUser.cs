using System;
using System.Collections.Generic;
using System.Linq;
using Smobiler.Core.Controls;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SMOSEC.UI.Layout;
using SMOSEC.CommLib;
using SMOSEC.DTOs.OutputDTO;

namespace SMOSEC.UI.Department
{
    // ******************************************************************
    // �ļ��汾�� SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler 
    // ����ʱ�䣺 2016/11
    // ��Ҫ���ݣ�  ������Ա�������
    // ******************************************************************
    partial class frmDepAssignUser : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        int selectUserQty = 0;//ѡ����Ա��
        public DepInputDto department;//������Ϣ
        AutofacConfig AutofacConfig = new AutofacConfig();//����������
        #endregion

        /// <summary>
        /// �ֻ��Դ����˼���ť�¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepAssignUser_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                Close();         //�رյ�ǰҳ��
            }
        }

        /// <summary>
        /// ������ͼƬ��ť����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepAssignUser_TitleImageClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// ��ʼ���¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepAssignUser_Load(object sender, EventArgs e)
        {
            Bind();

        }
        /// <summary>
        /// ��ʼ������
        /// </summary>
        private void Bind()
        {
            try
            {
                if (department != null)
                {
                    txtDepName.Text = department.NAME;
                    if (string.IsNullOrEmpty(department.IMAGEID) == false)
                    {
                        imgPortrait.ResourceID = department.IMAGEID;
                        imgPortrait.Refresh();
                    }
                    btnLeader.Text = AutofacConfig.coreUserService.GetUserByID(department.MANAGER).USER_NAME;
                    List<DataGridviewbyUser> listUser = new List<DataGridviewbyUser>();
                    List<coreUser> listDepUser = AutofacConfig.coreUserService.GetAll();//��ȡ���䲿����Ա
                    //���Ŵ���ʱListView������
                    if (string.IsNullOrEmpty(department.DEPARTMENTID) == true)
                    {
                        if (listDepUser.Count > 0)
                        {
                            //��δ���䲿���Ҳ��ǵ�ǰ���������˵��û�����ӵ�listUser��
                            foreach (coreUser user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.USER_DEPARTMENTID) == true) & (!department.MANAGER.Equals(user.USER_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.USER_ID = user.USER_ID;
                                    depUser.USER_NAME = user.USER_NAME;
                                    if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                    {
                                        switch (user.USER_SEX)
                                        {
                                            case (int)Sex.��:
                                                depUser.USER_IMAGEID = "boy";
                                                break;
                                            case (int)Sex.Ů:
                                                depUser.USER_IMAGEID = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.USER_IMAGEID = user.USER_IMAGEID;
                                    }
                                    depUser.USER_DEPARTMENTID = "";
                                    depUser.DepName = "";
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                            //���ѷ��䲿���Ҳ��ǵ�ǰ���������˵��û�����ӵ�listUser��
                            foreach (coreUser user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.USER_DEPARTMENTID) == false) & (!department.MANAGER.Equals(user.USER_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.USER_ID = user.USER_ID;
                                    depUser.USER_NAME = user.USER_NAME;
                                    if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                    {
                                        switch (user.USER_SEX)
                                        {
                                            case (int)Sex.��:
                                                depUser.USER_IMAGEID = "boy";
                                                break;
                                            case (int)Sex.Ů:
                                                depUser.USER_IMAGEID = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.USER_IMAGEID = user.USER_IMAGEID;
                                    }
                                    depUser.USER_DEPARTMENTID = user.USER_DEPARTMENTID;
                                    string DepName = "";
                                    if (AutofacConfig.DepartmentService.GetDepartmentByDepID(user.USER_DEPARTMENTID) != null)
                                    {
                                        DepName = AutofacConfig.DepartmentService.GetDepartmentByDepID(user.USER_DEPARTMENTID).NAME;
                                    }
                                    depUser.DepName = DepName;
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                        }
                    }
                    //���ű༭ʱListView������
                    if (string.IsNullOrEmpty(department.DEPARTMENTID) == false)
                    {
                        if (listDepUser.Count > 0)
                        {
                            //����ǰ�����Ҳ��ǵ�ǰ���������˵��û�����ӵ�listUser��
                            foreach (coreUser user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.USER_DEPARTMENTID) == false) & (department.DEPARTMENTID.Equals(user.USER_DEPARTMENTID)) & (!department.MANAGER.Equals(user.USER_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.USER_ID = user.USER_ID;
                                    depUser.USER_NAME = user.USER_NAME;
                                    if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                    {
                                        switch (user.USER_SEX)
                                        {
                                            case (int)Sex.��:
                                                depUser.USER_IMAGEID = "boy";
                                                break;
                                            case (int)Sex.Ů:
                                                depUser.USER_IMAGEID = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.USER_IMAGEID = user.USER_IMAGEID;
                                    }
                                    depUser.USER_DEPARTMENTID = department.DEPARTMENTID;
                                    depUser.DepName = department.NAME;
                                    depUser.SelectCheck = true;
                                    listUser.Add(depUser);
                                }
                            }
                            //��δ���䲿���Ҳ��ǵ�ǰ���������˵��û�����ӵ�listUser��
                            foreach (coreUser user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.USER_DEPARTMENTID) == true) & (!department.MANAGER.Equals(user.USER_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.USER_ID = user.USER_ID;
                                    depUser.USER_NAME = user.USER_NAME;
                                    if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                    {
                                        switch (user.USER_SEX)
                                        {
                                            case (int)Sex.��:
                                                depUser.USER_IMAGEID = "boy";
                                                break;
                                            case (int)Sex.Ů:
                                                depUser.USER_IMAGEID = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.USER_IMAGEID = user.USER_IMAGEID;
                                    }
                                    depUser.USER_DEPARTMENTID = "";
                                    depUser.DepName = "";
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                            //���ѷ��䲿���Ҳ��ǵ�ǰ���ŵ��û�����ӵ�listUser��
                            foreach (coreUser user in listDepUser)
                            {
                                if ((string.IsNullOrEmpty(user.USER_DEPARTMENTID) == false) & (!department.DEPARTMENTID.Equals(user.USER_DEPARTMENTID)) & (!department.MANAGER.Equals(user.USER_ID)))
                                {
                                    DataGridviewbyUser depUser = new DataGridviewbyUser();
                                    depUser.USER_ID = user.USER_ID;
                                    depUser.USER_NAME = user.USER_NAME;
                                    if (string.IsNullOrEmpty(user.USER_IMAGEID) == true)
                                    {
                                        switch (user.USER_SEX)
                                        {
                                            case (int)Sex.��:
                                                depUser.USER_IMAGEID = "boy";
                                                break;
                                            case (int)Sex.Ů:
                                                depUser.USER_IMAGEID = "girl";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        depUser.USER_IMAGEID = user.USER_IMAGEID;
                                    }
                                    depUser.USER_DEPARTMENTID = user.USER_DEPARTMENTID;
                                    string DepName = AutofacConfig.DepartmentService.GetDepartmentByDepID(user.USER_DEPARTMENTID).NAME;
                                    depUser.DepName = DepName;
                                    depUser.SelectCheck = false;
                                    listUser.Add(depUser);
                                }
                            }
                        }
                    }

                    gridUserData.Rows.Clear();//�����Ա�б�����
                    if (listUser.Count > 0)
                    {
                        gridUserData.DataSource = listUser; //��ListView����
                        gridUserData.DataBind();
                        upCheckState();
                    }

                }
                else
                {
                    throw new Exception("�����벿����Ϣ��");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// ȫѡ
        /// </summary>
        private void Checkall()
        {
            switch (checkAll.Checked)
            {
                case true:
                    foreach (ListViewRow rows in gridUserData.Rows)
                    {
                        //rows.Cell.Items["Check"].DefaultValue = true;
                        ((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue = true;

                    }
                    selectUserQty = gridUserData.Rows.Count;
                    break;
                case false:
                    foreach (ListViewRow rows in gridUserData.Rows)
                    {
                        //rows.Cell.Items["Check"].DefaultValue = false;
                        ((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue = false;

                    }
                    selectUserQty = 0;
                    break;
            }
        }
        /// <summary>
        /// ���䲿����Ա
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> listUser = new List<string>(); //�û�����
                string assignUser = "";//�ѷ��䲿���û�
                string depLeader = "";//�����������û�
                department.NAME = txtDepName.Text.Trim();
                listUser.Add(department.MANAGER);//��ӵ�ǰ���Ÿ�����
                string depuser = null;//ѡ���û������ѷ��䲿�ŵ��û�
                List<string> listselectuserdep = new List<string>();//��ȡѡ���û��������ѷ��䲿���У��û��Ĳ���
                foreach (ListViewRow rows in gridUserData.Rows)
                {

                    if ((Convert.ToBoolean(((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue) == true) & (!department.MANAGER.Equals(((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString())))
                    {
                        string user = ((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                        listUser.Add(user);
                        //��ȡѡ���û��е��ѷ��䲿�ŵ��û�                      
                        if (string.IsNullOrEmpty(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString()) == false)
                        {
                            if (string.IsNullOrEmpty(depuser) == true)
                            {
                                depuser = ((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                            }
                            else
                            {
                                depuser += "," + ((frmDepAssignUserLayout)(rows.Control)).lblUser.BindDataValue.ToString();
                            }
                            if (listselectuserdep.Count <= 0)
                            {
                                listselectuserdep.Add(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString());//���ѡ���û��Ĳ���
                            }
                            else
                            {
                                if (listselectuserdep.Contains(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString()) == false)
                                {
                                    listselectuserdep.Add(((frmDepAssignUserLayout)(rows.Control)).lblDep.BindDisplayValue.ToString());//���ѡ���û��Ĳ���
                                }
                            }
                        }
                    }
                }
                //����ѷ��䲿�ŵ��û���Ϊ��ʱ
                if (string.IsNullOrEmpty(depuser) == false)
                {
                    string[] depusers = depuser.Split(',');
                    //��������ʱ���ж�ѡ���û��Ƿ�Ϊ���������˺��Ƿ�Ϊ�ѷ��䲿�ų�Ա
                    if (string.IsNullOrEmpty(department.DEPARTMENTID) == true)
                    {
                        foreach (string user in depusers)
                        {
                            //����ǲ��������ˣ�����ӵ������������û�depLeader�У�������ӵ��ѷ��䲿���û�assignUser��
                            if (AutofacConfig.DepartmentService.IsLeader(user) == true)
                            {
                                coreUser userd = AutofacConfig.coreUserService.GetUserByID(user);
                                if (string.IsNullOrEmpty(depLeader) == true)
                                {
                                    depLeader = userd.USER_NAME;
                                }
                                else
                                {
                                    depLeader += "," + userd.USER_NAME;
                                }

                            }
                            else
                            {
                                if (string.IsNullOrEmpty(assignUser) == true)
                                {
                                    assignUser = user;
                                }
                                else
                                {
                                    assignUser += "," + user;
                                }
                            }
                        }
                    }
                    //�༭����ʱ���ж�ѡ���û��Ƿ�Ϊ���������˺��Ƿ�Ϊ�ѷ��䲿�ų�Ա
                    if (string.IsNullOrEmpty(department.DEPARTMENTID) == false)
                    {
                        foreach (string user in depusers)
                        {
                            coreUser userd = AutofacConfig.coreUserService.GetUserByID(user);
                            if (!department.DEPARTMENTID.Equals(userd.USER_DEPARTMENTID))
                            {
                                //����ǲ��������ˣ�����ӵ������������û�depLeader�У�������ӵ��ѷ��䲿���û�assignUser��
                                if (AutofacConfig.DepartmentService.IsLeader(user) == true)
                                {

                                    if (string.IsNullOrEmpty(depLeader) == true)
                                    {
                                        depLeader = userd.USER_NAME;
                                    }
                                    else
                                    {
                                        depLeader += "," + userd.USER_NAME;
                                    }
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(assignUser) == true)
                                    {
                                        assignUser = user;
                                    }
                                    else
                                    {
                                        assignUser += "," + user;
                                    }
                                }
                            }
                        }
                    }
                    if (listselectuserdep.Count > 0 & string.IsNullOrEmpty(assignUser) == false)
                    {

                        string[] assignUsers = assignUser.Split(',');
                        string assignUser1 = "";
                        foreach (string depNO in listselectuserdep)
                        {
                            string assignU = "";
                            foreach (string user in assignUsers)
                            {
                                coreUser userd = AutofacConfig.coreUserService.GetUserByID(user);
                                if (user != null)
                                {
                                    if (userd.USER_DEPARTMENTID.Equals(depNO))
                                    {
                                        if (string.IsNullOrEmpty(assignU) == true)
                                        {
                                            assignU = userd.USER_NAME;
                                        }
                                        else
                                        {
                                            assignU += "," + userd.USER_NAME;
                                        }
                                    }
                                }
                            }
                            if (string.IsNullOrEmpty(assignU) == false)
                            {
                                if (string.IsNullOrEmpty(assignU) == false)
                                {
                                    assignUser1 = assignU + "����" + AutofacConfig.DepartmentService.GetDepartmentByDepID(depNO).NAME + "���ų�Ա";
                                }
                                else
                                {
                                    assignUser1 += "��" + assignU + "����" + AutofacConfig.DepartmentService.GetDepartmentByDepID(depNO).NAME + "���ų�Ա";
                                }
                            }
                        }
                        assignUser = assignUser1;
                    }
                }
                if (string.IsNullOrEmpty(depLeader) == false)
                {
                    throw new Exception(depLeader + "���ǲ��������ˣ����Ƚ�ɢ���ţ�");
                }
                //bool isUPdateDep = false; //�Ƿ���²�����Ա
                ReturnInfo result;
                if (string.IsNullOrEmpty(assignUser) == false)
                {
                    MessageBox.Show(assignUser + "�Ƿ���䣿", "������Ա", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                      {
                          if (args.Result == Smobiler.Core.Controls.ShowResult.Yes)
                          {
                            //isUPdateDep = true;
                            department.UserIDs = listUser;
                              if (department.DEPARTMENTID != null)
                              {

                                  result = AutofacConfig.DepartmentService.UpdateDepartment(department);
                              }
                              else
                              {

                                  result = AutofacConfig.DepartmentService.AddDepartment(department);
                              }
                              if (result.IsSuccess == false)
                              {
                                  throw new Exception(result.ErrorInfo);
                              }
                              else
                              {
                                  ShowResult = ShowResult.Yes;
                                  Close();
                                  Toast("������Ա����ɹ���", ToastLength.SHORT);
                              }
                          }
                      }
                      );
                }
                else
                {

                    department.UserIDs = listUser;
                    if (department.DEPARTMENTID != null)
                    {

                        result = AutofacConfig.DepartmentService.UpdateDepartment(department);
                    }
                    else
                    {

                        result = AutofacConfig.DepartmentService.AddDepartment(department);
                    }
                    if (result.IsSuccess == false)
                    {
                        throw new Exception(result.ErrorInfo);
                    }
                    else
                    {
                        ShowResult = ShowResult.Yes;
                        Close();
                        Toast("������Ա����ɹ���", ToastLength.SHORT);
                    }
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        /// <summary>
        /// ȫѡ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Click(object sender, EventArgs e)
        {
            if (checkAll.Checked)
            {
                checkAll.Checked = false;
            }
            else
            {
                checkAll.Checked = true;
            }
            Checkall();
        }
        /// <summary>
        /// ȫѡ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll_CheckChanged(object sender, EventArgs e)
        {
            Checkall();
        }
        ///// <summary>
        ///// ListView����¼�
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void gridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        //{
        //    upCheckState();
        //}
        /// <summary>
        /// ����ȫѡ״̬
        /// </summary>
        private void upCheckState()
        {
            selectUserQty = 0;
            foreach (ListViewRow rows in gridUserData.Rows)
            {
                if (Convert.ToBoolean(((frmDepAssignUserLayout)(rows.Control)).Check.BindDisplayValue) == true)
                {
                    selectUserQty += 1;
                }
            }
            //��ListView����ѡ����������ListView����ʱ��Ϊȫѡ״̬������Ϊ��ѡ״̬��
            if (selectUserQty == gridUserData.Rows.Count)
            {
                checkAll.Checked = true;
            }
            else
            {
                checkAll.Checked = false;
            }
        }
        ///// <summary>
        ///// ListView����¼�
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void gridView1_CellClick(object sender, GridViewCellEventArgs e)
        //{
        //    switch (Convert .ToBoolean (e.Cell.Items["Check"].DefaultValue))
        //    {
        //        case true :
        //            e.Cell.Items["Check"].DefaultValue = false;
        //            break;
        //        case false :
        //            e.Cell.Items["Check"].DefaultValue = true;
        //            break;
        //    }
        //    upCheckState();
        //}

        /// <summary>
        /// �ϴ�����ͷ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            cameraPortrait.GetPhoto();
        }

        /// <summary>
        /// ��ȡ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeader_Click(object sender, EventArgs e)
        {
            popLeader.Groups.Clear();
            PopListGroup poli = new PopListGroup();
            popLeader.Groups.Add(poli);
            poli.Title = "������ѡ��";
            List<coreUser> listuser = AutofacConfig.coreUserService.GetAll();
            foreach (coreUser user in listuser)
            {
                poli.AddListItem(user.USER_NAME, user.USER_ID);
                if (string.IsNullOrEmpty(department.MANAGER) == false)
                {
                    if (department.MANAGER.Trim().Equals(user.USER_ID))
                    {
                        popLeader.SetSelections(poli.Items[(poli.Items.Count - 1)]);
                    }
                }
            }
            popLeader.Show();
        }
        /// <summary>
        /// �����˸�ֵ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popLeader_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popLeader.Selection != null)
                {
                    //��ѯ��ѡ�е��û��Ƿ��Ѿ��ǲ���������
                    bool isLeader = AutofacConfig.DepartmentService.IsLeader(popLeader.Selection.Value);
                    //�����ѡ�����������ǲ��������ˣ��򱨴�
                    if (isLeader == true)
                    {
                        throw new Exception(popLeader.Selection.Text + "���ǲ��������ˣ����Ƚ�ɢ���ţ�");
                    }
                    //
                    UserDepDto userdep = AutofacConfig.coreUserService.GetUseDepByUserID(popLeader.Selection.Value);
                    //���ѡ���û����ǲ��ų�Ա�Ҳ��ǲ��������ˣ������ѡ���Ƿ�ȷ��Ϊ���������ˣ���ȷ����Ϊ�ò��Ÿ�����
                    if (userdep != null & string.IsNullOrEmpty(userdep.DEPARTMENTID) == false & isLeader == false)
                        //if (AutofacConfig.userService.GetAllUsers().Count > 0 & isLeader== false)
                        //{
                        MessageBox.Show(popLeader.Selection.Text + "���ǲ��ų�Ա���Ƿ�ȷ��Ϊ�ò��������ˣ�", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs args) =>
                        {
                            //��ί��Ϊ�첽ί���¼�
                            if (args.Result == Smobiler.Core.Controls.ShowResult.Yes)
                            {
                                department.MANAGER = popLeader.Selection.Value;
                                btnLeader.Text = popLeader.Selection.Text + "   > ";
                            }
                        });
                    //}
                    //���ѡ���û����ǲ����������Ҳ��ǲ��ų�Ա����Ϊ�ò��Ÿ�����
                    if (isLeader == false & userdep != null & string.IsNullOrEmpty(userdep.DEPARTMENTID) == true)
                    {
                        department.MANAGER = popLeader.Selection.Value;
                        btnLeader.Text = popLeader.Selection.Text + "   > ";
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
            }
        }

        /// <summary>
        /// ���沢��ֵͷ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cameraPortrait_ImageCaptured(object sender, BinaryResultArgs e)
        {
            if (string.IsNullOrEmpty(e.error))
            {

                if (imgPortrait.ResourceID.Trim().Length > 0 & string.IsNullOrEmpty(department.IMAGEID) == false)
                {
                    e.SaveFile(department.IMAGEID + ".png");
                    imgPortrait.ResourceID = department.IMAGEID;
                    imgPortrait.Refresh();
                }
                else
                {
                    e.SaveFile(e.ResourceID + ".png");
                    department.IMAGEID = e.ResourceID;
                    imgPortrait.ResourceID = e.ResourceID;
                    imgPortrait.Refresh();
                }
            }
        }
    }
}
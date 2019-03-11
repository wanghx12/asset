using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.Domain.Entity;
using System.Data;
using SMOSEC.CommLib;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmmachine_room : Smobiler.Core.Controls.MobileForm
    {
        public frmmachine_room() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        #region "definition"
        AutofacConfig AutofacConfig = new AutofacConfig();//调用配置类
        public DataTable AssTable = new DataTable();
        public List<string> AssIdList = new List<string>();
        #endregion

        /// <summary>
        /// 初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartment_Load(object sender, EventArgs e)
        {
            if (AssTable.Columns.Count == 0)
            {
                AssTable.Columns.Add("NAME");
            }
            DataColumn[] keys = new DataColumn[1];
            keys[0] = AssTable.Columns["NAME"];
            AssTable.PrimaryKey = keys;

            Bind();
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        public void Bind()
        {
            try
            {
                //获取所有部门数据
                List<cmdb_machineroom> listUser = AutofacConfig.DepartmentService.GetAll();
                foreach (cmdb_machineroom user in listUser)
                {
                    DataRow row = AssTable.NewRow();
                    row["NAME"] = user.name;
                    AssTable.Rows.Add(row);
                    AssIdList.Add(user.name);
                }

                gridDepData.DataSource = AssTable;
                gridDepData.DataBind();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDepartment_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }
        /// <summary>
        /// 跳转到创建部门界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (AssIdList.Contains(txtcreate.Text))
                {
                    throw new Exception("该机房已经在列表中!");
                }
                string dealman = Client.Session["local_username"].ToString();
                ReturnInfo returnInfo = AutofacConfig.DepartmentService.Addmachine_room(txtcreate.Text, dealman);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("添加成功");
                    Close();
                }
                else
                {
                    Toast(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
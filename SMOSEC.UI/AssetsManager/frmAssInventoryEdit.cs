using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;

namespace SMOSEC.UI.AssetsManager
{
    /// <summary>
    /// �̵㵥�༭����
    /// </summary>
    partial class frmAssInventoryEdit : Smobiler.Core.Controls.MobileForm
    {
        #region  �������
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������

        public string LocationId;
        public string HManId;
        private string UserId;
        public string typeId;
        public string DepId;
        public string IID;
        #endregion
        /// <summary>
        /// �����޸�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                AddAIResultInputDto assInventoryInput = new AddAIResultInputDto()
                {
                    IID = IID,
                    HANDLEMAN = HManId,
                    LocationId = LocationId,
                    typeId = typeId,
                    DepartmentId = DepId,
                    UserId = UserId,
                    Name = txtName.Text
                };
                ReturnInfo returnInfo = _autofacConfig.AssInventoryService.UpdateInventoryOnly(assInventoryInput);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("�޸ĳɹ�");
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

        /// <summary>
        /// ѡ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocation_Press(object sender, EventArgs e)
        {
            try
            {
                popLocation.Groups.Clear();
                PopListGroup locationGroup = new PopListGroup {Title = "����ѡ��"};
                List<AssLocation> locations = _autofacConfig.assLocationService.GetAll();
                foreach (var location in locations)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = location.LOCATIONID,
                        Text = location.NAME
                    };
                    locationGroup.Items.Add(item);
                }
                popLocation.Groups.Add(locationGroup);

                if (!string.IsNullOrEmpty(LocationId))
                {
                    foreach (PopListItem row in popLocation.Groups[0].Items)
                    {
                        if (row.Value == LocationId)
                        {
                            popLocation.SetSelections(row);
                        }
                    }
                }
                popLocation.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ѡ���̵���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManager_Press(object sender, EventArgs e)
        {
            try
            {
                popMan.Groups.Clear();
                PopListGroup manGroup = new PopListGroup { Title = "�̵���ѡ��" };
                List<coreUser> users = _autofacConfig.coreUserService.GetAll();
                foreach (coreUser Row in users)
                {
                    manGroup.AddListItem(Row.USER_NAME, Row.USER_ID);
                }
                popMan.Groups.Add(manGroup);
                if (!string.IsNullOrEmpty(HManId))   //�������ѡ�������ʾѡ��Ч��
                {
                    foreach (PopListItem Item in manGroup.Items)
                    {
                        if (Item.Value == HManId)
                            popMan.SetSelections(Item);
                    }
                }
                popMan.ShowDialog();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ѡ���ʲ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnType_Press(object sender, EventArgs e)
        {
            try
            {
                popType.Groups.Clear();
                PopListGroup typeGroup = new PopListGroup { Title = "�ʲ�����" };
                var typelist = _autofacConfig.assTypeService.GetAll();
                PopListItem first = new PopListItem
                {
                    Text = "ȫ��",
                    Value = ""
                };
                typeGroup.Items.Add(first);
                foreach (var type in typelist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = type.TYPEID,
                        Text = type.NAME
                    };
                    typeGroup.Items.Add(item);
                }
                popType.Groups.Add(typeGroup);
                if (!string.IsNullOrEmpty(typeId))
                {
                    foreach (PopListItem row in popType.Groups[0].Items)
                    {
                        if (row.Value == typeId)
                        {
                            popType.SetSelections(row);
                        }
                    }
                }
                popType.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ѡ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDep_Press(object sender, EventArgs e)
        {
            try
            {
                popDep.Groups.Clear();
                PopListGroup depGroup = new PopListGroup { Title = "����" };
                var deplist = _autofacConfig.DepartmentService.GetAllDepartment();
                PopListItem first = new PopListItem
                {
                    Text = "ȫ��",
                    Value = ""
                };
                depGroup.Items.Add(first);
                foreach (var dep in deplist)
                {
                    PopListItem item = new PopListItem
                    {
                        Value = dep.DEPARTMENTID,
                        Text = dep.NAME
                    };
                    depGroup.Items.Add(item);
                }
                popDep.Groups.Add(depGroup);
                if (!string.IsNullOrEmpty(DepId))
                {
                    foreach (PopListItem row in popDep.Groups[0].Items)
                    {
                        if (row.Value == DepId)
                        {
                            popDep.SetSelections(row);
                        }
                    }
                }
                popDep.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ��ʼ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssInventoryEdit_Load(object sender, EventArgs e)
        {
            try
            {
                UserId = Client.Session["UserID"].ToString();

                var assInventory = _autofacConfig.AssInventoryService.GetAssInventoryById(IID);
                txtName.Text = assInventory.NAME;
                btnManager.Text=assInventory.HANDLEMANNAME+ "   > ";
                if (string.IsNullOrEmpty(assInventory.DEPARTMENTID))
                {
                    btnDep.Text = "ȫ��   > ";
                }
                else
                {
                    btnDep.Text=assInventory.DEPARTMENTNAME + "   > ";
                }
                if (string.IsNullOrEmpty(assInventory.TYPEID))
                {
                    btnType.Text= "ȫ��   > ";
                }
                else
                {
                    btnType.Text=assInventory.TYPENAME + "   > ";
                }
                btnLocation.Text=assInventory.LOCATIONNAME + "   > ";                
                HManId = assInventory.HANDLEMAN;
                DepId = assInventory.DEPARTMENTID;
                LocationId = assInventory.LOCATIONID;
                typeId = assInventory.TYPEID;
                if (Client.Session["Role"].ToString() == "SMOSECAdmin")
                {
                    var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                    LocationId = user.USER_LOCATIONID;
                    var location = _autofacConfig.assLocationService.GetByID(LocationId);
                    if (location != null) btnLocation.Text = location.NAME;
                    btnLocation.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ѡ���̵��˺�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popMan_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popMan.Selection != null)
                {
                    btnManager.Text = popMan.Selection.Text + "   > ";
                    HManId = popMan.Selection.Value;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ѡ�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popLocation_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popLocation.Selection != null)
                {
                    btnLocation.Text = popLocation.Selection.Text + "   > ";
                    LocationId = popLocation.Selection.Value;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ѡ���ʲ����ͺ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popType_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popType.Selection != null)
                {
                    btnType.Text = popType.Selection.Text + "   > ";
                    typeId = popType.Selection.Value;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ѡ�в��ź�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popDep_Selected(object sender, EventArgs e)
        {
            try
            {
                if (popDep.Selection != null)
                {
                    btnDep.Text = popDep.Selection.Text + "   > ";
                    DepId = popDep.Selection.Value;
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.CommLib;
using SMOSEC.DTOs.Enum;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.UI.AssetsManager;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssInventoryLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������
        
        /// <summary>
        /// �༭�̵㵥
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Press(object sender, EventArgs e)
        {
            try
            {
                frmAssInventoryEdit edit = new frmAssInventoryEdit {IID = lblName.BindDataValue.ToString() };
                Form.Show(edit, (MobileForm sender1, object args) =>
                    {
                        if (edit.ShowResult == ShowResult.Yes)
                        {
                            ((frmAssInventory)Form).Bind();
                        }

                    }
                );
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ɾ���̵㵥
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Press(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("��ȷ��Ҫ���̵㵥��?", "ϵͳ����", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.OK)     //ɾ�����̵㵥
                        {
                            ReturnInfo rInfo = _autofacConfig.AssInventoryService.DeleteInventory(lblName.BindDataValue.ToString());
                            if (rInfo.IsSuccess)
                            {
                                Toast("ɾ���̵㵥�ɹ�.");
                                ((frmAssInventory)Form).Bind();
                            }
                            else
                            {
                                throw new Exception(rInfo.ErrorInfo);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Form.Toast(ex.Message);
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ��ʼ�̵�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Press(object sender, EventArgs e)
        {
            try
            {
                AddAIResultInputDto inputDto = new AddAIResultInputDto {IID = lblName.BindDataValue.ToString() };
                var inventory=_autofacConfig.AssInventoryService.GetAssInventoryById(lblName.BindDataValue.ToString());
                ReturnInfo returnInfo = _autofacConfig.AssInventoryService.AddAssInventoryResult(inputDto);
                if (returnInfo.IsSuccess)
                {
                    frmAssInventory assets = (frmAssInventory)Form;
                    assets.Bind();
                    frmAssInventoryResult result = new frmAssInventoryResult {IID = lblName.BindDataValue.ToString(), LocationId = inventory.LOCATIONID,DepartmentId = inventory.DEPARTMENTID,typeId = inventory.TYPEID};
                    assets.Show(result, (MobileForm sender1, object args) =>
                    {
                        if (result.ShowResult == ShowResult.Yes|| result.ShowResult == ShowResult.None)
                        {
                            assets.Bind();
                        }
                    });
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
        /// ������鿴�̵㵥����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Press(object sender, EventArgs e)
        {
            try
            {
                var inventory = _autofacConfig.AssInventoryService.GetAssInventoryById(lblName.BindDataValue.ToString());
                frmAssInventoryResult result = new frmAssInventoryResult { IID = lblName.BindDataValue.ToString(), LocationId = inventory.LOCATIONID, DepartmentId = inventory.DEPARTMENTID, typeId = inventory.TYPEID};
                frmAssInventory assets = (frmAssInventory)Form;

                assets.Show(result, (MobileForm sender1, object args) =>
                {
                    if (result.ShowResult == ShowResult.Yes|| result.ShowResult == ShowResult.None)
                    {
                        assets.Bind();
                    }

                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    
    }
}
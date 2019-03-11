using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.UI.ConsumablesManager;
using SMOSEC.CommLib;
using SMOSEC.DTOs.InputDTO;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConInventoryLayout : Smobiler.Core.Controls.MobileUserControl
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
                frmConInventoryEdit edit = new frmConInventoryEdit { IID = lblName.BindDataValue.ToString() };
                Form.Show(edit, (MobileForm sender1, object args) =>
                {
                    if (edit.ShowResult == ShowResult.Yes)
                    {
                        ((frmConInventory)Form).Bind();
                    }

                }
                );
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
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
                            ReturnInfo rInfo = _autofacConfig.ConInventoryService.DeleteInventory(lblName.BindDataValue.ToString());
                            if (rInfo.IsSuccess)
                            {
                                Toast("ɾ���̵㵥�ɹ�.");
                                ((frmConInventory)Form).Bind();
                            }
                            else
                            {
                                Toast(rInfo.ErrorInfo);
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
                Form.Toast(ex.Message);
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
                AddCIResultInputDto inputDto = new AddCIResultInputDto { IID = lblName.BindDataValue.ToString() };
                var inventory = _autofacConfig.ConInventoryService.GetConInventoryById(lblName.BindDataValue.ToString());
                ReturnInfo returnInfo = _autofacConfig.ConInventoryService.AddConInventoryResult(inputDto);
                if (returnInfo.IsSuccess)
                {
                    //((frmConInventory)Form).Bind();
                    frmConInventoryResult result = new frmConInventoryResult();
                    result.IID = lblName.BindDataValue.ToString();
                    result.LocationId = inventory.LOCATIONID;
                    Form.Show(result, (MobileForm sender1, object args) =>
                    {
                        if (result.ShowResult == ShowResult.Yes)
                        {
                            ((frmConInventory)Form).Bind();
                        }
                        else if (result.ShowResult == ShowResult.None)
                        {
                            ((frmConInventory)Form).Bind();
                        }
                    });
                }
                else
                {
                    throw new Exception(returnInfo.ErrorInfo);
                }

            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// ���������ת�鿴����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            try
            {
                var inventory = _autofacConfig.ConInventoryService.GetConInventoryById(lblName.BindDataValue.ToString());
                frmConInventoryResult result = new frmConInventoryResult { IID = lblName.BindDataValue.ToString(), LocationId = inventory.LOCATIONID };
                Form.Show(result, (MobileForm sender1, object args) =>
                {
                    if (result.ShowResult == ShowResult.Yes)
                    {
                        ((frmConInventory)Form).Bind();
                    }
                    else if (result.ShowResult == ShowResult.None)
                    {
                        ((frmConInventory)Form).Bind();
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.CommLib;
using SMOSEC.DTOs.Enum;
using SMOSEC.UI.MasterData;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmLcoationRowsLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//����������
        #endregion
        /// <summary>
        /// �Ե�ǰ����������б༭��ɾ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plEdit_Press(object sender, EventArgs e)
        {
            frmLocationRowsButtonLayout frm = new frmLocationRowsButtonLayout();
            frm.ID = lblName.BindDataValue.ToString();     //������
            frm.LocName = lblName.BindDisplayValue.ToString();      //��������
            DialogOptions dialog = new DialogOptions();
            dialog.JustifyAlign = LayoutJustifyAlign.FlexEnd;
            dialog.Padding = new Padding(0);
            this.Form.ShowDialog(frm,dialog);
        }
        public void setColor()
        {
            if (lblEnable.Text == "����")
            {
                lblEnable.ForeColor = System.Drawing.Color.DodgerBlue;
            }
            else
            {
                lblEnable.ForeColor = System.Drawing.Color.Red;
            }
        }
        /// <summary>
        /// ���û��߽�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plEnable_Press(object sender, EventArgs e)
        {
            if (lblEnable.Text == "����")
            {
                MessageBox.Show("��ȷ��Ҫ���ø�������?", "ϵͳ����", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.OK)     //���ø�����
                        {
                            ReturnInfo r = autofacConfig.assLocationService.ChangeEnable(lblName.BindDataValue.ToString(),IsEnable.����);
                            if (r.IsSuccess == true)
                            {
                                this.Form.Toast("�������óɹ�");
                                ((frmLocationRows)Form).Bind();      //ˢ������
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
                });
            }
            else
            {
                MessageBox.Show("��ȷ��Ҫ���ø�������?", "ϵͳ����", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.OK)     //���ø�����
                        {
                            ReturnInfo r = autofacConfig.assLocationService.ChangeEnable(lblName.BindDataValue.ToString(), IsEnable.����);
                            if (r.IsSuccess == true)
                            {
                                this.Form.Toast("������óɹ�");
                                ((frmLocationRows)Form).Bind();      //ˢ������
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
                });
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.UI.AssetsManager;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class OperCreateAssLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ������ɾ���ʲ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel1_LongPress(object sender, EventArgs e)
        {
            //try
            //{
            //                    MobileMessageBox messageBox=new MobileMessageBox(this.Form);
            //                    messageBox.Show("�Ƿ�ɾ�����ʲ���",MessageBoxButtons.YesNo, (object s1, MessageBoxHandlerArgs args) =>
            //                    {
            //                        try
            //                        {
            //                            if (args.Result == ShowResult.Yes)
            //                            {
            //                                switch (LblType.BindDataValue.ToString())
            //                                {
            //                                    case "CO":
            //                                        frmCoCreate coCreate = (frmCoCreate) this.Form;
            //                                        coCreate.RemoveAss(lblASSID.Text);
            //                                        coCreate.BindListView();
            //                                        break;
            //                                    case "BO":
            //                                        frmBoCreate boCreate = (frmBoCreate) this.Form;
            //                                        boCreate.RemoveAss(lblASSID.Text);
            //                                        boCreate.BindListView();
            //                                        break;
            //                                    case "RTO":
            //                                        frmRtoCreate rtoCreate = (frmRtoCreate) this.Form;
            //                                        rtoCreate.RemoveAss(lblASSID.Text);
            //                                        rtoCreate.BindListView();
            //                                        break;
            //                                    case "RSO":
            //                                        frmRsoCreate rsoCreate = (frmRsoCreate) this.Form;
            //                                        rsoCreate.RemoveAss(lblASSID.Text);
            //                                        rsoCreate.BindListView();
            //                                        break;
            //                                }
            //                            }
            //                        }
            //                        catch (Exception ex)
            //                        {
            //                            Parent.Form.Toast(ex.Message);
            //                        }
            //                    });
            //}
            //catch (Exception ex)
            //{
            //    Form.Toast(ex.Message);
            //}
        }
    }
}
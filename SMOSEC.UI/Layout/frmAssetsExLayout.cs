using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.CommLib;
using SMOSEC.UI.MasterData;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.Domain.Entity;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsExLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������

        /// <summary>
        /// �����������ʲ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void touchPanel1_Press(object sender, EventArgs e)
        {
            try
            {
                frmAssetsDetail detail = new frmAssetsDetail { SN = lblSN.BindDataValue.ToString() };
                Form.Show(detail, (MobileForm sender1, object args) =>
                    {
                        if (detail.ShowResult == ShowResult.Yes)
                        {
                            ((frmAssets)Form).Bind();
                        }

                    }
                );
            }
            catch (Exception ex)
            {
                Parent.Form.Toast(ex.Message);
            }
        }

        /// <summary>
        /// CheckBox�ı�ѡ��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ((frmAssets)Form).SelectAssId = checkBox1.Checked ? lblSN.Text : "";
                ((frmAssets)Form).Bind();
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}
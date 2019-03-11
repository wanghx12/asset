using System;
using Smobiler.Core.Controls;
using SMOSEC.UI.AssetsManager;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmScrapRowsLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ����鿴���ϵ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plContent_Press(object sender, EventArgs e)
        {
            try
            {
                    frmScrapDetailSN frm = new frmScrapDetailSN();
                    frm.SOID = lblID.BindDataValue.ToString();
                    Form.Show(frm, (MobileForm sender1, object args) => {
                        if (frm.ShowResult == ShowResult.Yes)
                        {
                            ((frmScrapRowsSN)Form).Bind();        //���°�����
                        }
                    });
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}
using System;
using Smobiler.Core.Controls;
using SMOSEC.UI.AssetsManager;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmRepairRowsLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ����鿴���޵�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plContent_Press(object sender, EventArgs e)
        {
            try
            {
                    frmRepairDetailSN frm = new frmRepairDetailSN();
                    frm.ROID = int.Parse(lblID.BindDataValue.ToString());
                    Form.Show(frm, (MobileForm sender1, object args) => {
                        if (frm.ShowResult == ShowResult.Yes)
                        {
                            ((frmRepairRowsSN)Form).Bind();        //���°�����
                        }
                    });
            }
            catch(Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}
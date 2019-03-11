using System;
using Smobiler.Core.Controls;
using SMOSEC.UI.AssetsManager;
using SMOSEC.UI.ConsumablesManager;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmTransferRowsLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// �鿴����������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plContent_Press(object sender, EventArgs e)
        {
            try
            {
                if (Form.ToString() == "SMOSEC.UI.AssetsManager.frmTransferRowsSN")
                {
                    frmTransferDetailSN frm = new frmTransferDetailSN();
                    frm.TOID = lblID.BindDataValue.ToString();
                    Form.Show(frm, (MobileForm sender1, object args) => {
                        if (frm.ShowResult == ShowResult.Yes)
                        {
                            ((frmTransferRowsSN)Form).Bind();        //���°�����
                        }
                    });             
                }
                else if (Form.ToString() == "SMOSEC.UI.ConsumablesManager.frmTransferRows")
                {
                    frmTransferDetail frm = new frmTransferDetail();
                    frm.TOID = lblID.BindDataValue.ToString();
                    Form.Show(frm, (MobileForm sender1, object args) => {
                        if (frm.ShowResult == ShowResult.Yes)
                        {
                            ((frmTransferRows)Form).Bind();        //���°�����
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}
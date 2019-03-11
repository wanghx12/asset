using System;
using SMOSEC.UI.ConsumablesManager;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConsumablesLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ������鿴�Ĳ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void touchPanel1_Press(object sender, EventArgs e)
        {
            try
            {
                frmConsumablesDetail consumablesDetail = new frmConsumablesDetail {CID = lblID.BindDataValue.ToString()};
                Form.Show(consumablesDetail, (MobileForm sender1, object args) =>
                {
                    if (consumablesDetail.ShowResult == ShowResult.Yes)
                    {
                        ((frmConsumables)Form).Bind();
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
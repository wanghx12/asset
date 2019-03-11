using System;
using Smobiler.Core.Controls;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.UI.AssetsManager;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmOrderCreateSNLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// �õ�ѡ��������
        /// </summary>
        /// <returns></returns>
        //public AssetsOrderRow getData()
        //{
        //    AssetsOrderRow Data = new AssetsOrderRow();
        //    Data.IMAGE = imgAss.BindDisplayValue.ToString();
        //    Data.ASSID = lblName.BindDataValue.ToString();
        //    Data.SN = lblSN.BindDataValue.ToString();
        //    Data.QTY = 1;
        //    //Data.LOCATIONID = lblLocation.BindDataValue.ToString();
        //    Data.STATUS = 0;
        //    return Data;
        //}
        private void plRow_LongPress(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("�Ƿ�ɾ��������?", "ϵͳ����", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.Yes)     //ɾ��������
                        {
                            switch (Form.ToString())
                            {
                                case "SMOSEC.UI.AssetsManager.frmRepairCreateSN":
                                    ((frmRepairCreateSN)Form).ReMoveAssSN(lblName.BindDataValue.ToString(), lblSN.BindDataValue.ToString());
                                    break;
                                //case "SMOSEC.UI.AssetsManager.frmScrapCreateSN":
                                //    ((frmScrapCreateSN)Form).ReMoveAssSN(lblName.BindDataValue.ToString(), lblSN.BindDataValue.ToString());
                                //    break;
                                //case "SMOSEC.UI.AssetsManager.frmTransferCreateSN":
                                //    ((frmTransferCreateSN)Form).ReMoveAssSN(lblName.BindDataValue.ToString(), lblSN.BindDataValue.ToString());
                                //    break;
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
    }
}
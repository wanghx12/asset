using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.UI.AssetsManager;
using SMOSEC.UI.ConsumablesManager;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmOrderCreateLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ��ȡѡ��������
        /// </summary>
        /// <returns></returns>
        public ConsumablesOrderRow getData()
        {
            if (numNumber.Value == 0) throw new Exception("ѡ����������Ϊ0!");
            ConsumablesOrderRow Data = new ConsumablesOrderRow();
            Data.IMAGE = imgAss.BindDisplayValue.ToString();
            Data.CID = lblName.BindDataValue.ToString();
            Data.QTY = Convert.ToDecimal(numNumber.Value);
            Data.LOCATIONID = lblLocation.BindDataValue.ToString();
            Data.STATUS = 0;
            return Data;
        }
        /// <summary>
        /// ����ɾ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            ((frmTransferCreate)Form).ReMoveAss(lblName.BindDataValue.ToString());
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
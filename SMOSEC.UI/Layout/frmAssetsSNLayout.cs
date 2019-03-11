using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.UI.AssetsManager;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.UI.ConsumablesManager;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssetsSNLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ����ѡ��״̬
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            ((frmTransferConsChoose)Form).upCheckState();       //����ȫѡ��״̬
        }
        /// <summary>
        /// ��ȡ��ǰ���Ƿ�ѡ��
        /// </summary>
        /// <returns></returns>
        public Int32 checkNum()
        {
            if (Check.Checked)
                return 1;
            else
                return 0;
        }
        public AssetsOrderRow getData()
        {
            AssetsOrderRow Data = new AssetsOrderRow();
            if (Check.Checked)
            {
                Data.IMAGE = imgAss.BindDisplayValue.ToString();
                Data.ASSID = lblName.BindDataValue.ToString();
                Data.SN = lblSN.BindDataValue.ToString();
                Data.QTY = 1;
                Data.LOCATIONID = lblLocation.BindDataValue.ToString();
                Data.STATUS = 0;
                return Data;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// ����ÿ��CheckBox״̬
        /// </summary>
        /// <param name="state"></param>
        public void setCheck(Boolean state)
        {
            Check.Checked = state;
        }
        /// <summary>
        /// ���ѡ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            if (Check.Checked)
                Check.Checked = false;
            else
                Check.Checked = true;
            ((frmTransferConsChoose)Form).upCheckState();
        }
    }
}
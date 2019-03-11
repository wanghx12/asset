using System;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SMOSEC.UI.AssetsManager;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssSNTDLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ����޸�ѡ��״̬
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plRow_Press(object sender, EventArgs e)
        {
            if (Check.Checked)
                Check.Checked = false;
            else
                Check.Checked = true;
            ((frmTransferDealSN)Form).upCheckState();
        }
        /// <summary>
        /// ����ѡ��״̬
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            ((frmTransferDealSN)Form).upCheckState();
        }
        /// <summary>
        /// ��ȡ��������
        /// </summary>
        /// <returns></returns>
        public AssTransferOrderRow getData()
        {
            if (Check.Checked)
            {
                AssTransferOrderRow Data = new AssTransferOrderRow();
                Data.TOROWID = Check.BindDataValue.ToString();
                Data.IMAGE = imgAss.BindDisplayValue.ToString();
                Data.ASSID = lblName.BindDataValue.ToString();
                Data.SN = lblSN.BindDataValue.ToString();
                if (((frmTransferDealSN)Form).Type == PROCESSMODE.����ȷ��)
                {
                    Data.TRANSFEREDQTY = 1;
                    Data.STATUS = 1;
                }
                else
                {
                    Data.TRANSFERCANCELQTY = 1;
                    Data.STATUS = 2;
                }
                return Data;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// ��ȡ��ǰ���Ƿ�ѡ��
        /// </summary>
        /// <returns></returns>
        public int checkNum()
        {
            if (Check.Checked)
                return 1;
            else
                return 0;
        }
        /// <summary>
        /// ����CheckBox״̬
        /// </summary>
        /// <param name="state"></param>
        public void setCheck(Boolean state)
        {
            Check.Checked = state;
        }
    }
}
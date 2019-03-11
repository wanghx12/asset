using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.UI.AssetsManager;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;
using SMOSEC.UI.ConsumablesManager;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssTDLayout : Smobiler.Core.Controls.MobileUserControl
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
            ((frmTransferDeal)Form).upCheckState();
        }
        /// <summary>
        /// �õ�ѡ��������
        /// </summary>
        public AssTransferOrderRow getData()
        {
            if (Check.Checked == true)
            {
                if (numNumber.Value > Convert.ToDouble(lblNumber.BindDataValue))
                {
                    if (((frmTransferDeal)Form).Type == PROCESSMODE.����ȷ��)
                        throw new Exception("ȷ���������ܳ�����������!");
                    else
                        throw new Exception("ȡ���������ܳ�����������!");
                } 
                AssTransferOrderRow Data = new AssTransferOrderRow();
                Data.TOROWID = Check.BindDataValue.ToString();
                Data.IMAGE = imgAss.BindDisplayValue.ToString();
                Data.CID = lblName.BindDataValue.ToString();
                if(((frmTransferDeal)Form).Type == PROCESSMODE.����ȷ��)
                {
                    Data.STATUS = 1;
                    if (numNumber.Value == 0)
                        Data.TRANSFEREDQTY = Convert.ToDecimal(lblNumber.BindDataValue);
                    else
                        Data.TRANSFEREDQTY = Convert.ToDecimal(numNumber.Value);
                }
                else
                {
                    Data.STATUS = 2;
                    if (numNumber.Value == 0)
                        Data.TRANSFERCANCELQTY = Convert.ToDecimal(lblNumber.BindDataValue);
                    else
                        Data.TRANSFERCANCELQTY = Convert.ToDecimal(numNumber.Value);
                }              
                Data.LOCATIONID = lblLocation.BindDataValue.ToString();
                return Data;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// ����ѡ��״̬
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            ((frmTransferDeal)Form).upCheckState();
        }
        /// <summary>
        /// ��ȡ��ǰ���Ƿ�ѡ��
        /// </summary>
        public Int32 checkNum()
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
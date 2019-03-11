using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.UI.ConsumablesManager;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmCIResultTotalLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region �������
        public String CID;       //�Ĳı��
        #endregion
        /// <summary>
        /// ȡ���������رյ�ǰ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Press(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// ȷ�����������������̵�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtRealAmount.Text)) throw new Exception("ʵ����������Ϊ��!");
                if (System.Text.RegularExpressions.Regex.IsMatch(txtRealAmount.Text.Trim(), "^\\d+$")==false){
                    throw new Exception("����������!");
                }
                this.Close();          //�رյ�ǰ������
                ((frmConInventoryResult)Form).AddConToDictionary(CID, Convert.ToDecimal(txtRealAmount.Text));
            }
            catch(Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}
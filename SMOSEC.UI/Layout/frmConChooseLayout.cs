using System;
using SMOSEC.UI.ConsumablesManager;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmConChooseLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                frmConsumablesChoose source = (frmConsumablesChoose)this.Form;
                if (CheckBox1.Checked)
                {
                    decimal Quantity;
                    if (numeric1.Value >= 0)
                    {
                        Quantity = decimal.Parse(numeric1.Value.ToString());
                    }
                    else
                    {
                        throw new Exception("��������");
                    }
                    decimal Money;
                    if (numeric1.Value >= 0)
                    {
                        Money = decimal.Parse(numeric2.Value.ToString());
                    }
                    else
                    {
                        throw new Exception("�������");
                    }

//                    source.AddCon(LblCId.BindDataValue.ToString(),0,Quantity, Money,Image.ResourceID, lblName.BindDataValue.ToString());
                }
                else
                {
//                    source.RemoveCon(LblCId.BindDataValue.ToString());
                }
                source.UpdateCheckState();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
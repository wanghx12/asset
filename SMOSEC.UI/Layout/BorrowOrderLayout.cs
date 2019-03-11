using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMOSEC.UI.AssetsManager;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.DTOs.OutputDTO;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class BorrowOrderLayout : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        bool expired_flag;
        /// <summary>
        /// 点击，查看借用单详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel1_Press(object sender, EventArgs e)
        {
            try
            {
                AssBorrowOrderOutputDto assBorrowOrderOutput = _autofacConfig.AssetsService.GetBobyId(int.Parse(LblID.BindDataValue.ToString()));
                if (assBorrowOrderOutput.expired == 0)
                {
                    expired_flag = true;
                    throw new Exception("该表单已过期！");
                }
                frmBoDetail boDetail = new frmBoDetail { BoId = int.Parse(LblID.BindDataValue.ToString()) };
                Form.Show(boDetail);
            }
            catch (Exception ex)
            {
                if (expired_flag)
                {
                    Toast(ex.Message);
                }
                else
                {
                    Parent.Form.Toast(ex.Message);
                }
            }
        }
    }
}
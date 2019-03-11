using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
//using SMOSEC.CommLib;
using SMOSEC.UI.AssetsManager;
//using SMOSEC.UI.Menu;
using SMOSEC.CommLib;
//using SMOWMS.UI.AssetsManager;
//using SMOWMS.UI.Menu;
//using SMOWMS.DTOs.OutputDTO;
//using SMOWMS.DTOs.Enum;
//using SMOWMS.UI.MasterData;


namespace SMOSEC.UI.Layout
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class snDelete : Smobiler.Core.Controls.MobileUserControl
    {
        private AutofacConfig autofacConfig = new AutofacConfig();//调用配置类
        public snDelete() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void btnDelRow_Press(object sender, EventArgs e)
        {
            switch (Parent.Parent.Form.ToString())
            {
                case "SMOSEC.UI.AssetsManager.frmBoDetail":
                    MessageBox.Show("你确定要归还该资产吗?", "系统提醒", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                    {
                        try
                        {
                            if (args.Result == ShowResult.OK)     //借用单中删除该资产
                            {
                                ((frmBoDetail)Form).RemoveAss(((OperCreateAssLayout)Parent.Parent).LblSN.Text);
                                //Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            Form.Toast(ex.Message);
                        }
                    });
                    break;
            }
        }

    }
}
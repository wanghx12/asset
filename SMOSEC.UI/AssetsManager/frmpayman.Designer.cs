using System;
using Smobiler.Core;
namespace SMOSEC.UI.AssetsManager
{
    partial class frmpayman : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.gridDepData = new Smobiler.Core.Controls.ListView();
            this.btnCreate = new Smobiler.Core.Controls.Button();
            this.MenuTitle1 = new SMOSEC.UI.UserControl.MenuTitle();
            this.txtcreate = new Smobiler.Core.Controls.TextBox();
            this.Panel2 = new Smobiler.Core.Controls.Panel();
            // 
            // gridDepData
            // 
            this.gridDepData.BackColor = System.Drawing.Color.White;
            this.gridDepData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDepData.Location = new System.Drawing.Point(2, 95);
            //this.gridDepData.Margin = new Smobiler.Core.Controls.Margin(0F, 20F, 0F, 0F);
            this.gridDepData.Name = "gridDepData";
            this.gridDepData.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridDepData.PageSizeTextSize = 11F;
            this.gridDepData.ShowSplitLine = true;
            this.gridDepData.Size = new System.Drawing.Size(300, 270);
            this.gridDepData.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridDepData.TemplateControlName = "wangLayout";
            this.gridDepData.ZIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnCreate.BorderRadius = 2;
            this.btnCreate.Location = new System.Drawing.Point(220, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(60, 35);
            this.btnCreate.Text = "新增";
            this.btnCreate.Press += new System.EventHandler(this.btnCreate_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnCreate,
            this.txtcreate});
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 468);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(300, 35);
            // 
            // txtcreate
            // 
            //this.txtcreate.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            //this.txtcreate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtcreate.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtcreate.Location = new System.Drawing.Point(0, 4);
            this.txtcreate.Name = "txtcreate";
            this.txtcreate.Size = new System.Drawing.Size(210, 35);
            this.txtcreate.WaterMarkText = "(请输入)";
            // 
            // MenuTitle1
            // 
            this.MenuTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.MenuTitle1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.MenuTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTitle1.FontSize = 15F;
            this.MenuTitle1.ForeColor = System.Drawing.Color.Black;
            this.MenuTitle1.Location = new System.Drawing.Point(111, 36);
            this.MenuTitle1.Name = "MenuTitle1";
            this.MenuTitle1.Size = new System.Drawing.Size(100, 40);
            this.MenuTitle1.TitleText = "使用人";
            // 
            // frmDepartment
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.MenuTitle1,
            this.Panel2,
            this.gridDepData});
            this.DrawerName = "LeftMenu";
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmDepartment_KeyDown);
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            this.Name = "frmDepartment";
        }
        #endregion
        private Smobiler.Core.Controls.ListView gridDepData;
        private Smobiler.Core.Controls.Button btnCreate;
        private SMOSEC.UI.UserControl.MenuTitle MenuTitle1;
        private Smobiler.Core.Controls.TextBox txtcreate;
        internal Smobiler.Core.Controls.Panel Panel2;
    }
}
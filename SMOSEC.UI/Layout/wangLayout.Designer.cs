using System;
using Smobiler.Core;
namespace SMOSEC.UI.Layout
{
    partial class wangLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 25);
            this.panel1.Touchable = true;
            //this.panel1.Press += new System.EventHandler(this.panel1_Press);

            // 
            // label1
            // 
            this.label1.DataMember = "NAME";
            this.label1.DisplayMember = "NAME";
            //this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 10F);
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.ZIndex = 2;
            // 
            // frmDepartmentLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 25);
            this.Name = "wangLayout";
        }
        #endregion
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
    }
}
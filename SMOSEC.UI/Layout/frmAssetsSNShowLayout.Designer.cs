using System;
using Smobiler.Core;
namespace SMOSEC.UI.Layout
{
    partial class frmAssetsSNShowLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssetsSNShowLayout()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.imgAss = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.lblStatus = new Smobiler.Core.Controls.Label();
            this.lblSN = new Smobiler.Core.Controls.Label();
            // 
            // imgAss
            // 
            this.imgAss.BorderRadius = 15;
            this.imgAss.DisplayMember = "IMAGE";
            this.imgAss.Location = new System.Drawing.Point(15, 7);
            this.imgAss.Name = "imgAss";
            this.imgAss.Size = new System.Drawing.Size(45, 45);
            this.imgAss.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.DataMember = "ASSID";
            this.lblName.DisplayFormat = "Ψһ��: {0}";
            this.lblName.DisplayMember = "ASSID";
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(115, 30);
            // 
            // lblStatus
            // 
            this.lblStatus.DisplayMember = "STATUS";
            this.lblStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStatus.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblStatus.Location = new System.Drawing.Point(115, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(115, 30);
            // 
            // lblSN
            // 
            this.lblSN.DataMember = "SN";
            this.lblSN.DisplayFormat = "SN��: {0}";
            this.lblSN.DisplayMember = "SN";
            this.lblSN.Location = new System.Drawing.Point(0, 30);
            this.lblSN.Name = "lblSN";
            this.lblSN.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblSN.Size = new System.Drawing.Size(115, 30);
            // 
            // frmAssetsSNShowLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            //this.imgAss,
            this.lblName,
            this.lblStatus,
            this.lblSN});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmAssetsSNShowLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Image imgAss;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.Label lblStatus;
        internal Smobiler.Core.Controls.Label lblSN;
    }
}
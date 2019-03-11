using System;
using Smobiler.Core;
namespace SMOSEC.UI.Layout
{
    partial class frmAssetsExLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmAssetsExLayout()
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
            this.tpRow = new Smobiler.Core.Controls.Panel();
            //this.imgPicture = new Smobiler.Core.Controls.Image();
            this.lblSN = new Smobiler.Core.Controls.Label();
            this.lblID = new Smobiler.Core.Controls.Label();
            this.lblPrice = new Smobiler.Core.Controls.Label();
            this.Label16 = new Smobiler.Core.Controls.Label();
            this.Label17 = new Smobiler.Core.Controls.Label();
            this.Label18 = new Smobiler.Core.Controls.Label();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            // 
            // tpRow
            // 
            this.tpRow.BackColor = System.Drawing.Color.White;
            this.tpRow.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.tpRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tpRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            //this.imgPicture,
            this.lblSN,
            this.lblID,
            this.lblPrice,
            this.Label16,
            this.Label17,
            this.Label18
            //this.checkBox1
            });
            this.tpRow.Name = "tpRow";
            this.tpRow.Size = new System.Drawing.Size(300, 70);
            this.tpRow.Touchable = true;
            this.tpRow.Press += new System.EventHandler(this.touchPanel1_Press);
            //// 
            //// imgPicture
            //// 
            //this.imgPicture.DataMember = "Image";
            //this.imgPicture.DisplayMember = "Image";
            //this.imgPicture.Location = new System.Drawing.Point(32, 5);
            //this.imgPicture.Name = "imgPicture";
            //this.imgPicture.Size = new System.Drawing.Size(68, 60);
            //this.imgPicture.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            //this.imgPicture.ZIndex = 1;
            // 
            // lblSN
            // 
            this.lblSN.DataMember = "sn";
            this.lblSN.DisplayMember = "sn";
            this.lblSN.Location = new System.Drawing.Point(80, 25);
            this.lblSN.Name = "lblSN";
            this.lblSN.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblSN.Size = new System.Drawing.Size(190, 20);
            this.lblSN.Text = "SN";
            this.lblSN.ZIndex = 1;
            // 
            // lblID
            // 
            this.lblID.DataMember = "Brand";
            this.lblID.DisplayMember = "Brand";
            this.lblID.Location = new System.Drawing.Point(80, 5);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblID.Size = new System.Drawing.Size(190, 20);
            this.lblID.Text = "品牌型号";
            this.lblID.ZIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.DataMember = "StatusName";
            this.lblPrice.DisplayMember = "StatusName";
            //this.lblPrice.FontSize = 12F;
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.lblPrice.Location = new System.Drawing.Point(80, 45);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblPrice.Size = new System.Drawing.Size(190, 20);
            this.lblPrice.Text = "在用";
            this.lblPrice.ZIndex = 1;
            // 
            // Label16
            // 
            this.Label16.FontSize = 12F;
            this.Label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Label16.Location = new System.Drawing.Point(20, 45);
            this.Label16.Name = "Label16";
            this.Label16.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label16.Size = new System.Drawing.Size(60, 20);
            this.Label16.Text = "状态";
            this.Label16.ZIndex = 1;
            this.Label16.ForeColor = System.Drawing.Color.Black;
            // 
            // Label17
            // 
            this.Label17.FontSize = 12F;
            this.Label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Label17.Location = new System.Drawing.Point(20, 5);
            this.Label17.Name = "Label17";
            this.Label17.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label17.Size = new System.Drawing.Size(60, 20);
            this.Label17.Text = "品牌型号";
            this.Label17.ForeColor = System.Drawing.Color.Black;
            this.Label17.ZIndex = 1;
            this.Label17.ForeColor = System.Drawing.Color.Black;
            // 
            // Label18
            // 
            this.Label18.FontSize = 12F;
            this.Label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Label18.Location = new System.Drawing.Point(20, 25);
            this.Label18.Name = "Label18";
            this.Label18.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label18.Size = new System.Drawing.Size(60, 20);
            this.Label18.Text = "SN号";
            this.Label18.ZIndex = 1;
            this.Label18.ForeColor = System.Drawing.Color.Black;
            // 
            // checkBox1
            // 
            this.checkBox1.DataMember = "IsChecked";
            this.checkBox1.DisplayMember = "IsChecked";
            this.checkBox1.Location = new System.Drawing.Point(7, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 22);
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmAssetsExLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tpRow});
            this.Size = new System.Drawing.Size(300, 70);
            this.Name = "frmAssetsExLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel tpRow;
        //private Smobiler.Core.Controls.Image imgPicture;
        private Smobiler.Core.Controls.Label lblSN;
        private Smobiler.Core.Controls.Label lblID;
        private Smobiler.Core.Controls.Label lblPrice;
        private Smobiler.Core.Controls.Label Label16;
        private Smobiler.Core.Controls.Label Label17;
        private Smobiler.Core.Controls.Label Label18;

        private Smobiler.Core.Controls.CheckBox checkBox1;
    }
}
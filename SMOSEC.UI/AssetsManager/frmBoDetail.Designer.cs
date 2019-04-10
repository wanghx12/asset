using System;
using Smobiler.Core;
using SMOSEC.UI.UserControl;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmBoDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmBoDetail()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

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
            this.Title1 = new SMOSEC.UI.UserControl.Title();
            this.Panel1 = new Smobiler.Core.Controls.Panel();
            this.Panel3 = new Smobiler.Core.Controls.Panel();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Label11 = new Smobiler.Core.Controls.Label();
            this.Label12 = new Smobiler.Core.Controls.Label();
            this.Label13 = new Smobiler.Core.Controls.Label();
            this.Label14 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.txtpro = new Smobiler.Core.Controls.TextBox();
            this.txtteam = new Smobiler.Core.Controls.TextBox();
            this.txtphone = new Smobiler.Core.Controls.TextBox();
            this.txtexpired = new Smobiler.Core.Controls.TextBox();
            this.DPickerCO = new Smobiler.Core.Controls.DatePicker();
            this.DPickerRs = new Smobiler.Core.Controls.DatePicker();
            this.txtBOMan = new Smobiler.Core.Controls.TextBox();
            this.txtHMan = new Smobiler.Core.Controls.TextBox();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.txtLocation = new Smobiler.Core.Controls.TextBox();
            this.panelScan = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.txtsn = new Smobiler.Core.Controls.TextBox();
            this.btnadd = new Smobiler.Core.Controls.Button();
            this.Panel4 = new Smobiler.Core.Controls.Panel();
            this.ListAss = new Smobiler.Core.Controls.ListView();
            this.Panel2 = new Smobiler.Core.Controls.Panel();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            this.barcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TemplateData = null;
            this.Title1.TemplateItem = null;
            this.Title1.TitleText = "借用单详情";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Panel3,
            this.panelScan,
            this.Panel4});
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 62);
            this.Panel1.Name = "Panel1";
            this.Panel1.Scrollable = true;
            this.Panel1.Size = new System.Drawing.Size(300, 524);
            // 
            // Panel3
            // 
            this.Panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Label2,
            this.Label6,
            this.Label7,
            this.Label8,
            this.Label11,
            this.Label12,
            this.Label13,
            this.Label14,
            this.txtNote,
            this.txtpro,
            this.txtteam,
            this.txtphone,
            this.txtexpired,
            this.DPickerCO,
            this.DPickerRs,
            this.txtBOMan,
            this.txtHMan,
            this.Label3,
            this.txtLocation});
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(418, 305);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.Location = new System.Drawing.Point(0, 30);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(100, 30);
            this.Label1.Text = "借用人";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.Location = new System.Drawing.Point(0, 90);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(100, 30);
            this.Label2.Text = "借出日期";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.Location = new System.Drawing.Point(0, 120);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(100, 30);
            this.Label6.Text = "预计归还日期";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(100, 30);
            this.Label7.Text = "借出处理人";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.Location = new System.Drawing.Point(0, 270);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(100, 30);
            this.Label8.Text = "备注";
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.White;
            this.Label11.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label11.Location = new System.Drawing.Point(0, 150);
            this.Label11.Name = "Label11";
            this.Label11.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label11.Size = new System.Drawing.Size(100, 30);
            this.Label11.Text = "项目";
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.White;
            this.Label12.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label12.Location = new System.Drawing.Point(0, 180);
            this.Label12.Name = "Label12";
            this.Label12.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label12.Size = new System.Drawing.Size(100, 30);
            this.Label12.Text = "团队";
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.White;
            this.Label13.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label13.Location = new System.Drawing.Point(0, 210);
            this.Label13.Name = "Label13";
            this.Label13.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label13.Size = new System.Drawing.Size(100, 30);
            this.Label13.Text = "手机号";
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.White;
            this.Label14.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.Location = new System.Drawing.Point(0, 240);
            this.Label14.Name = "Label14";
            this.Label14.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label14.Size = new System.Drawing.Size(100, 30);
            this.Label14.Text = "过期状态";
            // 
            // txtNote
            // 
            this.txtNote.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtNote.Location = new System.Drawing.Point(100, 270);
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(200, 30);
            // 
            // txtpro
            // 
            this.txtpro.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtpro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtpro.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtpro.Location = new System.Drawing.Point(100, 150);
            this.txtpro.Name = "txtpro";
            this.txtpro.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtpro.ReadOnly = true;
            this.txtpro.Size = new System.Drawing.Size(200, 30);
            // 
            // txtteam
            // 
            this.txtteam.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtteam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtteam.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtteam.Location = new System.Drawing.Point(100, 180);
            this.txtteam.Name = "txtteam";
            this.txtteam.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtteam.ReadOnly = true;
            this.txtteam.Size = new System.Drawing.Size(200, 30);
            // 
            // txtphone
            // 
            this.txtphone.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtphone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtphone.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtphone.Location = new System.Drawing.Point(100, 210);
            this.txtphone.Name = "txtphone";
            this.txtphone.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtphone.ReadOnly = true;
            this.txtphone.Size = new System.Drawing.Size(200, 30);
            // 
            // txtexpired
            // 
            this.txtexpired.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtexpired.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtexpired.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtexpired.Location = new System.Drawing.Point(100, 240);
            this.txtexpired.Name = "txtexpired";
            this.txtexpired.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtexpired.ReadOnly = true;
            this.txtexpired.Size = new System.Drawing.Size(200, 30);
            // 
            // DPickerCO
            // 
            this.DPickerCO.BackColor = System.Drawing.Color.White;
            this.DPickerCO.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.DPickerCO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DPickerCO.Enabled = false;
            this.DPickerCO.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.DPickerCO.Location = new System.Drawing.Point(100, 90);
            this.DPickerCO.Name = "DPickerCO";
            this.DPickerCO.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.DPickerCO.Size = new System.Drawing.Size(200, 30);
            // 
            // DPickerRs
            // 
            this.DPickerRs.BackColor = System.Drawing.Color.White;
            this.DPickerRs.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.DPickerRs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DPickerRs.Enabled = false;
            this.DPickerRs.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.DPickerRs.Location = new System.Drawing.Point(100, 120);
            this.DPickerRs.Name = "DPickerRs";
            this.DPickerRs.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.DPickerRs.Size = new System.Drawing.Size(200, 30);
            // 
            // txtBOMan
            // 
            this.txtBOMan.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtBOMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBOMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtBOMan.Location = new System.Drawing.Point(100, 30);
            this.txtBOMan.Name = "txtBOMan";
            this.txtBOMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtBOMan.ReadOnly = true;
            this.txtBOMan.Size = new System.Drawing.Size(200, 30);
            // 
            // txtHMan
            // 
            this.txtHMan.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtHMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtHMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtHMan.Location = new System.Drawing.Point(100, 0);
            this.txtHMan.Name = "txtHMan";
            this.txtHMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtHMan.ReadOnly = true;
            this.txtHMan.Size = new System.Drawing.Size(200, 30);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.Location = new System.Drawing.Point(0, 60);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(100, 30);
            this.Label3.Text = "机房";
            // 
            // txtLocation
            // 
            this.txtLocation.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtLocation.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtLocation.Location = new System.Drawing.Point(100, 60);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(200, 30);
            // 
            // panelScan
            // 
            this.panelScan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label10,
            this.txtsn,
            this.btnadd});
            this.panelScan.Location = new System.Drawing.Point(5, 305);
            this.panelScan.Name = "panelScan";
            this.panelScan.Size = new System.Drawing.Size(300, 28);
            this.panelScan.Touchable = true;
            this.panelScan.Press += new System.EventHandler(this.panelScan_Press);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(1, 1);
            this.image1.Name = "image1";
            this.image1.ResourceID = "scan";
            this.image1.Size = new System.Drawing.Size(30, 26);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(38, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 25);
            this.label10.Text = "扫码添加";
            // 
            // txtsn
            // 
            this.txtsn.Location = new System.Drawing.Point(140, 2);
            this.txtsn.Name = "txtsn";
            this.txtsn.Size = new System.Drawing.Size(110, 25);
            this.txtsn.WaterMarkText = "手动输入后点击ADD";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(250, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(40, 25);
            this.btnadd.Text = "ADD";
            this.btnadd.Press += new System.EventHandler(this.btnadd_Press);
            // 
            // Panel4
            // 
            this.Panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ListAss});
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(0, 336);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(300, 261);
            // 
            // ListAss
            // 
            this.ListAss.BackColor = System.Drawing.Color.White;
            this.ListAss.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.ListAss.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListAss.Name = "ListAss";
            this.ListAss.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListAss.PageSizeTextSize = 11F;
            this.ListAss.ShowSplitLine = true;
            this.ListAss.Size = new System.Drawing.Size(300, 260);
            this.ListAss.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAss.TemplateControlName = "OperCreateAssLayout";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave,
            this.btnDelete});
            this.Panel2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Panel2.Location = new System.Drawing.Point(0, 468);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(300, 40);
            // 
            // btnSave
            // 
            this.btnSave.Flex = 1;
            this.btnSave.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(0, 0);
            this.btnSave.Text = "借用";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // btnDelete
            // 
            this.btnDelete.Flex = 1;
            this.btnDelete.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(0, 0);
            this.btnDelete.Text = "全部归还";
            this.btnDelete.Press += new System.EventHandler(this.btnDelete_Press);
            // 
            // barcodeScanner1
            // 
            this.barcodeScanner1.Name = "barcodeScanner1";
            this.barcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned_1);
            // 
            // frmBoDetail
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.barcodeScanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.Panel2,
            this.Panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmBODetail_KeyDown);
            this.Load += new System.EventHandler(this.frmBODetail_Load);
            this.Name = "frmBoDetail";

        }
        #endregion

        private Title Title1;
        internal Smobiler.Core.Controls.Panel Panel1;
        internal Smobiler.Core.Controls.Panel Panel3;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label Label11;
        internal Smobiler.Core.Controls.Label Label12;
        internal Smobiler.Core.Controls.Label Label13;
        internal Smobiler.Core.Controls.Label Label14;
        internal Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.DatePicker DPickerCO;
        internal Smobiler.Core.Controls.DatePicker DPickerRs;
        internal Smobiler.Core.Controls.TextBox txtBOMan;
        internal Smobiler.Core.Controls.TextBox txtHMan;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.TextBox txtLocation;
        internal Smobiler.Core.Controls.Panel Panel4;
        private Smobiler.Core.Controls.ListView ListAss;
        internal Smobiler.Core.Controls.TextBox txtpro;
        internal Smobiler.Core.Controls.TextBox txtteam;
        internal Smobiler.Core.Controls.TextBox txtphone;
        internal Smobiler.Core.Controls.TextBox txtexpired;
        private Smobiler.Core.Controls.BarcodeScanner barcodeScanner1;
        internal Smobiler.Core.Controls.Panel panelScan;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label10;
        internal Smobiler.Core.Controls.Panel Panel2;
        internal Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.Button btnDelete;
        internal Smobiler.Core.Controls.TextBox txtsn;
        internal Smobiler.Core.Controls.Button btnadd;
    }
}
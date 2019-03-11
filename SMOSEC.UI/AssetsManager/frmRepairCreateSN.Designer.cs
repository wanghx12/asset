using System;
using Smobiler.Core;
namespace SMOSEC.UI.AssetsManager
{
    partial class frmRepairCreateSN : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmRepairCreateSN()
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
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.plRDMan = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnDealMan = new Smobiler.Core.Controls.TextBox();
            this.plDate = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.DatePicker = new Smobiler.Core.Controls.DatePicker();
            this.plPrice = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtrepairman = new Smobiler.Core.Controls.TextBox();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.txtContent = new Smobiler.Core.Controls.TextBox();
            this.plNote = new Smobiler.Core.Controls.Panel();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.plsns = new Smobiler.Core.Controls.Panel();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.txtsns = new Smobiler.Core.Controls.TextBox();
            this.ImgBtnForSN = new Smobiler.Core.Controls.ImageButton();
            this.ListAssetsSN = new Smobiler.Core.Controls.ListView();
            this.plstatus = new Smobiler.Core.Controls.Panel();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.txtstatus = new Smobiler.Core.Controls.TextBox();
            this.plAdd = new Smobiler.Core.Controls.Panel();
            this.betGet = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.popDealMan = new Smobiler.Core.Controls.PopList();
            this.BarcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            this.r2000Scanner1 = new Smobiler.Device.R2000Scanner();
            this.title1 = new SMOSEC.UI.UserControl.Title();
            // 
            // plButton
            // 
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 382);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 35);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.BorderRadius = 4;
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(10, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRDMan,
            this.plDate,
            this.plPrice,
            this.plContent,
            this.plNote,
            this.plsns,
            this.ListAssetsSN});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Flex = 10000;
            this.spContent.Location = new System.Drawing.Point(0, 110);
            this.spContent.Name = "spContent";
            this.spContent.Scrollable = true;
            this.spContent.Size = new System.Drawing.Size(300, 100);
            // 
            // plRDMan
            // 
            this.plRDMan.BackColor = System.Drawing.Color.White;
            this.plRDMan.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plRDMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plRDMan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.btnDealMan});
            this.plRDMan.Name = "plRDMan";
            this.plRDMan.Size = new System.Drawing.Size(300, 35);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.Text = "报修人";
            // 
            // btnDealMan
            // 
            this.btnDealMan.BackColor = System.Drawing.Color.Transparent;
            this.btnDealMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnDealMan.Location = new System.Drawing.Point(88, 0);
            this.btnDealMan.MaxLength = 200;
            this.btnDealMan.Name = "btnDealMan";
            this.btnDealMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnDealMan.Size = new System.Drawing.Size(212, 35);
            this.btnDealMan.WaterMarkText = "（必填）";
            // 
            // plDate
            // 
            this.plDate.BackColor = System.Drawing.Color.White;
            this.plDate.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plDate.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.DatePicker});
            this.plDate.Location = new System.Drawing.Point(0, 35);
            this.plDate.Name = "plDate";
            this.plDate.Size = new System.Drawing.Size(300, 35);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(88, 35);
            this.label5.Text = "维修日期";
            // 
            // DatePicker
            // 
            this.DatePicker.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.DatePicker.Location = new System.Drawing.Point(88, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.DatePicker.Size = new System.Drawing.Size(212, 35);
            // 
            // plPrice
            // 
            this.plPrice.BackColor = System.Drawing.Color.White;
            this.plPrice.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plPrice.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.txtrepairman});
            this.plPrice.Location = new System.Drawing.Point(0, 70);
            this.plPrice.Name = "plPrice";
            this.plPrice.Size = new System.Drawing.Size(300, 35);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(88, 35);
            this.label2.Text = "维修人";
            // 
            // txtrepairman
            // 
            this.txtrepairman.BackColor = System.Drawing.Color.Transparent;
            this.txtrepairman.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtrepairman.Location = new System.Drawing.Point(88, 0);
            this.txtrepairman.Name = "txtrepairman";
            this.txtrepairman.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtrepairman.Size = new System.Drawing.Size(212, 35);
            this.txtrepairman.WaterMarkText = "（必填）";
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.White;
            this.plContent.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6,
            this.txtContent});
            this.plContent.Location = new System.Drawing.Point(0, 105);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 35);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(88, 35);
            this.label6.Text = "维修内容";
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.Transparent;
            this.txtContent.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtContent.Location = new System.Drawing.Point(88, 0);
            this.txtContent.MaxLength = 200;
            this.txtContent.Name = "txtContent";
            this.txtContent.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtContent.Size = new System.Drawing.Size(212, 35);
            this.txtContent.WaterMarkText = "（必填）";
            // 
            // plNote
            // 
            this.plNote.BackColor = System.Drawing.Color.White;
            this.plNote.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plNote.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label7,
            this.txtNote});
            this.plNote.Location = new System.Drawing.Point(0, 140);
            this.plNote.Name = "plNote";
            this.plNote.Size = new System.Drawing.Size(300, 35);
            // 
            // Label7
            // 
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(88, 35);
            this.Label7.Text = "发现者";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.Transparent;
            this.txtNote.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtNote.Location = new System.Drawing.Point(88, 0);
            this.txtNote.MaxLength = 200;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtNote.Size = new System.Drawing.Size(212, 35);
            this.txtNote.WaterMarkText = "（必填）";
            // 
            // plsns
            // 
            this.plsns.BackColor = System.Drawing.Color.White;
            this.plsns.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plsns.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plsns.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label9,
            this.txtsns,
            this.ImgBtnForSN});
            this.plsns.Location = new System.Drawing.Point(0, 175);
            this.plsns.Name = "plsns";
            this.plsns.Size = new System.Drawing.Size(300, 100);
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label9.Size = new System.Drawing.Size(88, 35);
            this.label9.Text = "SN";
            // 
            // txtsns
            // 
            this.txtsns.BackColor = System.Drawing.Color.Transparent;
            this.txtsns.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtsns.Location = new System.Drawing.Point(88, 0);
            this.txtsns.MaxLength = 200;
            this.txtsns.Name = "txtsns";
            this.txtsns.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtsns.Size = new System.Drawing.Size(152, 35);
            this.txtsns.WaterMarkText = "(必填,支持扫码)";
            // 
            // ImgBtnForSN
            // 
            this.ImgBtnForSN.BackColor = System.Drawing.Color.White;
            this.ImgBtnForSN.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.ImgBtnForSN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ImgBtnForSN.Location = new System.Drawing.Point(240, 0);
            this.ImgBtnForSN.Name = "ImgBtnForSN";
            this.ImgBtnForSN.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.ImgBtnForSN.ResourceID = "scan";
            this.ImgBtnForSN.Size = new System.Drawing.Size(60, 35);
            this.ImgBtnForSN.Press += new System.EventHandler(this.ImgBtnForAssId_Press);
            // 
            // ListAssetsSN
            // 
            this.ListAssetsSN.BackColor = System.Drawing.Color.White;
            this.ListAssetsSN.Location = new System.Drawing.Point(0, 210);
            this.ListAssetsSN.Name = "ListAssetsSN";
            this.ListAssetsSN.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListAssetsSN.PageSizeTextSize = 11F;
            this.ListAssetsSN.ShowSplitLine = true;
            this.ListAssetsSN.Size = new System.Drawing.Size(300, 215);
            this.ListAssetsSN.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAssetsSN.TemplateControlName = "frmOrderCreateSNLayout";
            // 
            // plstatus
            // 
            this.plstatus.BackColor = System.Drawing.Color.White;
            this.plstatus.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plstatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plstatus.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label8,
            this.txtstatus});
            this.plstatus.Location = new System.Drawing.Point(0, 175);
            this.plstatus.Name = "plstatus";
            this.plstatus.Size = new System.Drawing.Size(300, 35);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label8.Size = new System.Drawing.Size(88, 35);
            this.label8.Text = "维修状态";
            // 
            // txtstatus
            // 
            this.txtstatus.BackColor = System.Drawing.Color.Transparent;
            this.txtstatus.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtstatus.Location = new System.Drawing.Point(88, 0);
            this.txtstatus.MaxLength = 200;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtstatus.Size = new System.Drawing.Size(212, 35);
            this.txtstatus.WaterMarkText = "（选填）";
            // 
            // plAdd
            // 
            this.plAdd.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.betGet});
            this.plAdd.Location = new System.Drawing.Point(0, 245);
            this.plAdd.Name = "plAdd";
            this.plAdd.Size = new System.Drawing.Size(300, 35);
            // 
            // betGet
            // 
            this.betGet.Location = new System.Drawing.Point(10, 0);
            this.betGet.Name = "betGet";
            this.betGet.Size = new System.Drawing.Size(130, 35);
            this.betGet.Text = "扫码添加";
            this.betGet.Press += new System.EventHandler(this.betGet_Press);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Location = new System.Drawing.Point(280, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label3.Size = new System.Drawing.Size(20, 35);
            this.label3.Text = "元";
            // 
            // popDealMan
            // 
            this.popDealMan.Name = "popDealMan";
            this.popDealMan.Selected += new System.EventHandler(this.popDealMan_Selected);
            // 
            // BarcodeScanner1
            // 
            this.BarcodeScanner1.Name = "BarcodeScanner1";
            this.BarcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.BarcodeScanner1_BarcodeScanned);
            // 
            // r2000Scanner1
            // 
            this.r2000Scanner1.Name = "r2000Scanner1";
            this.r2000Scanner1.BarcodeDataCaptured += new Smobiler.Device.R2000BarcodeScanEventHandler(this.r2000Scanner1_BarcodeDataCaptured);
            this.r2000Scanner1.RFIDDataCaptured += new Smobiler.Device.R2000RFIDScanEventHandler(this.r2000Scanner1_RFIDDataCaptured);
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(197, 89);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            this.title1.TemplateData = null;
            this.title1.TemplateItem = null;
            this.title1.TitleText = "资产报修单创建";
            // 
            // frmRepairCreateSN
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popDealMan,
            this.BarcodeScanner1,
            this.r2000Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.plButton,
            this.spContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmBOCreate_KeyDown);
            this.Load += new System.EventHandler(this.frmBOCreate_Load);
            this.Name = "frmRepairCreateSN";

        }
        #endregion

        private UserControl.Title title1;
        private Smobiler.Core.Controls.Panel plButton;
        private Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.Panel spContent;
        private Smobiler.Core.Controls.Panel plRDMan;
        private Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.TextBox btnDealMan;
        private Smobiler.Core.Controls.Panel plDate;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.DatePicker DatePicker;
        private Smobiler.Core.Controls.Panel plPrice;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtrepairman;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Panel plContent;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.TextBox txtContent;
        private Smobiler.Core.Controls.Panel plNote;
        private Smobiler.Core.Controls.Label Label7;
        private Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.Panel plAdd;
        internal Smobiler.Core.Controls.Button betGet;
        internal Smobiler.Core.Controls.PopList popDealMan;
        internal Smobiler.Core.Controls.BarcodeScanner BarcodeScanner1;
        private Smobiler.Core.Controls.ListView ListAssetsSN;
        private Smobiler.Device.R2000Scanner r2000Scanner1;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Panel plstatus;
        private Smobiler.Core.Controls.Panel plsns;
        private Smobiler.Core.Controls.TextBox txtstatus;
        private Smobiler.Core.Controls.TextBox txtsns;
        private Smobiler.Core.Controls.ImageButton ImgBtnForSN;
    }
}
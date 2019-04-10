using SMOSEC.UI.UserControl;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmBoCreate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmBoCreate()
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
            this.Panel2 = new Smobiler.Core.Controls.Panel();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.Panel1 = new Smobiler.Core.Controls.Panel();
            this.Panel3 = new Smobiler.Core.Controls.Panel();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.Label20 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.txtphone = new Smobiler.Core.Controls.TextBox();
            this.DPickerCO = new Smobiler.Core.Controls.DatePicker();
            this.DPickerRs = new Smobiler.Core.Controls.DatePicker();
            this.btnBOMan = new Smobiler.Core.Controls.Button();
            this.btnBOMan1 = new Smobiler.Core.Controls.Button();
            this.btnPro = new Smobiler.Core.Controls.Button();
            this.btnPro1 = new Smobiler.Core.Controls.Button();
            this.btnTeam = new Smobiler.Core.Controls.Button();
            this.btnTeam1 = new Smobiler.Core.Controls.Button();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.btnLocation = new Smobiler.Core.Controls.TextBox();
            this.txtManager = new Smobiler.Core.Controls.TextBox();
            this.Panel4 = new Smobiler.Core.Controls.Panel();
            this.ListAss = new Smobiler.Core.Controls.ListView();
            this.PopBOMan = new Smobiler.Core.Controls.PopList();
            this.PopPro = new Smobiler.Core.Controls.PopList();
            this.PopTeam = new Smobiler.Core.Controls.PopList();
            this.PopLocation = new Smobiler.Core.Controls.PopList();
            this.r2000Scanner1 = new Smobiler.Device.R2000Scanner();
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
            this.Title1.TitleText = "���õ�����";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave});
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 468);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(300, 40);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 30);
            this.btnSave.Text = "ȷ��";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Panel3});
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 62);
            this.Panel1.Name = "Panel1";
            this.Panel1.Scrollable = true;
            this.Panel1.Size = new System.Drawing.Size(300, 347);
            // 
            // Panel3
            // 
            this.Panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Label2,
            this.Label6,
            this.Label7,
            this.Label8,
            this.Label9,
            this.Label10,
            this.Label20,
            this.txtNote,
            this.txtphone,
            this.DPickerCO,
            this.DPickerRs,
            this.btnBOMan,
            this.btnBOMan1,
            this.btnPro,
            this.btnPro1,
            this.btnTeam,
            this.btnTeam1,
            this.Label4,
            this.btnLocation,
            this.txtManager});
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(300, 305);
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
            this.Label1.Text = "������";
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
            this.Label2.Text = "�������";
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
            this.Label6.Text = "Ԥ�ƹ黹����";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(100, 30);
            this.Label7.Text = "���������";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.Location = new System.Drawing.Point(0, 240);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(100, 30);
            this.Label8.Text = "��ע";
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.Location = new System.Drawing.Point(0, 150);
            this.Label9.Name = "Label9";
            this.Label9.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label9.Size = new System.Drawing.Size(100, 30);
            this.Label9.Text = "��Ŀ";
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.Location = new System.Drawing.Point(0, 180);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.Size(100, 30);
            this.Label10.Text = "�Ŷ�";
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.White;
            this.Label20.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label20.Location = new System.Drawing.Point(0, 210);
            this.Label20.Name = "Label20";
            this.Label20.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label20.Size = new System.Drawing.Size(100, 30);
            this.Label20.Text = "�ֻ���";
            // 
            // txtNote
            // 
            this.txtNote.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtNote.Location = new System.Drawing.Point(100, 240);
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtNote.Size = new System.Drawing.Size(200, 30);
            this.txtNote.WaterMarkText = "(ѡ��)";
            // 
            // txtphone
            // 
            this.txtphone.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtphone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtphone.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtphone.Location = new System.Drawing.Point(100, 210);
            this.txtphone.Name = "txtphone";
            this.txtphone.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtphone.Size = new System.Drawing.Size(200, 30);
            this.txtphone.WaterMarkText = "(����)";
            // 
            // DPickerCO
            // 
            this.DPickerCO.BackColor = System.Drawing.Color.White;
            this.DPickerCO.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.DPickerCO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            this.DPickerRs.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.DPickerRs.Location = new System.Drawing.Point(100, 120);
            this.DPickerRs.Name = "DPickerRs";
            this.DPickerRs.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.DPickerRs.Size = new System.Drawing.Size(200, 30);
            // 
            // btnBOMan
            // 
            this.btnBOMan.BackColor = System.Drawing.Color.White;
            this.btnBOMan.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnBOMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBOMan.BorderRadius = 0;
            this.btnBOMan.ForeColor = System.Drawing.Color.Black;
            this.btnBOMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnBOMan.Location = new System.Drawing.Point(100, 30);
            this.btnBOMan.Name = "btnBOMan";
            this.btnBOMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 2F, 0F);
            this.btnBOMan.Size = new System.Drawing.Size(166, 30);
            this.btnBOMan.Press += new System.EventHandler(this.btnBOMan_Press);
            // 
            // btnBOMan1
            // 
            this.btnBOMan1.BackColor = System.Drawing.Color.White;
            this.btnBOMan1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnBOMan1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBOMan1.BorderRadius = 0;
            this.btnBOMan1.ForeColor = System.Drawing.Color.Black;
            this.btnBOMan1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnBOMan1.Location = new System.Drawing.Point(266, 30);
            this.btnBOMan1.Name = "btnBOMan1";
            this.btnBOMan1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnBOMan1.Size = new System.Drawing.Size(34, 30);
            this.btnBOMan1.Text = ">";
            this.btnBOMan1.Press += new System.EventHandler(this.btnBOMan_Press);
            // 
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.Color.White;
            this.btnPro.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnPro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnPro.BorderRadius = 0;
            this.btnPro.ForeColor = System.Drawing.Color.Black;
            this.btnPro.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnPro.Location = new System.Drawing.Point(100, 150);
            this.btnPro.Name = "btnPro";
            this.btnPro.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 2F, 0F);
            this.btnPro.Size = new System.Drawing.Size(166, 30);
            this.btnPro.Press += new System.EventHandler(this.btnPro_Press);
            // 
            // btnPro1
            // 
            this.btnPro1.BackColor = System.Drawing.Color.White;
            this.btnPro1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnPro1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnPro1.BorderRadius = 0;
            this.btnPro1.ForeColor = System.Drawing.Color.Black;
            this.btnPro1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnPro1.Location = new System.Drawing.Point(266, 150);
            this.btnPro1.Name = "btnPro1";
            this.btnPro1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnPro1.Size = new System.Drawing.Size(34, 30);
            this.btnPro1.Text = ">";
            this.btnPro1.Press += new System.EventHandler(this.btnPro_Press);
            // 
            // btnTeam
            // 
            this.btnTeam.BackColor = System.Drawing.Color.White;
            this.btnTeam.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnTeam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTeam.BorderRadius = 0;
            this.btnTeam.ForeColor = System.Drawing.Color.Black;
            this.btnTeam.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnTeam.Location = new System.Drawing.Point(100, 180);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 2F, 0F);
            this.btnTeam.Size = new System.Drawing.Size(166, 30);
            this.btnTeam.Press += new System.EventHandler(this.btnTeam_Press);
            // 
            // btnTeam1
            // 
            this.btnTeam1.BackColor = System.Drawing.Color.White;
            this.btnTeam1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnTeam1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTeam1.BorderRadius = 0;
            this.btnTeam1.ForeColor = System.Drawing.Color.Black;
            this.btnTeam1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnTeam1.Location = new System.Drawing.Point(266, 180);
            this.btnTeam1.Name = "btnTeam1";
            this.btnTeam1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnTeam1.Size = new System.Drawing.Size(34, 30);
            this.btnTeam1.Text = ">";
            this.btnTeam1.Press += new System.EventHandler(this.btnTeam_Press);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.Location = new System.Drawing.Point(0, 60);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(100, 30);
            this.Label4.Text = "��Դ����";
            // 
            // btnLocation
            // 
            this.btnLocation.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLocation.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnLocation.Location = new System.Drawing.Point(100, 60);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnLocation.Size = new System.Drawing.Size(200, 30);
            this.btnLocation.WaterMarkText = "(����)";
            // 
            // txtManager
            // 
            this.txtManager.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtManager.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtManager.Location = new System.Drawing.Point(100, 0);
            this.txtManager.Name = "txtManager";
            this.txtManager.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtManager.Size = new System.Drawing.Size(200, 30);
            this.txtManager.WaterMarkText = "(����)";
            // 
            // Panel4
            // 
            this.Panel4.Location = new System.Drawing.Point(0, 345);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(300, 230);
            // 
            // ListAss
            // 
            this.ListAss.BackColor = System.Drawing.Color.White;
            this.ListAss.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.ListAss.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListAss.Location = new System.Drawing.Point(0, 2);
            this.ListAss.Name = "ListAss";
            this.ListAss.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListAss.PageSizeTextSize = 11F;
            this.ListAss.ShowSplitLine = true;
            this.ListAss.Size = new System.Drawing.Size(300, 335);
            this.ListAss.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAss.TemplateControlName = "OperCreateAssLayout";
            // 
            // PopBOMan
            // 
            this.PopBOMan.Name = "PopBOMan";
            this.PopBOMan.Selected += new System.EventHandler(this.PopBOMan_Selected);
            // 
            // PopPro
            // 
            this.PopPro.Name = "PopPro";
            this.PopPro.Selected += new System.EventHandler(this.PopPro_Selected);
            // 
            // PopTeam
            // 
            this.PopTeam.Name = "PopTeam";
            this.PopTeam.Selected += new System.EventHandler(this.PopTeam_Selected);
            // 
            // PopLocation
            // 
            this.PopLocation.Name = "PopLocation";
            this.PopLocation.Selected += new System.EventHandler(this.PopLocation_Selected);
            // 
            // r2000Scanner1
            // 
            this.r2000Scanner1.Name = "r2000Scanner1";
            this.r2000Scanner1.BarcodeDataCaptured += new Smobiler.Device.R2000BarcodeScanEventHandler(this.r2000Scanner1_BarcodeDataCaptured);
            this.r2000Scanner1.RFIDDataCaptured += new Smobiler.Device.R2000RFIDScanEventHandler(this.r2000Scanner1_RFIDDataCaptured);
            // 
            // barcodeScanner1
            // 
            this.barcodeScanner1.Name = "barcodeScanner1";
            this.barcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned_1);
            // 
            // frmBoCreate
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.PopBOMan,
            this.PopPro,
            this.PopTeam,
            this.r2000Scanner1,
            this.barcodeScanner1,
            this.PopLocation});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.Panel2,
            this.Panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmBOCreate_KeyDown);
            this.Load += new System.EventHandler(this.frmBOCreate_Load);
            this.Name = "frmBoCreate";

        }
        #endregion

        private Title Title1;
        internal Smobiler.Core.Controls.Panel Panel2;
        internal Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.Panel Panel1;
        internal Smobiler.Core.Controls.Panel Panel3;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.TextBox txtphone;
        internal Smobiler.Core.Controls.DatePicker DPickerCO;
        internal Smobiler.Core.Controls.DatePicker DPickerRs;
        internal Smobiler.Core.Controls.Button btnBOMan;
        internal Smobiler.Core.Controls.Button btnBOMan1;
        internal Smobiler.Core.Controls.Button btnPro;
        internal Smobiler.Core.Controls.Button btnPro1;
        internal Smobiler.Core.Controls.Button btnTeam;
        internal Smobiler.Core.Controls.Button btnTeam1;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox btnLocation;
        internal Smobiler.Core.Controls.Panel Panel4;
        internal Smobiler.Core.Controls.PopList PopBOMan;
        internal Smobiler.Core.Controls.PopList PopPro;
        internal Smobiler.Core.Controls.PopList PopTeam;
        internal Smobiler.Core.Controls.PopList PopLocation;
        private Smobiler.Core.Controls.ListView ListAss;
        internal Smobiler.Core.Controls.TextBox txtManager;
        private Smobiler.Device.R2000Scanner r2000Scanner1;
        private Smobiler.Core.Controls.BarcodeScanner barcodeScanner1;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label Label20;

    }
}
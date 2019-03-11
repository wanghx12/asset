using SMOSEC.UI.UserControl;

namespace SMOSEC.UI.MasterData
{
    partial class frmAssetsDetailEdit : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssetsDetailEdit()
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
            this.Button1 = new Smobiler.Core.Controls.Button();
            this.CamPicture = new Smobiler.Core.Controls.Camera();
            this.Panel1 = new Smobiler.Core.Controls.Panel();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.Label10 = new Smobiler.Core.Controls.Label();
            this.Label11 = new Smobiler.Core.Controls.Label();
            this.Label14 = new Smobiler.Core.Controls.Label();
            this.txtNUm = new Smobiler.Core.Controls.TextBox();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.txtSpe = new Smobiler.Core.Controls.Button();
            this.txtPro1 = new Smobiler.Core.Controls.Button();
            this.txtSN = new Smobiler.Core.Controls.TextBox();
            this.btnBrand = new Smobiler.Core.Controls.Button();
            this.txtTeam1 = new Smobiler.Core.Controls.Button();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.btnType1 = new Smobiler.Core.Controls.Button();
            this.Label17 = new Smobiler.Core.Controls.Label();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.txtRole1 = new Smobiler.Core.Controls.Button();
            this.txtAssID = new Smobiler.Core.Controls.TextBox();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.txtStatus1 = new Smobiler.Core.Controls.Button();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.txtUserman1 = new Smobiler.Core.Controls.Button();
            this.label16 = new Smobiler.Core.Controls.Label();
            this.label18 = new Smobiler.Core.Controls.Label();
            this.txtLocation = new Smobiler.Core.Controls.TextBox();
            this.txtBordate1 = new Smobiler.Core.Controls.DatePicker();
            this.txtRedate1 = new Smobiler.Core.Controls.DatePicker();
            this.ImgBtnForSN = new Smobiler.Core.Controls.ImageButton();
            this.txtPayman1 = new Smobiler.Core.Controls.Button();
            this.r2000Scanner1 = new Smobiler.Device.R2000Scanner();
            this.barcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            this.popBrand = new Smobiler.Core.Controls.PopList();
            this.popType = new Smobiler.Core.Controls.PopList();
            this.popRoom = new Smobiler.Core.Controls.PopList();
            this.popPayman = new Smobiler.Core.Controls.PopList();
            this.popPro = new Smobiler.Core.Controls.PopList();
            this.popTeam = new Smobiler.Core.Controls.PopList();
            this.popRole = new Smobiler.Core.Controls.PopList();
            this.popUser = new Smobiler.Core.Controls.PopList();
            this.popStatus = new Smobiler.Core.Controls.PopList();
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
            this.Title1.TitleText = "资产编辑";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Button1});
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 40);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(300, 30);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(63, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(172, 27);
            this.Button1.Text = "确定";
            this.Button1.Press += new System.EventHandler(this.Button1_Press);
            // 
            // CamPicture
            // 
            this.CamPicture.Name = "CamPicture";
            this.CamPicture.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.CamPicture_ImageCaptured);
            // 
            // Panel1
            // 
            this.Panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.Label6,
            this.Label7,
            this.Label8,
            this.Label9,
            this.Label10,
            this.Label11,
            this.Label14,
            this.txtNUm,
            this.txtName,
            this.txtSpe,
            this.txtPro1,
            this.txtSN,
            this.btnBrand,
            this.txtTeam1,
            this.btnType,
            this.btnType1,
            this.Label17,
            this.txtNote,
            this.Label1,
            this.txtRole1,
            this.txtAssID,
            this.label12,
            this.txtStatus1,
            this.label13,
            this.txtUserman1,
            this.label16,
            this.label18,
            this.txtLocation,
            this.txtBordate1,
            this.txtRedate1,
            this.ImgBtnForSN,
            this.txtPayman1});
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Flex = 10000;
            this.Panel1.Location = new System.Drawing.Point(0, 70);
            this.Panel1.Name = "Panel1";
            this.Panel1.Scrollable = true;
            this.Panel1.Size = new System.Drawing.Size(300, 410);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label2.Location = new System.Drawing.Point(0, 80);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(100, 40);
            this.Label2.Text = "资产编号";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.Location = new System.Drawing.Point(0, 40);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(100, 40);
            this.Label3.Text = "IP";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.Location = new System.Drawing.Point(0, 200);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(100, 40);
            this.Label4.Text = "资产类型";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.Location = new System.Drawing.Point(0, 240);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(100, 40);
            this.Label5.Text = "机房";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.Location = new System.Drawing.Point(0, 280);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(100, 40);
            this.Label6.Text = "位置";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Location = new System.Drawing.Point(0, 360);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(100, 40);
            this.Label7.Text = "挂账人";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.Location = new System.Drawing.Point(0, 400);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(100, 40);
            this.Label8.Text = "项目";
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.Location = new System.Drawing.Point(0, 120);
            this.Label9.Name = "Label9";
            this.Label9.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label9.Size = new System.Drawing.Size(100, 40);
            this.Label9.Text = "SN";
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label10.Location = new System.Drawing.Point(0, 160);
            this.Label10.Name = "Label10";
            this.Label10.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label10.Size = new System.Drawing.Size(100, 40);
            this.Label10.Text = "品牌型号";
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.White;
            this.Label11.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label11.Location = new System.Drawing.Point(0, 440);
            this.Label11.Name = "Label11";
            this.Label11.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label11.Size = new System.Drawing.Size(100, 40);
            this.Label11.Text = "团队";
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.Name = "Label14";
            this.Label14.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label14.Size = new System.Drawing.Size(100, 40);
            this.Label14.Text = "唯一号";
            // 
            // txtNUm
            // 
            this.txtNUm.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtNUm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNUm.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtNUm.Location = new System.Drawing.Point(100, 80);
            this.txtNUm.Name = "txtNUm";
            this.txtNUm.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtNUm.Size = new System.Drawing.Size(199, 40);
            this.txtNUm.WaterMarkText = "(选填)";
            this.txtNUm.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtName
            // 
            this.txtName.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtName.Location = new System.Drawing.Point(100, 40);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtName.Size = new System.Drawing.Size(199, 40);
            this.txtName.WaterMarkText = "(选填)";
            this.txtName.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtSpe
            // 
            this.txtSpe.BackColor = System.Drawing.Color.White;
            this.txtSpe.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSpe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSpe.BorderRadius = 0;
            this.txtSpe.ForeColor = System.Drawing.Color.Black;
            this.txtSpe.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSpe.Location = new System.Drawing.Point(100, 240);
            this.txtSpe.Name = "txtSpe";
            this.txtSpe.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSpe.Size = new System.Drawing.Size(200, 40);
            this.txtSpe.Text = "选择（必填）   > ";
            this.txtSpe.Press += new System.EventHandler(this.txtRoom_TextChanged);
            // 
            // txtPro1
            // 
            this.txtPro1.BackColor = System.Drawing.Color.White;
            this.txtPro1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPro1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPro1.BorderRadius = 0;
            this.txtPro1.ForeColor = System.Drawing.Color.Black;
            this.txtPro1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPro1.Location = new System.Drawing.Point(100, 400);
            this.txtPro1.Name = "txtPro1";
            this.txtPro1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPro1.Size = new System.Drawing.Size(200, 40);
            this.txtPro1.Text = "选择（选填）   > ";
            this.txtPro1.Press += new System.EventHandler(this.txtPro_TextChanged);
            // 
            // txtSN
            // 
            this.txtSN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSN.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSN.Location = new System.Drawing.Point(100, 120);
            this.txtSN.Name = "txtSN";
            this.txtSN.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSN.Size = new System.Drawing.Size(140, 40);
            this.txtSN.WaterMarkText = "(必填,支持扫码)";
            this.txtSN.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // btnBrand
            // 
            this.btnBrand.BackColor = System.Drawing.Color.White;
            this.btnBrand.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnBrand.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnBrand.BorderRadius = 0;
            this.btnBrand.ForeColor = System.Drawing.Color.Black;
            this.btnBrand.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnBrand.Location = new System.Drawing.Point(100, 160);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnBrand.Size = new System.Drawing.Size(200, 40);
            this.btnBrand.Text = "选择（必填）   > ";
            this.btnBrand.Press += new System.EventHandler(this.txtBrand1_TextChanged);
            // 
            // txtTeam1
            // 
            this.txtTeam1.BackColor = System.Drawing.Color.White;
            this.txtTeam1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtTeam1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtTeam1.BorderRadius = 0;
            this.txtTeam1.ForeColor = System.Drawing.Color.Black;
            this.txtTeam1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtTeam1.Location = new System.Drawing.Point(100, 440);
            this.txtTeam1.Name = "txtTeam1";
            this.txtTeam1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtTeam1.Size = new System.Drawing.Size(200, 40);
            this.txtTeam1.Text = "选择（选填）   > ";
            this.txtTeam1.Press += new System.EventHandler(this.txtTeam_TextChanged);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.White;
            this.btnType.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType.BorderRadius = 0;
            this.btnType.ForeColor = System.Drawing.Color.Black;
            this.btnType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnType.Location = new System.Drawing.Point(100, 200);
            this.btnType.Name = "btnType";
            this.btnType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnType.Size = new System.Drawing.Size(200, 40);
            this.btnType.Text = "选择（必填）   > ";
            this.btnType.Press += new System.EventHandler(this.txtType_TextChanged);
            // 
            // btnType1
            // 
            this.btnType1.Name = "btnType1";
            this.btnType1.Size = new System.Drawing.Size(0, 0);
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.White;
            this.Label17.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label17.Location = new System.Drawing.Point(0, 640);
            this.Label17.Name = "Label17";
            this.Label17.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label17.Size = new System.Drawing.Size(100, 55);
            this.Label17.Text = "备注";
            // 
            // txtNote
            // 
            this.txtNote.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtNote.Location = new System.Drawing.Point(100, 640);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 5F, 0F);
            this.txtNote.Size = new System.Drawing.Size(200, 55);
            this.txtNote.WaterMarkText = "(选填)";
            this.txtNote.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label1.Location = new System.Drawing.Point(0, 480);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(100, 40);
            this.Label1.Text = "角色";
            // 
            // txtRole1
            // 
            this.txtRole1.BackColor = System.Drawing.Color.White;
            this.txtRole1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtRole1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtRole1.BorderRadius = 0;
            this.txtRole1.ForeColor = System.Drawing.Color.Black;
            this.txtRole1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtRole1.Location = new System.Drawing.Point(100, 480);
            this.txtRole1.Name = "txtRole1";
            this.txtRole1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtRole1.Size = new System.Drawing.Size(200, 40);
            this.txtRole1.Text = "选择（选填）   > ";
            this.txtRole1.Press += new System.EventHandler(this.txtRole_TextChanged);
            // 
            // txtAssID
            // 
            this.txtAssID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAssID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtAssID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAssID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtAssID.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtAssID.Location = new System.Drawing.Point(100, 0);
            this.txtAssID.Name = "txtAssID";
            this.txtAssID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtAssID.ReadOnly = true;
            this.txtAssID.Size = new System.Drawing.Size(200, 40);
            this.txtAssID.Text = "20";
            this.txtAssID.WaterMarkText = "(必填)";
            this.txtAssID.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label12.Location = new System.Drawing.Point(0, 320);
            this.label12.Name = "label12";
            this.label12.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label12.Size = new System.Drawing.Size(100, 40);
            this.label12.Text = "状态";
            // 
            // txtStatus1
            // 
            this.txtStatus1.BackColor = System.Drawing.Color.White;
            this.txtStatus1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtStatus1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtStatus1.BorderRadius = 0;
            this.txtStatus1.ForeColor = System.Drawing.Color.Black;
            this.txtStatus1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtStatus1.Location = new System.Drawing.Point(100, 320);
            this.txtStatus1.Name = "txtStatus1";
            this.txtStatus1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtStatus1.Size = new System.Drawing.Size(200, 40);
            this.txtStatus1.Text = "选择（必填）   > ";
            this.txtStatus1.Press += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label13.Location = new System.Drawing.Point(0, 520);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label13.Size = new System.Drawing.Size(100, 40);
            this.label13.Text = "使用人";
            // 
            // txtUserman1
            // 
            this.txtUserman1.BackColor = System.Drawing.Color.White;
            this.txtUserman1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtUserman1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUserman1.BorderRadius = 0;
            this.txtUserman1.ForeColor = System.Drawing.Color.Black;
            this.txtUserman1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtUserman1.Location = new System.Drawing.Point(100, 520);
            this.txtUserman1.Name = "txtUserman1";
            this.txtUserman1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtUserman1.Size = new System.Drawing.Size(200, 40);
            this.txtUserman1.Text = "选择（选填）   > ";
            this.txtUserman1.Press += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label16.Location = new System.Drawing.Point(0, 560);
            this.label16.Name = "label16";
            this.label16.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label16.Size = new System.Drawing.Size(100, 40);
            this.label16.Text = "外借时间";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label18.Location = new System.Drawing.Point(0, 600);
            this.label18.Name = "label18";
            this.label18.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label18.Size = new System.Drawing.Size(100, 40);
            this.label18.Text = "归还时间";
            // 
            // txtLocation
            // 
            this.txtLocation.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtLocation.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtLocation.Location = new System.Drawing.Point(100, 280);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtLocation.Size = new System.Drawing.Size(199, 40);
            this.txtLocation.WaterMarkText = "(必填)";
            this.txtLocation.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtBordate1
            // 
            this.txtBordate1.BackColor = System.Drawing.Color.White;
            this.txtBordate1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtBordate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBordate1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtBordate1.Location = new System.Drawing.Point(100, 560);
            this.txtBordate1.Name = "txtBordate1";
            this.txtBordate1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtBordate1.Size = new System.Drawing.Size(200, 40);
            this.txtBordate1.ValueChanged += new System.EventHandler(this.txtBordate1_ValueChanged);
            // 
            // txtRedate1
            // 
            this.txtRedate1.BackColor = System.Drawing.Color.White;
            this.txtRedate1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtRedate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtRedate1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtRedate1.Location = new System.Drawing.Point(100, 600);
            this.txtRedate1.Name = "txtRedate1";
            this.txtRedate1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtRedate1.Size = new System.Drawing.Size(200, 40);
            this.txtRedate1.ValueChanged += new System.EventHandler(this.txtRedate1_ValueChanged);
            // 
            // ImgBtnForSN
            // 
            this.ImgBtnForSN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ImgBtnForSN.Location = new System.Drawing.Point(260, 126);
            this.ImgBtnForSN.Name = "ImgBtnForSN";
            this.ImgBtnForSN.ResourceID = "scan";
            this.ImgBtnForSN.Size = new System.Drawing.Size(28, 28);
            this.ImgBtnForSN.Press += new System.EventHandler(this.ImgBtnForAssId_Press);
            // 
            // txtPayman1
            // 
            this.txtPayman1.BackColor = System.Drawing.Color.White;
            this.txtPayman1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPayman1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPayman1.BorderRadius = 0;
            this.txtPayman1.ForeColor = System.Drawing.Color.Black;
            this.txtPayman1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPayman1.Location = new System.Drawing.Point(100, 360);
            this.txtPayman1.Name = "txtPayman1";
            this.txtPayman1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPayman1.Size = new System.Drawing.Size(200, 40);
            this.txtPayman1.Text = "选择（必填）   > ";
            this.txtPayman1.Press += new System.EventHandler(this.txtPayman_TextChanged);
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
            this.barcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned);
            // 
            // popBrand
            // 
            this.popBrand.Name = "popBrand";
            this.popBrand.Title = "品牌型号";
            this.popBrand.Selected += new System.EventHandler(this.popBrand_Selected);
            // 
            // popType
            // 
            this.popType.Name = "popType";
            this.popType.Title = "资产类型";
            this.popType.Selected += new System.EventHandler(this.popType_Selected);
            // 
            // popRoom
            // 
            this.popRoom.Name = "popRoom";
            this.popRoom.Title = "机房";
            this.popRoom.Selected += new System.EventHandler(this.popRoom_Selected);
            // 
            // popPayman
            // 
            this.popPayman.Name = "popPayman";
            this.popPayman.Title = "挂账人";
            this.popPayman.Selected += new System.EventHandler(this.popPayman_Selected);
            // 
            // popPro
            // 
            this.popPro.Name = "popPro";
            this.popPro.Title = "项目";
            this.popPro.Selected += new System.EventHandler(this.popPro_Selected);
            // 
            // popTeam
            // 
            this.popTeam.Name = "popTeam";
            this.popTeam.Title = "团队";
            this.popTeam.Selected += new System.EventHandler(this.popTeam_Selected);
            // 
            // popRole
            // 
            this.popRole.Name = "popRole";
            this.popRole.Title = "角色";
            this.popRole.Selected += new System.EventHandler(this.popRole_Selected);
            // 
            // popUser
            // 
            this.popUser.Name = "popUser";
            this.popUser.Title = "使用人";
            this.popUser.Selected += new System.EventHandler(this.popUser_Selected);
            // 
            // popStatus
            // 
            this.popStatus.Name = "popStatus";
            this.popStatus.Title = "资产状态";
            this.popStatus.Selected += new System.EventHandler(this.popStatus_Selected);
            // 
            // frmAssetsDetailEdit
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.CamPicture,
            this.r2000Scanner1,
            this.barcodeScanner1,
            this.popBrand,
            this.popType,
            this.popRoom,
            this.popPayman,
            this.popPro,
            this.popTeam,
            this.popRole,
            this.popUser,
            this.popStatus});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.Panel2,
            this.Panel1});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssetsDetailEdit_KeyDown);
            this.Load += new System.EventHandler(this.frmAssetsDetailEdit_Load);
            this.Name = "frmAssetsDetailEdit";

        }
        #endregion

        private Title Title1;
        internal Smobiler.Core.Controls.Panel Panel2;
        internal Smobiler.Core.Controls.Button Button1;
        internal Smobiler.Core.Controls.Camera CamPicture;
        internal Smobiler.Core.Controls.Panel Panel1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Label Label10;
        internal Smobiler.Core.Controls.Label Label11;
        internal Smobiler.Core.Controls.Label Label14;
        internal Smobiler.Core.Controls.TextBox txtNUm;
        internal Smobiler.Core.Controls.TextBox txtName;
        internal Smobiler.Core.Controls.Button txtSpe;
        internal Smobiler.Core.Controls.Button txtPro1;
        internal Smobiler.Core.Controls.TextBox txtSN;
        internal Smobiler.Core.Controls.Button txtTeam1;
        internal Smobiler.Core.Controls.Button btnType;
        internal Smobiler.Core.Controls.Button btnType1;
        //internal Smobiler.Core.Controls.Panel PanelImg;
        //internal Smobiler.Core.Controls.Image ImgPicture;
        internal Smobiler.Core.Controls.Label Label17;
        internal Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Button txtRole1;
        internal Smobiler.Core.Controls.TextBox txtAssID;
        internal Smobiler.Core.Controls.Label label12;
        internal Smobiler.Core.Controls.Button txtStatus1;
        internal Smobiler.Core.Controls.Label label13;
        internal Smobiler.Core.Controls.Button txtUserman1;
        internal Smobiler.Core.Controls.Label label16;
        internal Smobiler.Core.Controls.Label label18;
        private Smobiler.Core.Controls.TextBox txtLocation;
        private Smobiler.Core.Controls.DatePicker txtBordate1;
        private Smobiler.Core.Controls.DatePicker txtRedate1;
        private Smobiler.Device.R2000Scanner r2000Scanner1;
        private Smobiler.Core.Controls.BarcodeScanner barcodeScanner1;
        private Smobiler.Core.Controls.ImageButton ImgBtnForSN;
        internal Smobiler.Core.Controls.Button txtPayman1;
        private Smobiler.Core.Controls.PopList popBrand;
        internal Smobiler.Core.Controls.Button btnBrand;
        private Smobiler.Core.Controls.PopList popType;
        private Smobiler.Core.Controls.PopList popRoom;
        private Smobiler.Core.Controls.PopList popPayman;
        private Smobiler.Core.Controls.PopList popPro;
        private Smobiler.Core.Controls.PopList popTeam;
        private Smobiler.Core.Controls.PopList popRole;
        private Smobiler.Core.Controls.PopList popUser;
        private Smobiler.Core.Controls.PopList popStatus;

    }
}
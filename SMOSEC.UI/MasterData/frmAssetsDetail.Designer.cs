using SMOSEC.UI.UserControl;

namespace SMOSEC.UI.MasterData
{
    partial class frmAssetsDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssetsDetail()
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
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnEdit = new Smobiler.Core.Controls.Button();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            this.btnLog = new Smobiler.Core.Controls.Button();
            this.btnChange = new Smobiler.Core.Controls.Button();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label35 = new Smobiler.Core.Controls.Label();
            this.label36 = new Smobiler.Core.Controls.Label();
            this.label37 = new Smobiler.Core.Controls.Label();
            this.label38 = new Smobiler.Core.Controls.Label();
            this.label39 = new Smobiler.Core.Controls.Label();
            this.label40 = new Smobiler.Core.Controls.Label();
            this.label41 = new Smobiler.Core.Controls.Label();
            this.label42 = new Smobiler.Core.Controls.Label();
            this.label43 = new Smobiler.Core.Controls.Label();
            this.label44 = new Smobiler.Core.Controls.Label();
            this.label45 = new Smobiler.Core.Controls.Label();
            this.label46 = new Smobiler.Core.Controls.Label();
            this.txtNUm = new Smobiler.Core.Controls.TextBox();
            this.txtIP1 = new Smobiler.Core.Controls.TextBox();
            this.txtSPE1 = new Smobiler.Core.Controls.TextBox();
            this.txtPayman1 = new Smobiler.Core.Controls.TextBox();
            this.txtPro1 = new Smobiler.Core.Controls.TextBox();
            this.txtSN1 = new Smobiler.Core.Controls.TextBox();
            this.txtBrand1 = new Smobiler.Core.Controls.TextBox();
            this.label47 = new Smobiler.Core.Controls.Label();
            this.txtNote1 = new Smobiler.Core.Controls.TextBox();
            this.label48 = new Smobiler.Core.Controls.Label();
            this.txtAssId1 = new Smobiler.Core.Controls.TextBox();
            this.label49 = new Smobiler.Core.Controls.Label();
            this.txtStatus1 = new Smobiler.Core.Controls.TextBox();
            this.label50 = new Smobiler.Core.Controls.Label();
            this.txtUserman1 = new Smobiler.Core.Controls.TextBox();
            this.label51 = new Smobiler.Core.Controls.Label();
            this.txtType = new Smobiler.Core.Controls.TextBox();
            this.txtLocation1 = new Smobiler.Core.Controls.TextBox();
            this.txtRedate1 = new Smobiler.Core.Controls.TextBox();
            this.txtTeam1 = new Smobiler.Core.Controls.TextBox();
            this.txtRole1 = new Smobiler.Core.Controls.TextBox();
            this.txtBordate1 = new Smobiler.Core.Controls.TextBox();
            this.panel6 = new Smobiler.Core.Controls.Panel();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.popCurrentUser = new Smobiler.Core.Controls.PopList();
            this.posPrinter1 = new Smobiler.Device.PosPrinter();
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
            this.Title1.TitleText = "资产详情";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnEdit,
            this.btnDelete});
            this.plButton.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plButton.Location = new System.Drawing.Point(0, 40);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 35);
            // 
            // btnEdit
            // 
            this.btnEdit.Flex = 1;
            this.btnEdit.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(0, 0);
            this.btnEdit.Text = "修改资产";
            this.btnEdit.Press += new System.EventHandler(this.btnEdit_Press);
            // 
            // btnDelete
            // 
            this.btnDelete.Flex = 1;
            this.btnDelete.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(0, 0);
            this.btnDelete.Text = "资产删除";
            this.btnDelete.Press += new System.EventHandler(this.btnDelete_Press);
            // 
            // btnLog
            // 
            this.btnLog.Flex = 1;
            this.btnLog.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(0, 0);
            this.btnLog.Text = "处理记录";
            this.btnLog.Press += new System.EventHandler(this.btnLog_Press);
            // 
            // btnChange
            // 
            this.btnChange.Flex = 1;
            this.btnChange.Margin = new Smobiler.Core.Controls.Margin(2F, 5F, 2F, 5F);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(0, 0);
            this.btnChange.Text = "使用者变更";
            this.btnChange.Press += new System.EventHandler(this.btnChange_Press);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label35,
            this.label36,
            this.label37,
            this.label38,
            this.label39,
            this.label40,
            this.label41,
            this.label42,
            this.label43,
            this.label44,
            this.label45,
            this.label46,
            this.txtNUm,
            this.txtIP1,
            this.txtSPE1,
            this.txtPayman1,
            this.txtPro1,
            this.txtSN1,
            this.txtBrand1,
            this.label47,
            this.txtNote1,
            this.label48,
            this.txtAssId1,
            this.label49,
            this.txtStatus1,
            this.label50,
            this.txtUserman1,
            this.label51,
            this.txtType,
            this.txtLocation1,
            this.txtRedate1,
            this.txtTeam1,
            this.txtRole1,
            this.txtBordate1});
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Flex = 10000;
            this.panel5.Location = new System.Drawing.Point(0, 70);
            this.panel5.Name = "panel5";
            this.panel5.Scrollable = true;
            this.panel5.Size = new System.Drawing.Size(300, 410);
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.White;
            this.label35.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label35.Location = new System.Drawing.Point(0, 80);
            this.label35.Name = "label35";
            this.label35.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label35.Size = new System.Drawing.Size(100, 40);
            this.label35.Text = "资产编号";
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.White;
            this.label36.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label36.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label36.Location = new System.Drawing.Point(0, 40);
            this.label36.Name = "label36";
            this.label36.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label36.Size = new System.Drawing.Size(100, 40);
            this.label36.Text = "IP";
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.White;
            this.label37.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label37.Location = new System.Drawing.Point(0, 200);
            this.label37.Name = "label37";
            this.label37.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label37.Size = new System.Drawing.Size(100, 40);
            this.label37.Text = "资产类型";
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.White;
            this.label38.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label38.Location = new System.Drawing.Point(0, 240);
            this.label38.Name = "label38";
            this.label38.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label38.Size = new System.Drawing.Size(100, 40);
            this.label38.Text = "机房";
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.White;
            this.label39.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label39.Location = new System.Drawing.Point(0, 280);
            this.label39.Name = "label39";
            this.label39.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label39.Size = new System.Drawing.Size(100, 40);
            this.label39.Text = "位置";
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.White;
            this.label40.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label40.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label40.Location = new System.Drawing.Point(0, 360);
            this.label40.Name = "label40";
            this.label40.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label40.Size = new System.Drawing.Size(100, 40);
            this.label40.Text = "挂账人";
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.White;
            this.label41.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label41.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label41.Location = new System.Drawing.Point(0, 400);
            this.label41.Name = "label41";
            this.label41.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label41.Size = new System.Drawing.Size(100, 40);
            this.label41.Text = "项目";
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.White;
            this.label42.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label42.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label42.Location = new System.Drawing.Point(0, 120);
            this.label42.Name = "label42";
            this.label42.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label42.Size = new System.Drawing.Size(100, 40);
            this.label42.Text = "SN";
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.Color.White;
            this.label43.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label43.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label43.Location = new System.Drawing.Point(0, 160);
            this.label43.Name = "label43";
            this.label43.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label43.Size = new System.Drawing.Size(100, 40);
            this.label43.Text = "品牌型号";
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.White;
            this.label44.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label44.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label44.Location = new System.Drawing.Point(0, 440);
            this.label44.Name = "label44";
            this.label44.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label44.Size = new System.Drawing.Size(100, 40);
            this.label44.Text = "团队";
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.White;
            this.label45.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label45.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label45.Name = "label45";
            this.label45.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label45.Size = new System.Drawing.Size(100, 40);
            this.label45.Text = "唯一号";
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.White;
            this.label46.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label46.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label46.Location = new System.Drawing.Point(0, 600);
            this.label46.Name = "label46";
            this.label46.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label46.Size = new System.Drawing.Size(100, 40);
            this.label46.Text = "归还时间";
            // 
            // txtNUm
            // 
            this.txtNUm.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtNUm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNUm.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtNUm.Location = new System.Drawing.Point(100, 80);
            this.txtNUm.Name = "txtNUm";
            this.txtNUm.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtNUm.ReadOnly = true;
            this.txtNUm.Size = new System.Drawing.Size(199, 40);
            this.txtNUm.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtIP1
            // 
            this.txtIP1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtIP1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtIP1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtIP1.Location = new System.Drawing.Point(100, 40);
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtIP1.ReadOnly = true;
            this.txtIP1.Size = new System.Drawing.Size(199, 40);
            this.txtIP1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtSPE1
            // 
            this.txtSPE1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSPE1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSPE1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSPE1.Location = new System.Drawing.Point(100, 240);
            this.txtSPE1.Name = "txtSPE1";
            this.txtSPE1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSPE1.ReadOnly = true;
            this.txtSPE1.Size = new System.Drawing.Size(199, 40);
            this.txtSPE1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtPayman1
            // 
            this.txtPayman1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPayman1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPayman1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPayman1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtPayman1.Location = new System.Drawing.Point(100, 360);
            this.txtPayman1.Name = "txtPayman1";
            this.txtPayman1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPayman1.ReadOnly = true;
            this.txtPayman1.Size = new System.Drawing.Size(199, 40);
            this.txtPayman1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtPro1
            // 
            this.txtPro1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPro1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPro1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPro1.Location = new System.Drawing.Point(100, 400);
            this.txtPro1.Name = "txtPro1";
            this.txtPro1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPro1.ReadOnly = true;
            this.txtPro1.Size = new System.Drawing.Size(199, 40);
            this.txtPro1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtSN1
            // 
            this.txtSN1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSN1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSN1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSN1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtSN1.Location = new System.Drawing.Point(100, 120);
            this.txtSN1.Name = "txtSN1";
            this.txtSN1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSN1.ReadOnly = true;
            this.txtSN1.Size = new System.Drawing.Size(199, 40);
            this.txtSN1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtBrand1
            // 
            this.txtBrand1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtBrand1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBrand1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtBrand1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtBrand1.Location = new System.Drawing.Point(100, 160);
            this.txtBrand1.Name = "txtBrand1";
            this.txtBrand1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtBrand1.ReadOnly = true;
            this.txtBrand1.Size = new System.Drawing.Size(199, 40);
            this.txtBrand1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.White;
            this.label47.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label47.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label47.Location = new System.Drawing.Point(0, 640);
            this.label47.Name = "label47";
            this.label47.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label47.Size = new System.Drawing.Size(100, 55);
            this.label47.Text = "备注";
            // 
            // txtNote1
            // 
            this.txtNote1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtNote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote1.Location = new System.Drawing.Point(100, 640);
            this.txtNote1.Multiline = true;
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Padding = new Smobiler.Core.Controls.Padding(0F, 5F, 5F, 0F);
            this.txtNote1.ReadOnly = true;
            this.txtNote1.Size = new System.Drawing.Size(200, 55);
            this.txtNote1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.White;
            this.label48.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label48.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label48.Location = new System.Drawing.Point(0, 480);
            this.label48.Name = "label48";
            this.label48.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label48.Size = new System.Drawing.Size(100, 40);
            this.label48.Text = "角色";
            // 
            // txtAssId1
            // 
            this.txtAssId1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtAssId1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAssId1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtAssId1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtAssId1.Location = new System.Drawing.Point(100, 0);
            this.txtAssId1.Name = "txtAssId1";
            this.txtAssId1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtAssId1.ReadOnly = true;
            this.txtAssId1.Size = new System.Drawing.Size(200, 40);
            this.txtAssId1.WaterMarkText = "(必填)";
            this.txtAssId1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.White;
            this.label49.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label49.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label49.Location = new System.Drawing.Point(0, 320);
            this.label49.Name = "label49";
            this.label49.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label49.Size = new System.Drawing.Size(100, 40);
            this.label49.Text = "状态";
            // 
            // txtStatus1
            // 
            this.txtStatus1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtStatus1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtStatus1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtStatus1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtStatus1.Location = new System.Drawing.Point(100, 320);
            this.txtStatus1.Name = "txtStatus1";
            this.txtStatus1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtStatus1.ReadOnly = true;
            this.txtStatus1.Size = new System.Drawing.Size(199, 40);
            this.txtStatus1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.White;
            this.label50.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label50.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label50.Location = new System.Drawing.Point(0, 520);
            this.label50.Name = "label50";
            this.label50.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label50.Size = new System.Drawing.Size(100, 40);
            this.label50.Text = "使用人";
            // 
            // txtUserman1
            // 
            this.txtUserman1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtUserman1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUserman1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtUserman1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtUserman1.Location = new System.Drawing.Point(100, 520);
            this.txtUserman1.Name = "txtUserman1";
            this.txtUserman1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtUserman1.ReadOnly = true;
            this.txtUserman1.Size = new System.Drawing.Size(199, 40);
            this.txtUserman1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.White;
            this.label51.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label51.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label51.Location = new System.Drawing.Point(0, 560);
            this.label51.Name = "label51";
            this.label51.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label51.Size = new System.Drawing.Size(100, 40);
            this.label51.Text = "外借时间";
            // 
            // txtType
            // 
            this.txtType.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtType.Location = new System.Drawing.Point(100, 200);
            this.txtType.Name = "txtType";
            this.txtType.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(200, 40);
            // 
            // txtLocation1
            // 
            this.txtLocation1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtLocation1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtLocation1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtLocation1.Location = new System.Drawing.Point(100, 280);
            this.txtLocation1.Name = "txtLocation1";
            this.txtLocation1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtLocation1.ReadOnly = true;
            this.txtLocation1.Size = new System.Drawing.Size(199, 40);
            this.txtLocation1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtRedate1
            // 
            this.txtRedate1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtRedate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtRedate1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtRedate1.Location = new System.Drawing.Point(100, 600);
            this.txtRedate1.Name = "txtRedate1";
            this.txtRedate1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtRedate1.ReadOnly = true;
            this.txtRedate1.Size = new System.Drawing.Size(200, 40);
            // 
            // txtTeam1
            // 
            this.txtTeam1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtTeam1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtTeam1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtTeam1.Location = new System.Drawing.Point(100, 440);
            this.txtTeam1.Name = "txtTeam1";
            this.txtTeam1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtTeam1.ReadOnly = true;
            this.txtTeam1.Size = new System.Drawing.Size(200, 40);
            // 
            // txtRole1
            // 
            this.txtRole1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtRole1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtRole1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtRole1.Location = new System.Drawing.Point(100, 480);
            this.txtRole1.Name = "txtRole1";
            this.txtRole1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtRole1.ReadOnly = true;
            this.txtRole1.Size = new System.Drawing.Size(200, 40);
            // 
            // txtBordate1
            // 
            this.txtBordate1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtBordate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtBordate1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtBordate1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtBordate1.Location = new System.Drawing.Point(100, 560);
            this.txtBordate1.Name = "txtBordate1";
            this.txtBordate1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtBordate1.ReadOnly = true;
            this.txtBordate1.Size = new System.Drawing.Size(199, 40);
            this.txtBordate1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // panel6
            // 
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 100);
            // 
            // image2
            // 
            this.image2.Name = "image2";
            this.image2.Size = new System.Drawing.Size(45, 45);
            // 
            // popCurrentUser
            // 
            this.popCurrentUser.Name = "popCurrentUser";
            // 
            // posPrinter1
            // 
            this.posPrinter1.Name = "posPrinter1";
            // 
            // frmAssetsDetail
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popCurrentUser,
            this.posPrinter1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.panel5});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssetsDetail_KeyDown);
            this.Load += new System.EventHandler(this.frmAssetsDetail_Load);
            this.Name = "frmAssetsDetail";

        }

        #endregion

        private Title Title1;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnEdit;
        internal Smobiler.Core.Controls.Button btnLog;
        internal Smobiler.Core.Controls.Button btnChange;
        internal Smobiler.Core.Controls.Panel panel5;
        internal Smobiler.Core.Controls.Label label35;
        internal Smobiler.Core.Controls.Label label36;
        internal Smobiler.Core.Controls.Label label37;
        internal Smobiler.Core.Controls.Label label38;
        internal Smobiler.Core.Controls.Label label39;
        internal Smobiler.Core.Controls.Label label40;
        internal Smobiler.Core.Controls.Label label41;
        internal Smobiler.Core.Controls.Label label42;
        internal Smobiler.Core.Controls.Label label43;
        internal Smobiler.Core.Controls.Label label44;
        internal Smobiler.Core.Controls.Label label45;
        internal Smobiler.Core.Controls.Label label46;
        internal Smobiler.Core.Controls.TextBox txtNUm;
        internal Smobiler.Core.Controls.TextBox txtIP1;
        internal Smobiler.Core.Controls.TextBox txtSPE1;
        internal Smobiler.Core.Controls.TextBox txtPayman1;
        internal Smobiler.Core.Controls.TextBox txtPro1;
        internal Smobiler.Core.Controls.TextBox txtSN1;
        internal Smobiler.Core.Controls.TextBox txtBrand1;
        internal Smobiler.Core.Controls.Panel panel6;
        internal Smobiler.Core.Controls.Image image2;
        internal Smobiler.Core.Controls.Label label47;
        internal Smobiler.Core.Controls.TextBox txtNote1;
        internal Smobiler.Core.Controls.Label label48;
        internal Smobiler.Core.Controls.TextBox txtAssId1;
        internal Smobiler.Core.Controls.Label label49;
        internal Smobiler.Core.Controls.TextBox txtStatus1;
        internal Smobiler.Core.Controls.Label label50;
        internal Smobiler.Core.Controls.TextBox txtBordate1;
        internal Smobiler.Core.Controls.Label label51;
        private Smobiler.Core.Controls.TextBox txtType;
        private Smobiler.Core.Controls.TextBox txtLocation1;
        internal Smobiler.Core.Controls.TextBox txtRedate1;
        private Smobiler.Core.Controls.TextBox txtTeam1;
        private Smobiler.Core.Controls.TextBox txtRole1;
        private Smobiler.Core.Controls.PopList popCurrentUser;
        private Smobiler.Device.PosPrinter posPrinter1;
        internal Smobiler.Core.Controls.Button btnDelete;
        internal Smobiler.Core.Controls.TextBox txtUserman1;
    }
}
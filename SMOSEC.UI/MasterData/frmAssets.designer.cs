using SMOSEC.UI.UserControl;

namespace SMOSEC.UI.MasterData
{
    partial class frmAssets : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssets()
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
            Smobiler.Core.Controls.PopListGroup popListGroup1 = new Smobiler.Core.Controls.PopListGroup();
            Smobiler.Core.Controls.PopListItem popListItem1 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem2 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem3 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem4 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem5 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem6 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.PopListItem popListItem7 = new Smobiler.Core.Controls.PopListItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem1 = new Smobiler.Core.Controls.ActionButtonItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem2 = new Smobiler.Core.Controls.ActionButtonItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem3 = new Smobiler.Core.Controls.ActionButtonItem();
            this.txtFactor = new Smobiler.Core.Controls.TextBox();
            this.fiSearch = new Smobiler.Core.Controls.FontIcon();
            this.r2000Scanner1 = new Smobiler.Device.R2000Scanner();
            this.fontIcon3 = new Smobiler.Core.Controls.FontIcon();
            this.txtSnOrName = new Smobiler.Core.Controls.TextBox();
            this.barcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            this.posPrinter1 = new Smobiler.Device.PosPrinter();
            this.popType = new Smobiler.Core.Controls.PopList();
            this.popStatus = new Smobiler.Core.Controls.PopList();
            this.popDep = new Smobiler.Core.Controls.PopList();
            this.plSearch = new Smobiler.Core.Controls.Panel();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.panelScan1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.panelScan2 = new Smobiler.Core.Controls.Panel();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.label20 = new Smobiler.Core.Controls.Label();
            this.tpSearch = new Smobiler.Core.Controls.Panel();
            this.btnDep = new Smobiler.Core.Controls.Button();
            this.btnStatus = new Smobiler.Core.Controls.Button();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.btnPro = new Smobiler.Core.Controls.Button();
            this.btnPayman = new Smobiler.Core.Controls.Button();
            this.btnUseman = new Smobiler.Core.Controls.Button();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.popPro = new Smobiler.Core.Controls.PopList();
            this.gridAssRows = new Smobiler.Core.Controls.GridView();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.Title1 = new SMOSEC.UI.UserControl.MenuTitle();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.popPayman = new Smobiler.Core.Controls.PopList();
            this.popUseman = new Smobiler.Core.Controls.PopList();
            // 
            // txtFactor
            // 
            this.txtFactor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.txtFactor.Size = new System.Drawing.Size(183, 40);
            this.txtFactor.WaterMarkText = "请输入资产唯一号或资产条码";
            // 
            // fiSearch
            // 
            this.fiSearch.BackColor = System.Drawing.Color.White;
            this.fiSearch.Border = new Smobiler.Core.Controls.Border(1F, 0F, 0F, 0F);
            this.fiSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.fiSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.fiSearch.Location = new System.Drawing.Point(183, 0);
            this.fiSearch.Name = "fiSearch";
            this.fiSearch.ResourceID = "search";
            this.fiSearch.Size = new System.Drawing.Size(40, 40);
            // 
            // r2000Scanner1
            // 
            this.r2000Scanner1.Name = "r2000Scanner1";
            // 
            // fontIcon3
            // 
            this.fontIcon3.ForeColor = System.Drawing.Color.Silver;
            this.fontIcon3.Location = new System.Drawing.Point(10, 2);
            this.fontIcon3.Name = "fontIcon3";
            this.fontIcon3.ResourceID = "search";
            this.fontIcon3.Size = new System.Drawing.Size(16, 16);
            // 
            // txtSnOrName
            // 
            this.txtSnOrName.BackColor = System.Drawing.Color.Transparent;
            this.txtSnOrName.Location = new System.Drawing.Point(40, 0);
            this.txtSnOrName.Name = "txtSnOrName";
            this.txtSnOrName.Size = new System.Drawing.Size(200, 20);
            this.txtSnOrName.WaterMarkText = "请输入唯一号或资产条码";
            this.txtSnOrName.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.txtSnOrName.TextChanged += new System.EventHandler(this.txtFactor_TextChanged);
            // 
            // barcodeScanner1
            // 
            this.barcodeScanner1.Name = "barcodeScanner1";
            this.barcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned);
            // 
            // posPrinter1
            // 
            this.posPrinter1.Name = "posPrinter1";
            // 
            // popType
            // 
            this.popType.Name = "popType";
            this.popType.Title = "类型选择";
            this.popType.Selected += new System.EventHandler(this.popType_Selected);
            // 
            // popStatus
            // 
            popListItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem1.Text = "全部";
            popListItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem2.Text = "在用";
            popListItem2.Value = "0";
            popListItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem3.Text = "闲置";
            popListItem3.Value = "1";
            popListItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem4.Text = "送测";
            popListItem4.Value = "2";
            popListItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem5.Text = "外借";
            popListItem5.Value = "3";
            popListItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem6.Text = "损坏";
            popListItem6.Value = "4";
            popListItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            popListItem7.Text = "未知";
            popListItem7.Value = "5";
            popListGroup1.Items.AddRange(new Smobiler.Core.Controls.PopListItem[] {
            popListItem1,
            popListItem2,
            popListItem3,
            popListItem4,
            popListItem5,
            popListItem6,
            popListItem7});
            popListGroup1.Value = null;
            this.popStatus.Groups.AddRange(new Smobiler.Core.Controls.PopListGroup[] {
            popListGroup1});
            this.popStatus.Name = "popStatus";
            this.popStatus.Title = "资产状态";
            this.popStatus.Selected += new System.EventHandler(this.popStatus_Selected);
            // 
            // popDep
            // 
            this.popDep.Name = "popDep";
            this.popDep.Title = "机房选择";
            this.popDep.Selected += new System.EventHandler(this.popDep_Selected);
            // 
            // plSearch
            // 
            this.plSearch.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imageButton1,
            this.panel1,
            this.imageButton2});
            this.plSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.plSearch.Location = new System.Drawing.Point(0, 95);
            this.plSearch.Name = "plSearch";
            this.plSearch.Size = new System.Drawing.Size(300, 45);
            // 
            // imageButton1
            // 
            this.imageButton1.BackColor = System.Drawing.Color.White;
            this.imageButton1.Location = new System.Drawing.Point(15, 8);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "scan";
            this.imageButton1.Size = new System.Drawing.Size(28, 28);
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderRadius = 4;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon1,
            this.txtNote});
            this.panel1.Location = new System.Drawing.Point(50, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Silver;
            this.fontIcon1.Location = new System.Drawing.Point(10, 2);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "search";
            this.fontIcon1.Size = new System.Drawing.Size(16, 16);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.Transparent;
            this.txtNote.Location = new System.Drawing.Point(40, 0);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(150, 20);
            this.txtNote.WaterMarkText = "请输入唯一号或资产条码";
            this.txtNote.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(183)))));
            this.txtNote.TextChanged += new System.EventHandler(this.txtFactor_TextChanged);
            // 
            // imageButton2
            // 
            this.imageButton2.BackColor = System.Drawing.Color.White;
            this.imageButton2.IconColor = System.Drawing.Color.Gray;
            this.imageButton2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton2.Location = new System.Drawing.Point(260, 8);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.ResourceID = "refresh";
            this.imageButton2.ResourcePath = "";
            this.imageButton2.Size = new System.Drawing.Size(28, 28);
            this.imageButton2.Press += new System.EventHandler(this.imageButton2_Press);
            // 
            // panelScan1
            // 
            this.panelScan1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label10});
            this.panelScan1.Location = new System.Drawing.Point(15, 40);
            this.panelScan1.Name = "panelScan1";
            this.panelScan1.Size = new System.Drawing.Size(120, 28);
            this.panelScan1.Touchable = true;
            this.panelScan1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(1, 1);
            this.image1.Name = "image1";
            this.image1.ResourceID = "scan";
            this.image1.Size = new System.Drawing.Size(28, 28);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(38, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.Text = "扫描机房";
            // 
            // panelScan2
            // 
            this.panelScan2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image2,
            this.label20});
            this.panelScan2.Location = new System.Drawing.Point(165, 40);
            this.panelScan2.Name = "panelScan2";
            this.panelScan2.Size = new System.Drawing.Size(120, 28);
            this.panelScan2.Touchable = true;
            this.panelScan2.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(1, 1);
            this.image2.Name = "image2";
            this.image2.ResourceID = "scan";
            this.image2.Size = new System.Drawing.Size(28, 28);
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(38, 2);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 25);
            this.label20.Text = "扫描挂账人";
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.Color.White;
            this.tpSearch.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.tpSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tpSearch.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnDep,
            this.btnStatus,
            this.btnType,
            this.btnPro,
            this.btnPayman,
            this.btnUseman,
            this.Label1});
            this.tpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpSearch.Location = new System.Drawing.Point(250, 55);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Size = new System.Drawing.Size(300, 60);
            // 
            // btnDep
            // 
            this.btnDep.BackColor = System.Drawing.Color.White;
            this.btnDep.BorderRadius = 0;
            this.btnDep.ForeColor = System.Drawing.Color.Black;
            this.btnDep.Location = new System.Drawing.Point(10, 0);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(70, 30);
            this.btnDep.Text = "机房选择▼";
            this.btnDep.Press += new System.EventHandler(this.btnDep_Press);
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.White;
            this.btnStatus.BorderRadius = 0;
            this.btnStatus.ForeColor = System.Drawing.Color.Black;
            this.btnStatus.Location = new System.Drawing.Point(80, 0);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(70, 30);
            this.btnStatus.Text = "资产状态▼";
            this.btnStatus.Press += new System.EventHandler(this.btnStatus_Press);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.White;
            this.btnType.BorderRadius = 0;
            this.btnType.ForeColor = System.Drawing.Color.Black;
            this.btnType.Location = new System.Drawing.Point(150, 0);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(70, 30);
            this.btnType.Text = "类别选择▼";
            this.btnType.Press += new System.EventHandler(this.btnType_Press);
            // 
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.Color.White;
            this.btnPro.BorderRadius = 0;
            this.btnPro.ForeColor = System.Drawing.Color.Black;
            this.btnPro.Location = new System.Drawing.Point(220, 0);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(70, 30);
            this.btnPro.Text = "项目选择▼";
            this.btnPro.Press += new System.EventHandler(this.btnPro_Press);
            // 
            // btnPayman
            // 
            this.btnPayman.BackColor = System.Drawing.Color.White;
            this.btnPayman.BorderRadius = 0;
            this.btnPayman.ForeColor = System.Drawing.Color.Black;
            this.btnPayman.Location = new System.Drawing.Point(10, 30);
            this.btnPayman.Name = "btnPayman";
            this.btnPayman.Size = new System.Drawing.Size(70, 30);
            this.btnPayman.Text = "挂账人▼";
            this.btnPayman.Press += new System.EventHandler(this.btnPayman_Press);
            // 
            // btnUseman
            // 
            this.btnUseman.BackColor = System.Drawing.Color.White;
            this.btnUseman.BorderRadius = 0;
            this.btnUseman.ForeColor = System.Drawing.Color.Black;
            this.btnUseman.Location = new System.Drawing.Point(80, 30);
            this.btnUseman.Name = "btnUseman";
            this.btnUseman.Size = new System.Drawing.Size(70, 30);
            this.btnUseman.Text = "使用人▼";
            this.btnUseman.Press += new System.EventHandler(this.btnUseman_Press);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(160, 30);
            this.Label1.Name = "Label1";
            //this.Label1.Size = new System.Drawing.Size(130, 30);
            // 
            // popPro
            // 
            this.popPro.Name = "popPro";
            this.popPro.Title = "项目选择";
            this.popPro.Selected += new System.EventHandler(this.popPro_Selected);
            // 
            // gridAssRows
            // 
            this.gridAssRows.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.gridAssRows.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridAssRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAssRows.Flex = 1;
            this.gridAssRows.Name = "gridAssRows";
            this.gridAssRows.PageSize = 5;
            this.gridAssRows.PageSizeLoadCompleteText = "已显示全部";
            this.gridAssRows.PageSizeLoadText = "下一页";
            this.gridAssRows.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridAssRows.PageSizeTextSize = 11F;
            this.gridAssRows.Size = new System.Drawing.Size(0, 0);
            this.gridAssRows.TemplateControlName = "frmAssetsExLayout";
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            });
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 30);
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel3});
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.Black;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TemplateData = null;
            this.Title1.TemplateItem = null;
            this.Title1.TitleText = "资产列表";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderRadius = 4;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon3,
            this.txtSnOrName});
            this.panel3.Location = new System.Drawing.Point(50, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 20);
            // 
            // popPayman
            // 
            this.popPayman.Name = "popPayman";
            this.popPayman.Title = "挂账人选择";
            this.popPayman.Selected += new System.EventHandler(this.popPayman_Selected);
            // 
            // popUseman
            // 
            this.popUseman.Name = "popUseman";
            this.popUseman.Title = "使用人选择";
            this.popUseman.Selected += new System.EventHandler(this.popUseman_Selected);
            // 
            // frmAssets
            // 
            this.ActionButton.ButtonSpacing = 12;
            this.ActionButton.Enabled = true;
            actionButtonItem1.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem1.Text = "资产新增";
            actionButtonItem2.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem2.Text = "资产借用";
            actionButtonItem3.ImageType = Smobiler.Core.Controls.ActionButtonImageType.Text;
            actionButtonItem3.Text = "维修登记";
            this.ActionButton.Items.AddRange(new Smobiler.Core.Controls.ActionButtonItem[] {
            actionButtonItem1,
            actionButtonItem2,
            actionButtonItem3});
            this.ActionButton.ItemSize = 45;
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.r2000Scanner1,
            this.barcodeScanner1,
            this.posPrinter1,
            this.popType,
            this.popStatus,
            this.popDep,
            this.popPro,
            this.popPayman,
            this.popUseman});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plSearch,
            this.tpSearch,
            this.gridAssRows});
            this.DrawerName = "LeftMenu";
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssets_KeyDown);
            this.ActionButtonPress += new Smobiler.Core.Controls.ActionButtonPressEventHandler(this.frmAssets_ActionButtonPress);
            this.Load += new System.EventHandler(this.frmAssets_Load);
            this.Name = "frmAssets";

        }
        #endregion

        private MenuTitle Title1;
        private Smobiler.Device.R2000Scanner r2000Scanner1;
        internal Smobiler.Core.Controls.TextBox txtFactor;
        internal Smobiler.Core.Controls.FontIcon fiSearch;
        private Smobiler.Core.Controls.BarcodeScanner barcodeScanner1;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.FontIcon fontIcon3;
        private Smobiler.Core.Controls.TextBox txtSnOrName;
        private Smobiler.Device.PosPrinter posPrinter1;
        private Smobiler.Core.Controls.PopList popType;
        private Smobiler.Core.Controls.PopList popStatus;
        private Smobiler.Core.Controls.PopList popDep;
        private Smobiler.Core.Controls.Panel plSearch;
        private Smobiler.Core.Controls.ImageButton imageButton1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.TextBox txtNote;
        private Smobiler.Core.Controls.Panel tpSearch;
        private Smobiler.Core.Controls.Button btnType;
        private Smobiler.Core.Controls.Button btnDep;
        private Smobiler.Core.Controls.Button btnStatus;
        internal Smobiler.Core.Controls.GridView gridAssRows;
        private Smobiler.Core.Controls.Button btnPro;
        private Smobiler.Core.Controls.PopList popPro;
        private Smobiler.Core.Controls.Label Label1;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.ImageButton imageButton2;
        private Smobiler.Core.Controls.Button btnPayman;
        private Smobiler.Core.Controls.Button btnUseman;
        private Smobiler.Core.Controls.PopList popPayman;
        private Smobiler.Core.Controls.PopList popUseman;
        private Smobiler.Core.Controls.Panel panelScan1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Panel panelScan2;
        private Smobiler.Core.Controls.Image image2;
        private Smobiler.Core.Controls.Label label20;
    }
}
using System;
using Smobiler.Core;
namespace SMOSEC.UI.UserInfo
{
    partial class frmMessage : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmMessage()
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
            this.title1 = new SMOSEC.UI.UserControl.Title();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.plUser = new Smobiler.Core.Controls.Panel();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.lblID = new Smobiler.Core.Controls.Label();
            this.plTel = new Smobiler.Core.Controls.Panel();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.lblPhone = new Smobiler.Core.Controls.Label();
            this.btnMessage = new Smobiler.Core.Controls.Button();
            this.plEmail = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblEmail = new Smobiler.Core.Controls.Label();
            this.plLocation = new Smobiler.Core.Controls.Panel();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.btnLocation = new Smobiler.Core.Controls.Button();
            this.plBirthday = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.dpkBirthday = new Smobiler.Core.Controls.DatePicker();
            this.plAddress = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.txtAddress = new Smobiler.Core.Controls.TextBox();
            this.plSex = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnSex = new Smobiler.Core.Controls.Button();
            this.Panel1 = new Smobiler.Core.Controls.Panel();
            this.imgUser = new Smobiler.Core.Controls.ImageButton();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.imgEdit = new Smobiler.Core.Controls.ImageButton();
            this.Camera1 = new Smobiler.Core.Controls.Camera();
            this.popSex = new Smobiler.Core.Controls.PopList();
            this.popLocation = new Smobiler.Core.Controls.PopList();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.title1.FontSize = 15F;
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(107, 51);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            this.title1.TemplateData = null;
            this.title1.TemplateItem = null;
            this.title1.TitleText = "个人信息";
            // 
            // spContent
            // 
            this.spContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6,
            this.plUser,
            this.plTel});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Location = new System.Drawing.Point(0, 180);
            this.spContent.Name = "spContent";
            this.spContent.Scrollable = true;
            this.spContent.Size = new System.Drawing.Size(300, 40);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(300, 30);
            this.label6.Text = "基本信息";
            // 
            // plUser
            // 
            this.plUser.BackColor = System.Drawing.Color.White;
            this.plUser.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plUser.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label7,
            this.lblID});
            this.plUser.Location = new System.Drawing.Point(0, 30);
            this.plUser.Name = "plUser";
            this.plUser.Size = new System.Drawing.Size(300, 35);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(80, 40);
            this.label7.Text = "账号";
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(145)))));
            this.lblID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblID.Location = new System.Drawing.Point(80, 0);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblID.Size = new System.Drawing.Size(220, 40);
            // 
            // plTel
            // 
            this.plTel.BackColor = System.Drawing.Color.White;
            this.plTel.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plTel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label2,
            this.lblPhone});
            this.plTel.Location = new System.Drawing.Point(0, 65);
            this.plTel.Name = "plTel";
            this.plTel.Size = new System.Drawing.Size(300, 35);
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(80, 35);
            this.Label2.Text = "类型";
            // 
            // lblPhone
            // 
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(145)))));
            this.lblPhone.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblPhone.Location = new System.Drawing.Point(80, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblPhone.Size = new System.Drawing.Size(220, 40);
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.White;
            this.btnMessage.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.btnMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMessage.BorderRadius = 0;
            this.btnMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.btnMessage.Location = new System.Drawing.Point(0, 135);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(300, 40);
            this.btnMessage.Text = "设置";
            this.btnMessage.Press += new System.EventHandler(this.btnMessage_Press);
            // 
            // plEmail
            // 
            this.plEmail.Name = "plEmail";
            this.plEmail.Size = new System.Drawing.Size(300, 100);
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            // 
            // lblEmail
            // 
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 35);
            // 
            // plLocation
            // 
            this.plLocation.Name = "plLocation";
            this.plLocation.Size = new System.Drawing.Size(300, 100);
            // 
            // label9
            // 
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 35);
            // 
            // btnLocation
            // 
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(0, 0);
            // 
            // plBirthday
            // 
            this.plBirthday.Name = "plBirthday";
            this.plBirthday.Size = new System.Drawing.Size(300, 100);
            // 
            // label4
            // 
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 35);
            // 
            // dpkBirthday
            // 
            this.dpkBirthday.Name = "dpkBirthday";
            this.dpkBirthday.Size = new System.Drawing.Size(0, 0);
            // 
            // plAddress
            // 
            this.plAddress.Name = "plAddress";
            this.plAddress.Size = new System.Drawing.Size(300, 100);
            // 
            // label5
            // 
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 35);
            // 
            // txtAddress
            // 
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 35);
            // 
            // plSex
            // 
            this.plSex.Name = "plSex";
            this.plSex.Size = new System.Drawing.Size(300, 100);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            // 
            // btnSex
            // 
            this.btnSex.Name = "btnSex";
            this.btnSex.Size = new System.Drawing.Size(0, 0);
            // 
            // Panel1
            // 
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // imgUser
            // 
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(0, 0);
            // 
            // lblName
            // 
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 35);
            // 
            // imgEdit
            // 
            this.imgEdit.Name = "imgEdit";
            this.imgEdit.Size = new System.Drawing.Size(0, 0);
            // 
            // Camera1
            // 
            this.Camera1.Name = "Camera1";
            // 
            // popSex
            // 
            this.popSex.Name = "popSex";
            // 
            // popLocation
            // 
            this.popLocation.Name = "popLocation";
            // 
            // frmMessage
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.Camera1,
            this.popSex,
            this.popLocation});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.spContent});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.Load += new System.EventHandler(this.frmMessage_Load);
            this.Name = "frmMessage";

        }
        #endregion

        private UserControl.Title title1;
        private Smobiler.Core.Controls.Panel spContent;
        internal Smobiler.Core.Controls.Panel plSex;
        private Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Button btnSex;
        internal Smobiler.Core.Controls.Panel plAddress;
        private Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.TextBox txtAddress;
        internal Smobiler.Core.Controls.Panel plBirthday;
        private Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.DatePicker dpkBirthday;
        private Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Panel plUser;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label lblID;
        internal Smobiler.Core.Controls.Panel plTel;
        private Smobiler.Core.Controls.Label Label2;
        private Smobiler.Core.Controls.Label lblPhone;
        internal Smobiler.Core.Controls.Panel plEmail;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lblEmail;
        internal Smobiler.Core.Controls.Button btnMessage;
        internal Smobiler.Core.Controls.Panel Panel1;
        internal Smobiler.Core.Controls.ImageButton imgUser;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.ImageButton imgEdit;
        internal Smobiler.Core.Controls.Camera Camera1;
        internal Smobiler.Core.Controls.PopList popSex;
        private Smobiler.Core.Controls.Panel plLocation;
        private Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.Button btnLocation;
        private Smobiler.Core.Controls.PopList popLocation;
    }
}
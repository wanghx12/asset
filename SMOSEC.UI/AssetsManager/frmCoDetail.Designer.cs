using System;
using Smobiler.Core;
using SMOSEC.UI.UserControl;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmCoDetail : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCoDetail()
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
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.Label8 = new Smobiler.Core.Controls.Label();
            this.txtCOMan = new Smobiler.Core.Controls.TextBox();
            this.txtDep = new Smobiler.Core.Controls.TextBox();
            this.txtPlace = new Smobiler.Core.Controls.TextBox();
            this.txtNote = new Smobiler.Core.Controls.TextBox();
            this.DPickerCO = new Smobiler.Core.Controls.DatePicker();
            this.DPickerRs = new Smobiler.Core.Controls.DatePicker();
            this.txtLocation = new Smobiler.Core.Controls.TextBox();
            this.txtHMan = new Smobiler.Core.Controls.TextBox();
            this.ListAss = new Smobiler.Core.Controls.ListView();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "���õ�����";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Panel3,
            this.ListAss});
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 62);
            this.Panel1.Name = "Panel1";
            this.Panel1.Scrollable = true;
            this.Panel1.Size = new System.Drawing.Size(300, 312);
            // 
            // Panel3
            // 
            this.Panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.Label2,
            this.Label3,
            this.Label4,
            this.Label5,
            this.Label6,
            this.Label7,
            this.Label8,
            this.txtCOMan,
            this.txtDep,
            this.txtPlace,
            this.txtNote,
            this.DPickerCO,
            this.DPickerRs,
            this.txtLocation,
            this.txtHMan});
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(300, 246);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            this.Label2.Location = new System.Drawing.Point(0, 30);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(100, 30);
            this.Label2.Text = "��������";
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
            this.Label3.Text = "ʹ�ò���";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.Location = new System.Drawing.Point(0, 90);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(100, 30);
            this.Label4.Text = "��Դ����";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.Location = new System.Drawing.Point(0, 120);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(100, 30);
            this.Label5.Text = "��ŵص�";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label6.Location = new System.Drawing.Point(0, 150);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(100, 30);
            this.Label6.Text = "Ԥ���˿�����";
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Location = new System.Drawing.Point(0, 180);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(100, 30);
            this.Label7.Text = "���ô�����";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label8.Location = new System.Drawing.Point(0, 210);
            this.Label8.Name = "Label8";
            this.Label8.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.Label8.Size = new System.Drawing.Size(100, 30);
            this.Label8.Text = "��ע";
            // 
            // txtCOMan
            // 
            this.txtCOMan.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtCOMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtCOMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtCOMan.Location = new System.Drawing.Point(100, 0);
            this.txtCOMan.Name = "txtCOMan";
            this.txtCOMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtCOMan.ReadOnly = true;
            this.txtCOMan.Size = new System.Drawing.Size(200, 30);
            // 
            // txtDep
            // 
            this.txtDep.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtDep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtDep.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtDep.Location = new System.Drawing.Point(100, 60);
            this.txtDep.Name = "txtDep";
            this.txtDep.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtDep.ReadOnly = true;
            this.txtDep.Size = new System.Drawing.Size(200, 30);
            // 
            // txtPlace
            // 
            this.txtPlace.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPlace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPlace.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtPlace.Location = new System.Drawing.Point(100, 120);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtPlace.ReadOnly = true;
            this.txtPlace.Size = new System.Drawing.Size(200, 30);
            // 
            // txtNote
            // 
            this.txtNote.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtNote.Location = new System.Drawing.Point(100, 210);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(200, 30);
            // 
            // DPickerCO
            // 
            this.DPickerCO.BackColor = System.Drawing.Color.White;
            this.DPickerCO.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.DPickerCO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DPickerCO.Enabled = false;
            this.DPickerCO.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.DPickerCO.Location = new System.Drawing.Point(100, 30);
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
            this.DPickerRs.Location = new System.Drawing.Point(100, 150);
            this.DPickerRs.Name = "DPickerRs";
            this.DPickerRs.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.DPickerRs.Size = new System.Drawing.Size(200, 30);
            // 
            // txtLocation
            // 
            this.txtLocation.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtLocation.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtLocation.Location = new System.Drawing.Point(100, 90);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(200, 30);
            // 
            // txtHMan
            // 
            this.txtHMan.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtHMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtHMan.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtHMan.Location = new System.Drawing.Point(100, 180);
            this.txtHMan.Name = "txtHMan";
            this.txtHMan.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtHMan.ReadOnly = true;
            this.txtHMan.Size = new System.Drawing.Size(200, 30);
            // 
            // ListAss
            // 
            this.ListAss.BackColor = System.Drawing.Color.White;
            this.ListAss.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.ListAss.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAss.Location = new System.Drawing.Point(0, 246);
            this.ListAss.Name = "ListAss";
            this.ListAss.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ListAss.PageSizeTextSize = 11F;
            this.ListAss.ShowSplitLine = true;
            this.ListAss.Size = new System.Drawing.Size(300, 210);
            this.ListAss.SplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ListAss.TemplateControlName = "OperDetailAssLayout";
            // 
            // frmCoDetail
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.Panel1});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.FrmCoDetail_KeyDown);
            this.Load += new System.EventHandler(this.FrmCoDetail_Load);
            this.Name = "frmCoDetail";

        }
        #endregion

        private Title Title1;
        internal Smobiler.Core.Controls.Panel Panel1;
        internal Smobiler.Core.Controls.Panel Panel3;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label Label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label Label6;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.Label Label8;
        internal Smobiler.Core.Controls.TextBox txtCOMan;
        internal Smobiler.Core.Controls.TextBox txtDep;
        internal Smobiler.Core.Controls.TextBox txtPlace;
        internal Smobiler.Core.Controls.TextBox txtNote;
        internal Smobiler.Core.Controls.DatePicker DPickerCO;
        internal Smobiler.Core.Controls.DatePicker DPickerRs;
        internal Smobiler.Core.Controls.TextBox txtLocation;
        internal Smobiler.Core.Controls.TextBox txtHMan;
        private Smobiler.Core.Controls.ListView ListAss;
    }
}
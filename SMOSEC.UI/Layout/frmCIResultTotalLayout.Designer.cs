using System;
using Smobiler.Core;
namespace SMOSEC.UI.Layout
{
    partial class frmCIResultTotalLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmCIResultTotalLayout()
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
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.plNumber = new Smobiler.Core.Controls.Panel();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.lblNumber = new Smobiler.Core.Controls.Label();
            this.plRealNumber = new Smobiler.Core.Controls.Panel();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.txtRealAmount = new Smobiler.Core.Controls.TextBox();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.button5 = new Smobiler.Core.Controls.Button();
            this.button6 = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnSure = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            // 
            // plContent
            // 
            this.plContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label1,
            this.plNumber,
            this.plRealNumber,
            this.plButton});
            this.plContent.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(280, 170);
            // 
            // Label1
            // 
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(280, 35);
            this.Label1.Text = "�������";
            // 
            // plNumber
            // 
            this.plNumber.BackColor = System.Drawing.Color.White;
            this.plNumber.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label10,
            this.lblNumber});
            this.plNumber.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plNumber.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plNumber.Name = "plNumber";
            this.plNumber.Size = new System.Drawing.Size(300, 50);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label10.Name = "label10";
            this.label10.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label10.Size = new System.Drawing.Size(75, 50);
            this.label10.Text = "Ӧ������";
            // 
            // lblNumber
            // 
            this.lblNumber.Border = new Smobiler.Core.Controls.Border(1F);
            this.lblNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.lblNumber.BorderRadius = 4;
            this.lblNumber.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblNumber.Location = new System.Drawing.Point(0, 10);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.lblNumber.Size = new System.Drawing.Size(195, 30);
            // 
            // plRealNumber
            // 
            this.plRealNumber.BackColor = System.Drawing.Color.White;
            this.plRealNumber.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label12,
            this.txtRealAmount});
            this.plRealNumber.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plRealNumber.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plRealNumber.Name = "plRealNumber";
            this.plRealNumber.Size = new System.Drawing.Size(300, 50);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label12.Name = "label12";
            this.label12.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label12.Size = new System.Drawing.Size(75, 50);
            this.label12.Text = "ʵ������";
            // 
            // txtRealAmount
            // 
            this.txtRealAmount.Border = new Smobiler.Core.Controls.Border(1F);
            this.txtRealAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.txtRealAmount.BorderRadius = 4;
            this.txtRealAmount.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtRealAmount.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtRealAmount.Location = new System.Drawing.Point(0, 10);
            this.txtRealAmount.Name = "txtRealAmount";
            this.txtRealAmount.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtRealAmount.Size = new System.Drawing.Size(195, 30);
            this.txtRealAmount.WaterMarkText = "ʵ������";
            // 
            // plButton
            // 
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button5,
            this.button6});
            this.plButton.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plButton.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 35);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button5.BorderRadius = 0;
            this.button5.Flex = 1;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 0);
            this.button5.Text = "ȡ��";
            this.button5.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button6.BorderRadius = 0;
            this.button6.Flex = 1;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(0, 0);
            this.button6.Text = "ȷ��";
            this.button6.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label2.Size = new System.Drawing.Size(75, 50);
            this.label2.Text = "Ӧ������";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label5.Size = new System.Drawing.Size(75, 50);
            this.label5.Text = "ʵ������";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.Flex = 1;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(0, 0);
            this.btnCancel.Text = "ȡ��";
            this.btnCancel.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // btnSure
            // 
            this.btnSure.BackColor = System.Drawing.Color.White;
            this.btnSure.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnSure.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSure.BorderRadius = 0;
            this.btnSure.Flex = 1;
            this.btnSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(0, 0);
            this.btnSure.Text = "ȷ��";
            this.btnSure.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label3.Size = new System.Drawing.Size(75, 50);
            this.label3.Text = "Ӧ������";
            // 
            // label6
            // 
            this.label6.Border = new Smobiler.Core.Controls.Border(1F);
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.label6.BorderRadius = 4;
            this.label6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label6.Location = new System.Drawing.Point(0, 10);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label6.Size = new System.Drawing.Size(195, 30);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label7.Size = new System.Drawing.Size(75, 50);
            this.label7.Text = "ʵ������";
            // 
            // textBox1
            // 
            this.textBox1.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.textBox1.BorderRadius = 4;
            this.textBox1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox1.Location = new System.Drawing.Point(0, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.textBox1.Size = new System.Drawing.Size(195, 30);
            this.textBox1.WaterMarkText = "ʵ������";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button1.BorderRadius = 0;
            this.button1.Flex = 1;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.Text = "ȡ��";
            this.button1.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button2.BorderRadius = 0;
            this.button2.Flex = 1;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.Text = "ȷ��";
            this.button2.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label4.Size = new System.Drawing.Size(75, 50);
            this.label4.Text = "Ӧ������";
            // 
            // label8
            // 
            this.label8.Border = new Smobiler.Core.Controls.Border(1F);
            this.label8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.label8.BorderRadius = 4;
            this.label8.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label8.Location = new System.Drawing.Point(0, 10);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label8.Size = new System.Drawing.Size(195, 30);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.label9.Size = new System.Drawing.Size(75, 50);
            this.label9.Text = "ʵ������";
            // 
            // textBox2
            // 
            this.textBox2.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.textBox2.BorderRadius = 4;
            this.textBox2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox2.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.textBox2.Location = new System.Drawing.Point(0, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.textBox2.Size = new System.Drawing.Size(195, 30);
            this.textBox2.WaterMarkText = "ʵ������";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 1F, 0F);
            this.button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button3.BorderRadius = 0;
            this.button3.Flex = 1;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.Text = "ȡ��";
            this.button3.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button4.BorderRadius = 0;
            this.button4.Flex = 1;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 0);
            this.button4.Text = "ȷ��";
            this.button4.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // frmCIResultTotalLayout
            // 
            this.BorderRadius = 8;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plContent});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(280, 170);
            this.Name = "frmCIResultTotalLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label1;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.TextBox textBox1;
        internal Smobiler.Core.Controls.Button button1;
        internal Smobiler.Core.Controls.Button button2;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Button btnCancel;
        internal Smobiler.Core.Controls.Button btnSure;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Label label8;
        internal Smobiler.Core.Controls.Label label9;
        internal Smobiler.Core.Controls.TextBox textBox2;
        internal Smobiler.Core.Controls.Button button3;
        internal Smobiler.Core.Controls.Button button4;
        internal Smobiler.Core.Controls.Panel plNumber;
        internal Smobiler.Core.Controls.Label label10;
        internal Smobiler.Core.Controls.Label lblNumber;
        private Smobiler.Core.Controls.Panel plRealNumber;
        internal Smobiler.Core.Controls.Label label12;
        internal Smobiler.Core.Controls.TextBox txtRealAmount;
        private Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button button5;
        internal Smobiler.Core.Controls.Button button6;
    }
}
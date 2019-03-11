using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.ComponentModel;

namespace SMOSEC.UI.UserControl
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    [System.ComponentModel.ToolboxItem(true)]
    partial class MenuTitle : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ��������
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("����")]
        public string TitleText
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;

            }
        }
        /// <summary>
        /// ���������С
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("���������С")]
        public float FontSize
        {
            get
            {
                return this.label1.FontSize;
            }
            set
            {
                this.label1.FontSize = value;

            }
        }
        /// <summary>
        /// �ı���ɫ
        /// </summary>
        [Browsable(true), Category("Appearance"), DefaultValue(""), Description("�ı���ɫ")]
        public System.Drawing.Color ForeColor
        {
            get
            {
                return this.label1.ForeColor;
            }
            set
            {
                this.label1.ForeColor = value;

            }
        }
        /// <summary>
        /// �����ʾ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel1_Press(object sender, EventArgs e)
        {
            this.Form.OpenDrawer();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.AssetsManager.Analyse
{
    partial class frmAssetsUseAnalyse : Smobiler.Core.Controls.MobileForm
    {
        /// <summary>
        /// �ֻ��Դ����ؼ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsUseAnalyse_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back) Client.Exit();
        }
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsUseAnalyse_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// ���ݰ�
        /// </summary>
        public void Bind()
        {

        }
    }
}
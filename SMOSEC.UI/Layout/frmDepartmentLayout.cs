using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SMOSEC.UI.Layout
{
    partial class frmDepartmentLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ��ת��������ϸ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Press(object sender, EventArgs e)
        {
            try
            {
                string D_ID = lblId.BindDataValue.ToString();
                Department.frmDepartmentDetail frm = new Department.frmDepartmentDetail();
                frm.D_ID = D_ID;
               this.Form . Show(frm, (MobileForm form, object args) =>
                {
                    if (frm.ShowResult == ShowResult.Yes)
                    {
                        ((Department.frmDepartment)this.Form ).Mode = DepartmentMode.�б�;
                        ((Department.frmDepartment)this.Form).Bind();
                    }
                });
            }
            catch(Exception ex)
            {
                this.Form.Toast(ex.Message , ToastLength.SHORT);
            }
        }

   
    }
}
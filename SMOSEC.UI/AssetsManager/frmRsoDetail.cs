using System;
using System.Data;
using Smobiler.Core.Controls;
using SMOSEC.DTOs.OutputDTO;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmRsoDetail : Smobiler.Core.Controls.MobileForm
    {
        #region ����
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������

        public string RsoId;      //�˿ⵥ���  
        #endregion

        /// <summary>
        /// �����˼�ʱ�رյ�ǰ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRsoDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// �����ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRsoDetail_Load(object sender, EventArgs e)
        {
            Bind();
        }

        /// <summary>
        /// ������
        /// </summary>
        public void Bind()
        {
            try
            {
                AssRestoreOrderOutputDto assRestoreOrderOutput = _autofacConfig.AssetsService.GetRsobyId(RsoId);
                if (assRestoreOrderOutput != null)
                {
                    txtHMan.Text = assRestoreOrderOutput.Handleman;
                    txtLocation.Text = assRestoreOrderOutput.LocationName ;
                    txtNote.Text = assRestoreOrderOutput.Note;
                    DPickerRs.Value = assRestoreOrderOutput.Restoredate;
                    txtPlace.Text = assRestoreOrderOutput.Place;
                }
                DataTable rowsTable = _autofacConfig.AssetsService.GetRowsByRsoid(RsoId);
                if (rowsTable != null)
                {
                    ListAss.DataSource = rowsTable;
                    ListAss.DataBind();
                }
                
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
using System;
using System.Data;
using Smobiler.Core.Controls;
using SMOSEC.DTOs.OutputDTO;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmCoDetail : Smobiler.Core.Controls.MobileForm
    {
        #region ����
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������

        public string CoId; //���õ����        

        #endregion


        /// <summary>
        /// �ֻ�������ʱ�رյ�ǰ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCoDetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// �����ʼ��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCoDetail_Load(object sender, EventArgs e)
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
                AssCollarOrderOutputDto assCollarOrderOutput = _autofacConfig.AssetsService.GetCobyId(CoId);
                if (assCollarOrderOutput != null)
                {
                    txtCOMan.Text = assCollarOrderOutput.Userid;
                    txtHMan.Text = assCollarOrderOutput.Handleman;
                    txtLocation.Text = assCollarOrderOutput.Locationid;
                    txtNote.Text = assCollarOrderOutput.Note;
                    DPickerCO.Value = assCollarOrderOutput.Collardate;
                    if (assCollarOrderOutput.Eptrestoredate != null)
                    {
                        DPickerRs.Value = assCollarOrderOutput.Eptrestoredate.Value;    
                    }
                    txtDep.Text = assCollarOrderOutput.Inusedep;
                    txtPlace.Text = assCollarOrderOutput.Place;
                }
                DataTable rowsTable = _autofacConfig.AssetsService.GetRowsByCoid(CoId);
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
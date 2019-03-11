using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMOSEC.DTOs.OutputDTO;
using Smobiler.Core;
using Smobiler.Core.Controls;
using ListView = Smobiler.Core.Controls.ListView;

using SMOSEC.DTOs.InputDTO;
using SMOSEC.CommLib;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmBoDetail : Smobiler.Core.Controls.MobileForm
    {
        private AutofacConfig _autofacConfig = new AutofacConfig();//����������
        public List<string> AssIdList = new List<string>(); //���������ASSID�ļ���
        public DataTable AssTable = new DataTable();   //�������ݵı��

        public int BoId;  //���õ����
        /// <summary>
        /// �����˼�����رմ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBODetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// �����ʼ��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBODetail_Load(object sender, EventArgs e)
        {
            if (AssTable.Columns.Count == 0)
            {
                AssTable.Columns.Add("ASSID");
                AssTable.Columns.Add("TYPE");
                AssTable.Columns.Add("BRAND");
                AssTable.Columns.Add("SN");
            }
            DataColumn[] keys = new DataColumn[1];
            keys[0] = AssTable.Columns["SN"];
            AssTable.PrimaryKey = keys;

            Bind();

        }

        /// <summary>
        /// ������
        /// </summary>
        public void Bind()
        {
            try
            {
                AssBorrowOrderOutputDto assBorrowOrderOutput = _autofacConfig.AssetsService.GetBobyId(BoId);
                if (assBorrowOrderOutput != null)
                {
                    txtphone.Text = assBorrowOrderOutput.phone;
                    txtBOMan.Text = assBorrowOrderOutput.bo_name;
                    DPickerCO.Value = (DateTime)assBorrowOrderOutput.give_time;
                    DPickerRs.Value = (DateTime)assBorrowOrderOutput.return_time;
                    txtHMan.Text = assBorrowOrderOutput.principal;
                    txtexpired.Text = assBorrowOrderOutput.expired.ToString();
                    txtpro.Text = assBorrowOrderOutput.pro_name;
                    txtteam.Text = assBorrowOrderOutput.team_name;
                    txtNote.Text = assBorrowOrderOutput.remark;
                    txtLocation.Text = assBorrowOrderOutput.position;
                }
                DataTable rowsTable = _autofacConfig.AssetsService.GetRowsByBoid(BoId);
                if (rowsTable != null)
                {
                    for (int i = 0; i < rowsTable.Rows.Count; i++)
                    {
                        AssIdList.Add(rowsTable.Rows[i][0].ToString());
                    }
                    ListAss.DataSource = rowsTable;
                    ListAss.DataBind();
                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ���ɨ�����ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelScan_Press(object sender, EventArgs e)
        {
            try
            {
                barcodeScanner1.GetBarcode();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// �ֻ�ɨ�赽��ά��ʱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barcodeScanner1_BarcodeScanned_1(object sender, BarcodeResultArgs e)
        {
            try
            {
                string barCode = e.Value;
                DataTable info = _autofacConfig.SettingService.GetUnUsedAssEx(barCode);
                if (info.Rows.Count == 0)
                {
                    throw new Exception("δ��������Ʒ���ҵ�����Ʒ");
                }
                else
                {
                    DataRow row = info.Rows[0];
                    var type = _autofacConfig.assTypeService.GetByID(int.Parse(row["asset_type_id"].ToString()));
                    var brand = _autofacConfig.assBrandService.GetByID(int.Parse(row["brand_id"].ToString()));
                    AddAss(int.Parse(row["id"].ToString()), barCode, type.name, brand.name);
                    BindListView(); //���°�����
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ������
        /// </summary>
        public void BindListView()
        {
            try
            {
                ListAss.DataSource = AssTable;
                ListAss.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// ����ʲ������
        /// </summary>
        /// <param name="assId">�ʲ����</param>
        /// <param name="sn">���к�</param>
        /// <param name="image">ͼƬ</param>
        /// <param name="name">����</param>
        public void AddAss(int assId, string sn, string type, string brand)
        {
            try
            {
                if (AssIdList.Contains(sn))
                {
                    throw new Exception("���ʲ��Ѿ��ڽ��ñ���!");
                }
                else
                {
                    DataRow row = AssTable.NewRow();
                    row["ASSID"] = assId;
                    row["SN"] = sn;
                    row["TYPE"] = type;
                    row["BRAND"] = brand;
                    AssTable.Rows.Add(row);
                    AssIdList.Add(sn);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// �Ƴ����õ��е��ʲ�
        /// </summary>
        /// <param name="SN"></param>
        public void RemoveAss(string sn)
        {
            try
            {
                //AssBorrowOrderOutputDto assBorrowOrderOutput = _autofacConfig.AssetsService.GetBobyId(BoId);
                //if(assBorrowOrderOutput.expired == 0)
                //{
                //    ((frmBoDetail)Form).Bind();
                //    throw new Exception("�ñ��ѹ��ڣ�");
                //}

                ReturnInfo returnInfo = _autofacConfig.AssetsService.DelAssBorrowOrderRow(sn, BoId);

                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    ((frmBoDetail)Form).Bind();

                    //DataRow row = AssTable.Rows.Find(sn);
                    //AssTable.Rows.Remove(row);
                    //AssIdList.Remove(sn);
                    //BindListView();//fixme
                    Toast("�黹�ʲ��ɹ�");
                    //Close();
                }
                else
                {
                    Toast(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        /// <summary>
        /// ������õ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (AssIdList.Count == 0)
                {
                    throw new Exception("����ӽ��õ��ʲ���");
                }
                AssBorrowOrderRowInputDto row = new AssBorrowOrderRowInputDto
                {
                    Sns = AssIdList,
                    use_log_id = BoId
                };
                ReturnInfo returnInfo = _autofacConfig.AssetsService.AddAssBorrowOrderRow(row);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    Toast("��ӳɹ�");
                    Close();
                }
                else
                {
                    Toast(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ɾ�����õ���һ���黹ȫ���ʲ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Press(object sender, EventArgs e)
        {
            try
            {
                if (AssIdList.Count == 0)
                {
                    throw new Exception("û��Ҫ�黹���ʲ���");
                }

                DataTable rowsTable = _autofacConfig.AssetsService.GetRowsByBoid(BoId);
                List<string> SnList = new List<string>();

                for (int i = 0; i < rowsTable.Rows.Count; i++)
                {
                    SnList.Add(rowsTable.Rows[i][0].ToString());
                }

                AssBorrowOrderRowInputDto row = new AssBorrowOrderRowInputDto
                {
                    Sns = SnList,
                    use_log_id = BoId
                };
                ReturnInfo returnInfo = _autofacConfig.AssetsService.ReturnAss(row);
                if (returnInfo.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    ClearInfo();
                    Toast("�黹�ɹ�");
                    Close();

                }
                else
                {
                    Toast(returnInfo.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// ������������
        /// </summary>
        private void ClearInfo()
        {
            AssTable.Rows.Clear();
            AssIdList.Clear();
            BindListView();
        }


    }
}
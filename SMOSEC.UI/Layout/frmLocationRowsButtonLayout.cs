using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.CommLib;
using SMOSEC.UI.MasterData;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmLocationRowsButtonLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "define"
        public String ID;       //�����Ż��������
        public String LocName;    //��������
        public bool Enable = false;    //�Ƿ�����
        AutofacConfig autofacConfig = new AutofacConfig();    //����������
        #endregion
        /// <summary>
        /// �༭������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Press(object sender, EventArgs e)
        {
            if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmLocationRows")
            {
                frmLocationCreateLayout frm = new frmLocationCreateLayout();
                frm.ID = ID;  //�������
                frm.isEdit = true;
                this.Close();
                this.Form.ShowDialog(frm);
            }
            else if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmAssetsTypeRows")
            {
                frmAssetsTypeCreateLayout frm = new frmAssetsTypeCreateLayout();
                frm.ID = ID;      //������
                frm.isEdit = true;     //�༭״̬
                this.Close();
                this.Form.ShowDialog(frm);
            }
        }
        /// <summary>
        /// ɾ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Press(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmLocationRows")
                {
                    MessageBox.Show("��ȷ��Ҫɾ����������?", "ϵͳ����", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                      {
                          try
                          {
                              if (args.Result == ShowResult.OK)     //ɾ��������
                            {
                                  ReturnInfo r = autofacConfig.assLocationService.DeleteAssLocation(ID);
                                  if (r.IsSuccess == true)
                                  {
                                      this.Form.Toast("ɾ���ɹ�");
                                      ((frmLocationRows)Form).Bind();      //ˢ������
                                }
                                  else
                                  {
                                      throw new Exception(r.ErrorInfo);
                                  }
                              }
                          }
                          catch (Exception ex)
                          {
                              Form.Toast(ex.Message);
                          }
                      });
                }
                else if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmAssetsTypeRows")
                {
                    if (Enable)        //���ø÷���
                    {
                        MessageBox.Show("��ȷ��Ҫ���ø÷�����?", "ϵͳ����", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)
                                {
                                    if (autofacConfig.assTypeService.HasAssets(ID))
                                    {
                                        throw new Exception("��ǰ�ʲ���������ص��ʲ����ݣ����������!");
                                    }
                                    else if (autofacConfig.assTypeService.IsParent(ID))
                                    {
                                        throw new Exception("��ǰ�ʲ��������ӷ��࣬���������!");
                                    }
                                    else
                                    {
                                        ReturnInfo r = autofacConfig.assTypeService.ChangeEnable(ID, DTOs.Enum.IsEnable.����);
                                        if (r.IsSuccess == true)
                                        {
                                            this.Form.Toast("������óɹ�!");
                                            ((frmAssetsTypeRows)Form).Bind();
                                        }
                                        else
                                        {
                                            throw new Exception(r.ErrorInfo);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Form.Toast(ex.Message);
                            }
                        });
                    }
                    else        //���ø÷���
                    {
                        MessageBox.Show("��ȷ��Ҫ���ø÷�����?", "ϵͳ����", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
                        {
                            try
                            {
                                if (args.Result == ShowResult.OK)
                                {
                                    ReturnInfo r = autofacConfig.assTypeService.ChangeEnable(ID, DTOs.Enum.IsEnable.����);
                                    if (r.IsSuccess == true)
                                    {
                                        this.Form.Toast("�������óɹ�!");
                                        ((frmAssetsTypeRows)Form).Bind();
                                    }
                                    else
                                    {
                                        throw new Exception(r.ErrorInfo);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Form.Toast(ex.Message);
                            }
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLocationRowsButtonLayout_Load(object sender, EventArgs e)
        {
            if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmLocationRows")
            {
                btnEdit.Text = "�༭������";
                btnDelete.Text = "ɾ��������";
            }
            else if (this.Form.ToString() == "SMOSEC.UI.MasterData.frmAssetsTypeRows")
            {
                btnEdit.Text = "�༭�˷���";
                if (Enable)
                {
                    btnDelete.Text = "���ô˷���";
                }
                else
                {
                    btnDelete.Text = "���ô˷���";
                }
            }
        }
    }
}
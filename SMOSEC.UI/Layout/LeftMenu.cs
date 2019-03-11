using System;
using SMOSEC.UI.AssetsManager;
using SMOSEC.UI.MasterData;
using SMOSEC.UI.UserInfo;
using Smobiler.Core.Controls;
//using SMOSEC.UI.ConsumablesManager;
//using SMOSEC.UI.Department;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class LeftMenu : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// ��ʾ�̶��ʲ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNAssetsManager_Press(object sender, EventArgs e)
        {
            if (SNAssets.Visible)
            {
                lblSNAssetsManager.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                lblSNAssetsShow.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                imgSNAssets.ResourceID = "zichan1";
                SNAssets.Visible = false;
                SNJieyong.Visible = false;
                SNGuiHuan.Visible = false;
                SNUserman.Visible = false;
                SNBrand.Visible = false;
                SNTeam.Visible = false;
                SNWeiXiu.Visible = false;
                SNPro.Visible = false;
                SNPayman.Visible = false;
                SNRoom.Visible = false;
                SNRole.Visible = false;
                SNType.Visible = false;
                lblSNAssetsShow.Text = ">";
            }
            else
            {
                lblSNAssetsManager.ForeColor = System.Drawing.Color.FromArgb(93, 155, 251);
                lblSNAssetsShow.ForeColor = System.Drawing.Color.FromArgb(93, 155, 251);
                imgSNAssets.ResourceID = "zichan2";
                lblConsumables.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                lblConsumablesShow.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                imgCons.ResourceID = "haocai1";
                SNAssets.Visible = true;
                SNJieyong.Visible = true;
                SNGuiHuan.Visible = true;
                SNWeiXiu.Visible = true;
                lblSNAssetsShow.Text = "��";
                switch (Client.Session["permission"].ToString())
                {
                    case "admin":
                        SNTeam.Visible = true;
                        SNPayman.Visible = true;
                        SNRoom.Visible = true;
                        SNRole.Visible = true;
                        SNType.Visible = true;
                        SNUserman.Visible = true;
                        SNBrand.Visible = true;
                        SNPro.Visible = true;
                        break;
                    case "super":
                        SNTeam.Visible = true;
                        SNPayman.Visible = true;
                        SNRoom.Visible = true;
                        SNRole.Visible = true;
                        SNType.Visible = true;
                        SNUserman.Visible = true;
                        SNBrand.Visible = true;
                        SNPro.Visible = true;
                        break;
                }
            }
        }
        /// <summary>
        /// ��ת���ʲ��б����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNAssets_Press(object sender, EventArgs e)
        {
            frmAssets frm = new frmAssets();
            Form.Show(frm);
        }
        /// <summary>
        /// ��ת���ʲ����ý���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNJieyong_Press(object sender, EventArgs e)
        {
            frmBorrowOrder frm = new frmBorrowOrder();
            Form.Show(frm);
        }
        /// <summary>
        /// ��ת���ʲ��黹����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNGuiHuan_Press(object sender, EventArgs e)
        {
            //frmReturnOrder frm = new frmReturnOrder();
            //Form.Show(frm);
        }
        /// <summary>
        /// ��ת�����ʹ���˽���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNUserman_Press(object sender, EventArgs e)
        {
            frmuserman frm = new frmuserman();
            Form.Show(frm);
            //frmCollarOrder frm = new frmCollarOrder();
            //Form.Show(frm);
        }
        /// <summary>
        /// ��ת���ʲ��˿����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNBrand_Press(object sender, EventArgs e)
        {
            frmbrand frm = new frmbrand();
            Form.Show(frm);
            //frmRestoreOrder frm = new frmRestoreOrder();
            //Form.Show(frm);
        }
        /// <summary>
        /// �̶��ʲ���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNTeam_Press(object sender, EventArgs e)
        {
            frmteam frm = new frmteam();
            Form.Show(frm);
            //frmTransferRowsSN frm = new frmTransferRowsSN();
            //this.Form.Show(frm);
        }
        /// <summary>
        /// �̶��ʲ����޽���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNWeiXiu_Press(object sender, EventArgs e)
        {
            frmRepairRowsSN frm = new frmRepairRowsSN();
            this.Form.Show(frm);
        }
        /// <summary>
        /// �̶��ʲ����Ͻ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNPro_Press(object sender, EventArgs e)
        {
            frmpro frm = new frmpro();
            Form.Show(frm);
            //frmScrapRowsSN frm = new frmScrapRowsSN();
            //this.Form.Show(frm);
        }
        /// <summary>
        /// ��ת���ʲ��̵����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNInventory_Press(object sender, EventArgs e)
        {
            //frmAssInventory frm = new frmAssInventory();
            //this.Form.Show(frm);
        }
        /// <summary>
        /// ��ת���ʲ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNRoom_Press(object sender, EventArgs e)
        {
            frmmachine_room frm = new frmmachine_room();
            Form.Show(frm);
            //frmAssetsTypeRows frm = new frmAssetsTypeRows();
            //Form.Show(frm);
        }
        /// <summary>
        /// ��ת���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNRole_Press(object sender, EventArgs e)
        {
            frmrole frm = new frmrole();
            Form.Show(frm);
            //frmLocationRows frm = new frmLocationRows();
            //Form.Show(frm);
        }
        /// <summary>
        /// ��ת�����Ž���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SNType_Press(object sender, EventArgs e)
        {
            frmtype frm = new frmtype();
            Form.Show(frm);
            //frmDepartment frm = new frmDepartment();
            //Form.Show(frm);
        }
        /// <summary>
        /// ��ʾ�ĲĹ�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Assets_Press(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// �Ĳ��б�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HaoCai_Press(object sender, EventArgs e)
        {
            //frmConsumables frm = new frmConsumables();
            //Form.Show(frm);
        }
        /// <summary>
        /// ��ⵥ�б�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ruku_Press(object sender, EventArgs e)
        {
            //frmWarehouseReceipt frm = new frmWarehouseReceipt();
            //Form.Show(frm);
        }
        /// <summary>
        /// ���ⵥ�б�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chuku_Press(object sender, EventArgs e)
        {
            //frmOutboundOrder frm = new frmOutboundOrder();
            //Form.Show(frm);
        }
        /// <summary>
        /// ��ת���Ĳĵ�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiaoBo_Press(object sender, EventArgs e)
        {
            //frmTransferRows frm = new frmTransferRows();
            //Form.Show(frm);
        }
        /// <summary>
        /// ��ת���Ĳ��̵����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pandian_Press(object sender, EventArgs e)
        {
            //frmConInventory frm = new frmConInventory();
            //Form.Show(frm);
        }
        /// <summary>
        /// ��ʾ������Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plPerson_Press(object sender, EventArgs e)
        {
            frmMessage frm = new frmMessage();
            Form.Show(frm);
        }
        /// <summary>
        /// ע���˺ţ����ص���¼����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plZhuXiao_Press(object sender, EventArgs e)
        {
            MessageBox.Show("�Ƿ�ע����ǰ�û���", "ϵͳ����", MessageBoxButtons.OKCancel, (object sender1, MessageBoxHandlerArgs args) =>
             {
                 try
                 {
                     if (args.Result == ShowResult.OK)
                         Client.ReStart();
                 }
                 catch (Exception ex)
                 {
                     Toast(ex.Message);
                 }
             });
        }
    }
}
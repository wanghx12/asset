using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.Domain.Entity;
using System.Data;
using SMOSEC.DTOs.InputDTO;
using SMOSEC.DTOs.OutputDTO;
using SMOSEC.CommLib;



namespace SMOSEC.UI.AssetsManager
{
    partial class frmRepairDetailSN : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();     //调用配置类
        public DataTable AssTable = new DataTable();   //行项数据的表格
        public int ROID;     //报修单编号
        #endregion
        /// <summary>
        /// 维修单确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                ReturnInfo r = autofacConfig.assRepairOrderService.UpdateAssRepairOrder(ROID, "修好");
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    ClearInfo();
                    ((frmRepairDetailSN)Form).Bind();
                    Toast("修改状态成功");
                }
                else
                {
                    Toast(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 维修失败确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave1_Press(object sender, EventArgs e)
        {
            try
            {
                ReturnInfo r = autofacConfig.assRepairOrderService.UpdateAssRepairOrder(ROID, "未修好");
                if (r.IsSuccess)
                {
                    ShowResult = ShowResult.Yes;
                    ClearInfo();
                    ((frmRepairDetailSN)Form).Bind();
                    Toast("修改状态成功");
                }
                else
                {
                    Toast(r.ErrorInfo);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        //frmRepairDealSN frm = new frmRepairDealSN();
        //frm.ROID = ROID;
        //Show(frm, (MobileForm sender1, object args) =>
        //{
        //    if (frm.ShowResult == ShowResult.Yes)
        //        Bind();   //刷新数据显示
        //});

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRepairDetailSN_Load(object sender, EventArgs e)
        {
            if (AssTable.Columns.Count == 0)
            {
                AssTable.Columns.Add("ASSID");             //资产编号
                AssTable.Columns.Add("SN");                //序列号
                AssTable.Columns.Add("STATUS");            //行项状态
            }
            DataColumn[] keys = new DataColumn[1];
            keys[0] = AssTable.Columns["SN"];
            AssTable.PrimaryKey = keys;
            //DataTable tableAssets = new DataTable();      //未开启SN的资产列表
            
            Bind();
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        public void Bind()
        {
            try
            {
                ROInputDto ROData = autofacConfig.assRepairOrderService.GetByID(ROID);
                if (ROData != null)
                {
                    lblDealMan.Text = ROData.call_man;
                    DatePicker.Value = ROData.call_date;
                    lblPrice.Text = ROData.repair_man;
                    lblContent.Text = ROData.repair_content;
                    lblNote.Text = ROData.find_man;
                }
                //coreUser User = autofacConfig.coreUserService.GetUserByID(ROData.HANDLEMAN);
                //lblDealMan.Text = User.USER_NAME;

                AssetsOutputDto assets = autofacConfig.SettingService.GetAssetsByid(ROData.asset_id);

                DataRow row = AssTable.NewRow();
                row["ASSID"] = assets.AssId;
                row["SN"] = assets.SN;
                row["STATUS"] = ROData.repair_status;

                AssTable.Rows.Add(row);
                //AssIdList.Add(sn);

                //foreach (AssRepairOrderRow Row in ROData.Rows)
                //{
                //    Assets assets = autofacConfig.orderCommonService.GetAssetsByID(Row.ASSID);
                //    if (Row.STATUS == 0)
                //    {
                //        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN, "等待修");
                //    }
                //    else
                //    {
                //        tableAssets.Rows.Add(Row.ASSID, assets.NAME, assets.IMAGE, Row.SN, "维修完毕");
                //    }
                //}

                if (AssTable.Rows.Count > 0)
                {
                    BindListView();
                }
                
                //if (Client.Session["Role"].ToString() == "SMOSECUser") plButton.Visible = false;
                //如果维修单已完成，则隐藏维修单处理按钮
                if (ROData.repair_status != "等待修")
                    plButton.Visible = false;


            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        public void BindListView()
        {
            try
            {
                ListAssetsSN.DataSource = AssTable;
                ListAssetsSN.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// 情况保存的数据
        /// </summary>
        private void ClearInfo()
        {
            AssTable.Rows.Clear();
            BindListView();
        }

    }
}
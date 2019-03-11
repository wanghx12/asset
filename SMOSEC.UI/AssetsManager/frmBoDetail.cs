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
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类
        public List<string> AssIdList = new List<string>(); //所有行项的ASSID的集合
        public DataTable AssTable = new DataTable();   //行项数据的表格

        public int BoId;  //借用单编号
        /// <summary>
        /// 按回退键，则关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBODetail_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// 界面初始化时
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
        /// 绑定数据
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
        /// 点击扫描添加时
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
        /// 手机扫描到二维码时
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
                    throw new Exception("未在闲置物品中找到该物品");
                }
                else
                {
                    DataRow row = info.Rows[0];
                    var type = _autofacConfig.assTypeService.GetByID(int.Parse(row["asset_type_id"].ToString()));
                    var brand = _autofacConfig.assBrandService.GetByID(int.Parse(row["brand_id"].ToString()));
                    AddAss(int.Parse(row["id"].ToString()), barCode, type.name, brand.name);
                    BindListView(); //重新绑定数据
                }
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
                ListAss.DataSource = AssTable;
                ListAss.DataBind();
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// 添加资产到表格
        /// </summary>
        /// <param name="assId">资产编号</param>
        /// <param name="sn">序列号</param>
        /// <param name="image">图片</param>
        /// <param name="name">名称</param>
        public void AddAss(int assId, string sn, string type, string brand)
        {
            try
            {
                if (AssIdList.Contains(sn))
                {
                    throw new Exception("该资产已经在借用表单中!");
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
        /// 移除借用单中的资产
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
                //    throw new Exception("该表单已过期！");
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
                    Toast("归还资产成功");
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
        /// 保存借用单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                if (AssIdList.Count == 0)
                {
                    throw new Exception("请添加借用的资产！");
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
                    Toast("添加成功");
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
        /// 删除借用单，一键归还全部资产
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Press(object sender, EventArgs e)
        {
            try
            {
                if (AssIdList.Count == 0)
                {
                    throw new Exception("没有要归还的资产！");
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
                    Toast("归还成功");
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
        /// 情况保存的数据
        /// </summary>
        private void ClearInfo()
        {
            AssTable.Rows.Clear();
            AssIdList.Clear();
            BindListView();
        }


    }
}
using System;
using System.Collections.Generic;
using System.Data;
using Smobiler.Core.Controls;
using SMOSEC.CommLib;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.InputDTO;
using System.Text.RegularExpressions;

namespace SMOSEC.UI.AssetsManager
{
    partial class frmBoCreate : Smobiler.Core.Controls.MobileForm
    {
        #region  定义变量
        private AutofacConfig _autofacConfig = new AutofacConfig();//调用配置类

        public List<int> AssIdList = new List<int>(); //所有行项的ASSID的集合

        public DataTable AssTable = new DataTable();   //行项数据的表格
        public string Position;
        public int BoManId;
        public string HManId;
        private string UserId;
        private short Expired;

        public int Project_id;
        public int Team_id;
        public int Boid;
        #endregion

        /// <summary>
        /// 保存借用单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Press(object sender, EventArgs e)
        {
            try
            {
                //if (AssIdList.Count == 0)
                //{
                //    throw new Exception("请添加借用的资产！");
                //}
                if (String.IsNullOrEmpty(txtManager.Text))
                    throw new Exception("借出处理人不能为空");

                if (String.IsNullOrEmpty(btnLocation.Text))
                    throw new Exception("来源区域不能为空");

                if (string.IsNullOrEmpty(btnPro.Text))
                {
                    throw new Exception("请选择项目.");
                }

                if (string.IsNullOrEmpty(btnTeam.Text))
                {
                    throw new Exception("请选择团队.");
                }
                if (txtphone.Text.Trim().Length <= 0)    //是否是手机号码
                    throw new Exception("请输入电话号码!");

                Regex regex = new Regex(@"^1(3[0-9]|4[57]|5[0-35-9]|7[0135678]|8[0-9])\d{8}$");
                if (regex.IsMatch(txtphone.Text) == false)
                    throw new Exception("手机号码格式不正确!");


                if (DPickerRs.Value == DateTime.Now)
                    throw new Exception("请选择预计归还日期!");

                AssBorrowOrderInputDto assBorrowOrderInput = new AssBorrowOrderInputDto
                {

                    //Assids = AssIdList,
                    phone = txtphone.Text,//fixme
                    principal = txtManager.Text,
                    give_time = DPickerCO.Value,
                    return_time = DPickerRs.Value,//DateTime.Now.AddMonths(1),fixme 时间不选也不报错
                    expired = 1,
                    position = btnLocation.Text,
                    project_id = Project_id,
                    team_id = Team_id,  
                    use_man_id = BoManId,
                    remark = txtNote.Text
                };
                ReturnInfo returnInfo = _autofacConfig.AssetsService.AddAssBorrowOrder(assBorrowOrderInput);
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
        /// 保存借用单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveform_Press(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 选择借用人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBOMan_Press(object sender, EventArgs e)
        {
            try
            {
                PopBOMan.Groups.Clear();
                PopListGroup manGroup = new PopListGroup();
                PopBOMan.Title = "借用人选择";
                List<cmdb_useman> users = _autofacConfig.assUserService.GetAll();
                foreach (cmdb_useman Row in users)
                {
                    manGroup.AddListItem(Row.name, Row.id.ToString());
                }
                PopBOMan.Groups.Add(manGroup);
                if (btnBOMan.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in manGroup.Items)
                    {
                        if (Item.Value == btnBOMan.Tag.ToString())
                            PopBOMan.SetSelections(Item);
                    }
                }
                PopBOMan.ShowDialog();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// 选择项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPro_Press(object sender, EventArgs e)
        {
            try
            {
                PopPro.Groups.Clear();
                PopListGroup manGroup = new PopListGroup();
                PopPro.Title = "项目选择";
                //List<cmdb_useman> users = _autofacConfig.assUserService.GetAll();
                List<cmdb_project> pros = _autofacConfig.assProService.GetAll();
                foreach (cmdb_project Row in pros)
                {
                    manGroup.AddListItem(Row.name, Row.id.ToString());
                }
                PopPro.Groups.Add(manGroup);
                if (btnPro.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in manGroup.Items)
                    {
                        if (Item.Value == btnPro.Tag.ToString())
                            PopPro.SetSelections(Item);
                    }
                }
                PopPro.ShowDialog();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 选择团队
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTeam_Press(object sender, EventArgs e)
        {
            try
            {
                PopTeam.Groups.Clear();
                PopListGroup manGroup = new PopListGroup();
                PopTeam.Title = "团队选择";
                List<cmdb_team> teams = _autofacConfig.assTeamService.GetAll();
                foreach (cmdb_team Row in teams)
                {
                    manGroup.AddListItem(Row.name, Row.id.ToString());
                }
                PopTeam.Groups.Add(manGroup);
                if (btnTeam.Tag != null)   //如果已有选中项，则显示选中效果
                {
                    foreach (PopListItem Item in manGroup.Items)
                    {
                        if (Item.Value == btnTeam.Tag.ToString())
                            PopTeam.SetSelections(Item);
                    }
                }
                PopTeam.ShowDialog();

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }
        /// <summary>
        /// 选择区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLocation_Press(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 手机扫码添加二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgBtnForBarcode_Press(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btnLocation.Text))
                {
                    throw new Exception("请先选择区域");
                }
                else
                {
                    barcodeScanner1.GetBarcode();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        /// <summary>
        /// 选择借用人之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopBOMan_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopBOMan.Selection != null)
                {
                    btnBOMan.Text = PopBOMan.Selection.Text;
                    BoManId = int.Parse(PopBOMan.Selection.Value);//fixme
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 选择项目之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopPro_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopPro.Selection != null)
                {
                    btnPro.Text = PopPro.Selection.Text;
                    Project_id = int.Parse(PopPro.Selection.Value);//fixme
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 选择团队之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopTeam_Selected(object sender, EventArgs e)
        {
            try
            {
                if (PopTeam.Selection != null)
                {
                    btnTeam.Text = PopTeam.Selection.Text;
                    Team_id = int.Parse(PopTeam.Selection.Value);//fixme
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }


        /// <summary>
        /// 选择区域之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopLocation_Selected(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 手机按回退时，关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBOCreate_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Close();
        }

        /// <summary>
        /// 初始化界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBOCreate_Load(object sender, EventArgs e)
        {
            try
            {
                if (AssTable.Columns.Count == 0)
                {
                    AssTable.Columns.Add("ASSID");
                    AssTable.Columns.Add("TYPE");
                    AssTable.Columns.Add("BRAND");
                    AssTable.Columns.Add("SN");
                }
                DataColumn[] keys = new DataColumn[1];
                keys[0] = AssTable.Columns["ASSID"];
                AssTable.PrimaryKey = keys;

                //UserId = Session["UserID"].ToString();//fixme这条语句报错，给定关键字不在字典中
                switch (Client.Session["permission"].ToString())
                {
                    case "admin":
                        {
                            //var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                            //Position = user.USER_LOCATIONID;
                            //var location = _autofacConfig.assLocationService.GetByID(LocationId);
                            //btnLocation.Text = "";
                            //btnLocation.Enabled = false;
                            //btnLocation1.Enabled = false;
                        }
                        break;
                    case "guset":
                        {
                            BoManId = int.Parse(UserId);
                            //var user = _autofacConfig.coreUserService.GetUserByID(UserId);
                            //btnBOMan.Text = user.USER_NAME;
                            btnBOMan.Enabled = false;
                            btnBOMan1.Enabled = false;
                        }
                        break;
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
        /// 情况保存的数据
        /// </summary>
        private void ClearInfo()
        {
            AssTable.Rows.Clear();
            AssIdList.Clear();
            BindListView();
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
                if (AssIdList.Contains(assId))
                {

                }
                else
                {
                    DataRow row = AssTable.NewRow();
                    row["ASSID"] = assId;
                    row["SN"] = sn;
                    row["TYPE"] = type;
                    row["BRAND"] = brand;
                    AssTable.Rows.Add(row);
                    AssIdList.Add(assId);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }

        }

        /// <summary>
        /// 从相关数据中删除资产
        /// </summary>
        /// <param name="assId">资产编号</param>
        public void RemoveAss(int assId)
        {
            try
            {
                DataRow row = AssTable.Rows.Find(assId);
                AssTable.Rows.Remove(row);
                AssIdList.Remove(assId);
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手持按键扫描到二维码时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R2000BarcodeScanEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btnLocation.Text))
                {
                    throw new Exception("请先选择区域");
                }
                else
                {
                    string barCode = e.Data;
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
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }

        /// <summary>
        /// 手持按键扫描到RFID时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void r2000Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.R2000RFIDScanEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(btnLocation.Text))
                {
                    throw new Exception();
                }
                else
                {
                    string RFID = e.Epc;
                    DataTable info = _autofacConfig.SettingService.GetUnUsedAssEx(RFID);
                    if (info.Rows.Count == 0)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        DataRow row = info.Rows[0];
                        var type = _autofacConfig.assTypeService.GetByID(int.Parse(row["asset_type_id"].ToString()));
                        var brand = _autofacConfig.assBrandService.GetByID(int.Parse(row["brand_id"].ToString()));
                        AddAss(int.Parse(row["id"].ToString()), RFID, type.name, brand.name);
                        BindListView(); //重新绑定数据
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message != "引发类型为“System.Exception”的异常。")
                {
                    Toast(ex.Message);
                }
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
                if (string.IsNullOrEmpty(btnLocation.Text))
                {
                    throw new Exception("请先选择区域");
                }
                else
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
                if (string.IsNullOrEmpty(btnLocation.Text))
                {
                    throw new Exception("请先选择区域");
                }
                else
                {
                    barcodeScanner1.GetBarcode();
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}
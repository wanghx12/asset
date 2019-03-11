using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.UI.Layout;
using System.Data;
using SMOSEC.Application.Services;
using SMOSEC.Domain.Entity;
using SMOSEC.DTOs.Enum;

namespace SMOSEC.UI.MasterData
{
    partial class frmAssetsTypeRows : Smobiler.Core.Controls.MobileForm
    {
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//����������
        public Int32 MaxLevel = 3;         //����㼶
        public Int32 NowLevel = 1;     //��ǰ�㼶
        public String ID;              //ѡ���ʲ�������
        #endregion
        /// <summary>
        /// ҳ���ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsTypeRows_Load(object sender, EventArgs e)
        {
            Bind();
        }
        /// <summary>
        /// ���ݰ�
        /// </summary>
        public void Bind()
        {
            try
            {
                treeAssetsType.Nodes.Clear();       //�������
                List<AssetsType> Data = autofacConfig.assTypeService.GetAll();
                if (Data.Count > 0)
                {
                    foreach (AssetsType Row in Data)
                    {
                        if (Row.TLEVEL == 1)
                        {
                            TreeViewNode Node = new TreeViewNode(Row.NAME, null, "һ", Row.TYPEID);
                            TreeViewNode SonNode = getData(2, Data, Row.TYPEID);
                            if (SonNode.Nodes.Count > 0)
                            {
                                foreach (TreeViewNode SonRow in SonNode.Nodes)
                                {
                                    Node.Nodes.Add(SonRow);
                                }
                            }
                            if(Row.ISENABLE== (int)IsEnable.����)
                            {
                                Node.TextColor = System.Drawing.Color.Red;
                            }
                            treeAssetsType.Nodes.Add(Node);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// ����Ӽ��ʲ�����(�ܹ�����)
        /// </summary>
        /// <param name="Level"></param>
        /// <param name="Data"></param>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        public TreeViewNode getData(Int32 Level, List<AssetsType> Data, String ParentID)
        {
            TreeViewNode TreeData = new TreeViewNode();
            if (Level < MaxLevel)
            {
                foreach (AssetsType Row in Data)
                {
                    if (Row.TLEVEL == Level && Row.PARENTTYPEID == ParentID)
                    {
                        TreeViewNode Node = new TreeViewNode(Row.NAME, null, "��", Row.TYPEID);
                        TreeViewNode SonNode = getData(Level + 1, Data, Row.TYPEID);
                        if (SonNode.Nodes.Count > 0)
                        {
                            foreach (TreeViewNode SonRow in SonNode.Nodes)
                            {
                                Node.Nodes.Add(SonRow);
                            }
                        }
                        if (Row.ISENABLE == (int)IsEnable.����)
                        {
                            Node.TextColor = System.Drawing.Color.Red;
                        }
                        TreeData.Nodes.Add(Node);
                    }
                }
            }
            else if (Level == MaxLevel)
            {
                foreach (AssetsType Row in Data)
                {
                    if (Row.TLEVEL == Level && Row.PARENTTYPEID == ParentID)
                    {
                        TreeViewNode Node = new TreeViewNode(Row.NAME, null, "��", Row.TYPEID);
                        if (Row.ISENABLE == (int)IsEnable.����)
                        {
                            Node.TextColor = System.Drawing.Color.Red;
                        }
                        TreeData.Nodes.Add(Node);
                    }
                }
            }
            return TreeData;
        }
        /// <summary>
        /// ����¼��ʲ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IBAdd_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(ID))  throw new Exception("����ѡ�����ʲ����");
                if (autofacConfig.assTypeService.GetByID(ID).TLEVEL == 3) throw new Exception("��ǰ��ѡ���Ϊ��ͼ����޷������¼�!");
                frmAssetsTypeCreateLayout frm = new frmAssetsTypeCreateLayout();
                frm.isCreateSon = true;
                frm.ID = ID;
                ShowDialog(frm);
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// ���б༭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IBEdit_Press(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(ID)) throw new Exception("����ѡ��Ҫ�������ʲ����");
                AssetsType assetsType= autofacConfig.assTypeService.GetByID(ID);
                frmLocationRowsButtonLayout frm = new frmLocationRowsButtonLayout();
                if (assetsType.ISENABLE == (int)IsEnable.����)
                {
                    frm.Enable = true;
                }
                else
                {
                    frm.Enable = false; 
                }
                frm.ID = ID;
                DialogOptions Dialog = new DialogOptions {
                    JustifyAlign = LayoutJustifyAlign.FlexEnd,
                    Padding = new Padding(0)
                };
                ShowDialog(frm,Dialog);
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }
        }
        /// <summary>
        /// �½��ʲ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Press(object sender, EventArgs e)
        {
            frmAssetsTypeCreateLayout frm = new frmAssetsTypeCreateLayout();
            frm.isCreate = true;
            frm.plFID.Visible = false;
            frm.plFName.Visible = false;
            frm.plFDate.Visible = false;
            frm.Height = 220;
            this.ShowDialog(frm);
        }
        /// <summary>
        /// ѡ���ʲ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeAssetsType_NodePress(object sender, TreeViewClickEventArgs e)
        {
            ID = e.Value;        //��ѡ�ʲ�������
            lblName.Text = e.Text;      //��ѡ�ʲ���������
        }
        /// <summary>
        /// �ֻ��Դ����ؼ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAssetsTypeRows_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
                Client.Exit();
        }
    }
}
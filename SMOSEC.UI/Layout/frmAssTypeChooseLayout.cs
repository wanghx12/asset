using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using SMOSEC.Domain.Entity;
using SMOSEC.UI.MasterData;

namespace SMOSEC.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ�����Զ���ؼ��������䣬true��ӣ�false�����
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmAssTypeChooseLayout : Smobiler.Core.Controls.MobileUserControl
    { 
        #region "definition"
        AutofacConfig autofacConfig = new AutofacConfig();//����������
        public Int32 MaxLevel = 3;         //����㼶
        public Int32 NowLevel = 1;     //��ǰ�㼶
        //public String ID;              //ѡ���ʲ�������
        public string typeId;
        //public string typeName;
        public bool IsCreate;
        #endregion
        /// <summary>
        /// �رյ�ǰ����ҳ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plClose_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeAssetsType_NodePress(object sender, TreeViewClickEventArgs e)
        {
            //if (IsCreate)
            //{
            //    ((frmAssetsCreate)Form).btnType.Tag = e.Value;    //��ѡ�ʲ�������
            //    ((frmAssetsCreate)Form).btnType.Text = e.Text;    //��ѡ�ʲ���������
            //}
            //else
            //{
            //    ((frmAssetsDetailEdit)Form).btnType.Tag = e.Value;   //��ѡ�ʲ�������
            //    ((frmAssetsDetailEdit)Form).btnType.Text = e.Text;   //��ѡ�ʲ���������
            //}
            //this.Close();
        }

        private void frmAssTypeChooseLayout_Load(object sender, EventArgs e)
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
                List<cmdb_assettype> Data = autofacConfig.assTypeService.GetAll();
                //if (Data.Count > 0)
                //{
                //    foreach (cmdb_assettype Row in Data)
                //    {
                //        if (Row.TLEVEL == 1)
                //        {
                //            TreeViewNode Node = new TreeViewNode(Row.name, null, "һ", Row.id);
                //            TreeViewNode SonNode = getData(2, Data, Row.id);
                //            if (SonNode.Nodes.Count > 0)
                //            {
                //                foreach (TreeViewNode SonRow in SonNode.Nodes)
                //                {
                //                    Node.Nodes.Add(SonRow);
                //                }
                //            }
                //            treeAssetsType.Nodes.Add(Node);
                //        }
                //    }
                //    ChangeNodeColor(treeAssetsType.Nodes);
                //}
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
        public TreeViewNode getData(Int32 Level, List<cmdb_assettype> Data, String ParentID)
        {
            TreeViewNode TreeData = new TreeViewNode();
            //if (Level < MaxLevel)
            //{
            //    foreach (cmdb_assettype Row in Data)
            //    {
            //        if (Row.TLEVEL == Level && Row.PARENTTYPEID == ParentID)
            //        {
            //            TreeViewNode Node = new TreeViewNode(Row.NAME, null, "��", Row.TYPEID);
            //            TreeViewNode SonNode = getData(Level + 1, Data, Row.TYPEID);
            //            if (SonNode.Nodes.Count > 0)
            //            {
            //                foreach (TreeViewNode SonRow in SonNode.Nodes)
            //                {
            //                    Node.Nodes.Add(SonRow);
            //                }
            //            }
            //            TreeData.Nodes.Add(Node);
            //        }
            //    }
            //}
            //else if (Level == MaxLevel)
            //{
            //    foreach (AssetsType Row in Data)
            //    {
            //        if (Row.TLEVEL == Level && Row.PARENTTYPEID == ParentID)
            //        {
            //            TreeViewNode Node = new TreeViewNode(Row.NAME, null, "��", Row.TYPEID);
            //            TreeData.Nodes.Add(Node);
            //        }
            //    }
            //}
            return TreeData;
        }

        public void ChangeNodeColor(TreeViewNodeCollection nodes)
        {
            foreach (TreeViewNode node in nodes)
            {
                if (node.Value == typeId)
                {
                    node.TextColor = Color.Red;
                    return;
                }
                if (node.Nodes.Count > 0)
                {
                    ChangeNodeColor(node.Nodes);
                }
            }
        }
    }
}
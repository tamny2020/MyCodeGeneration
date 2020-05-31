using My.CodeGeneration.Business;
using My.CodeGeneration.Common;
using My.CodeGeneration.Model;
using My.CodeGeneration.Model.Enum;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My.CodeGeneration.Main
{
    public partial class Form_Database : Form_Base
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Form_Database()
        {
            InitializeComponent();
        }

        #region 事件方法

        private void Form_Database_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;

            var serverList = ServersConfigClass.Instance.GetList();
            foreach (var server in serverList)
            {
                Servers servers = new Servers();
                servers.DatabaseName = server.Database;
                servers.Id = server.Id;
                servers.Name = server.Server;
                servers.Pwd = server.Pwd;
                servers.Port = server.Port.ToInt();
                servers.Server = server.Server;
                servers.Uid = server.Uid;
                servers.Type = (DatabaseType)Enum.Parse(typeof(DatabaseType), server.Type);

                ServersHelper.AddServers(servers);

                TreeNode rootNode = new TreeNode();
                rootNode.Name = server.Server;
                rootNode.Text = string.Format("{0}({1}{2})",
                    server.Server,
                    server.Type.ToString(),
                    string.IsNullOrWhiteSpace(server.Uid) ? "" : string.Format("-{0}", server.Uid));

                rootNode.ImageIndex = 0;
                rootNode.SelectedImageIndex = 0;
                rootNode.Tag = new Model.TreeNodeTag { Type = TreeNodeType.ServerNode, Tag = servers };
                treeViewLeft.Nodes.Add(rootNode);
            }

        }
        private void Form_Database_DoubleClick(object sender, EventArgs e)
        {

        }
        private void treeViewLeft_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            foreach (TreeNode n in node.Nodes)
            {
                n.Checked = node.Checked;
            }
        }
        private void treeViewLeft_DoubleClick(object sender, EventArgs e)
        {
            AddNodes();

        }
        /// <summary>
        /// 注销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStripRemove_Click(object sender, EventArgs e)
        {
            RemoveServers();
        }
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStripRefresh_Click(object sender, EventArgs e)
        {
            AddNodes();
        }
        /// <summary>
        /// 生成代码至文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemCodeFile_Click(object sender, EventArgs e)
        {
            BuilderSelect(CodeGenTarget.File);
        }
        /// <summary>
        /// 生成代码至目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemCodeDir_Click(object sender, EventArgs e)
        {
            BuilderSelect(CodeGenTarget.Directories);
        }

        #endregion

        #region 辅助方法

        /// <summary>
        /// 生成选择
        /// </summary>
        /// <param name="target"></param>
        public void BuilderSelect(CodeGenTarget target)
        {
            List<TreeNode> selNodeList = new List<TreeNode>();
            switch (target)
            {
                case CodeGenTarget.File:
                    var selNode = treeViewLeft.SelectedNode;
                    var treeNodeTag = (TreeNodeTag)selNode.Tag;
                    if (treeNodeTag.Type == TreeNodeType.Table)
                    {
                        selNodeList = new List<TreeNode> { selNode };
                    }
                    break;
                case CodeGenTarget.Directories:
                    selNodeList = GetTreeNodeSelectedList();
                    break;
                default:
                    break;
            }

            if (!selNodeList.Any())
            {
                ShowBox("请选择数据表");
                return;
            }

            new Form_BuilderSelect((form, files) =>
            {
                GenerateCode(target, files, selNodeList);
                form.Close();
            }).ShowDialog();
        }
        /// <summary>
        /// 代码生成
        /// </summary>
        /// <param name="target">生成目标</param>
        /// <param name="tmpFiles">模板文件</param>
        /// <param name="tableNodeList">表集合</param>
        private void GenerateCode(CodeGenTarget target, string[] tmpFiles, List<TreeNode> tableNodeList)
        {
            switch (target)
            {
                case CodeGenTarget.File:
                    break;
                case CodeGenTarget.Directories:
                    break;
                default:
                    break;
            }
            if (tmpFiles.Length == 0)
            {
                MessageBox.Show("请选择模板");
                return;
            }

            tableNodeList.ForEach(node =>
            {
                var serversNode = node.Parent.Parent.Parent;
                var serversNodeTag = (TreeNodeTag)serversNode.Tag;
                var servers = (Servers)serversNodeTag.Tag;
                var dataBaseName = node.Parent.Parent.Text;
                var tableName = node.Text;

                //生成文件代码
                for (int j = 0; j < tmpFiles.Length; j++)
                {
                    var arr = Path.GetFileNameWithoutExtension(tmpFiles[j]).Split('_');
                    var fileType = arr.Length < 2 ? "cs" : arr[1];//文件类型
                    var codeType = CommonHelper.GetCodeTypeName(fileType);

                    var fields = new BLL_Database(servers.Type).GetFields(servers.Id, dataBaseName, tableName);
                    var result = RazorEngineExtension.Parse<RazorPageModel>(tmpFiles[j], new RazorPageModel
                    {
                        TableName = tableName,
                        Fields = fields
                    });

                    switch (target)
                    {
                        case CodeGenTarget.Directories:
                            string fileName = arr[0].ToUpper() + "_" + tableName + "." + fileType;
                            string filePath = Path.Combine(AppGlobalConfig.Intance.Config.FileSaveDirectory, fileName);
                            filePath.WriteAllText(result);
                            break;
                        default:
                            var formCode = new Form_Code(tableName + "_" + arr[0], result, codeType);
                            formCode.Show(Form_Main.Instance.dockPanel);
                            break;
                    }
                }
            });

        }
        /// <summary>
        /// 加载下级节点
        /// </summary>
        private void AddNodes(bool isRefresh = false)
        {
            TreeNode selNode = treeViewLeft.SelectedNode;
            if (selNode == null) return;
            if (selNode.Nodes.Count > 0 && !isRefresh)
            {
                return;
            }

            selNode.Nodes.Clear();
            TreeNode rootNode = GetRoot(selNode);
            if (rootNode == null)
            {
                return;
            }

            TreeNodeTag rootNodeTag = (TreeNodeTag)rootNode.Tag;
            Servers server = (Servers)rootNodeTag.Tag;
            if (server == null)
            {
                return;
            }
            TreeNodeTag treeNodeTag = (TreeNodeTag)selNode.Tag; ;
            BLL_Database Database = new BLL_Database(server.Type);
            string msg;
            if (!Database.TestDatabaseConnnection(server.Id, out msg))
            {
                ShowBox(msg, "数据库连接失败");
                return;
            }

            switch (treeNodeTag.Type)
            {
                #region 服务器加载数据库
                case TreeNodeType.ServerNode:
                    var dbs = Database.GetDatabases(server.Id);
                    foreach (var db in dbs)
                    {
                        TreeNode dbNode = new TreeNode();
                        dbNode.Name = db;
                        dbNode.Text = db;
                        dbNode.ImageIndex = 1;
                        dbNode.SelectedImageIndex = 1;
                        dbNode.Tag = new Model.TreeNodeTag() { Type = TreeNodeType.DataBaseNode, Tag = db };
                        selNode.Nodes.Add(dbNode);
                    }
                    break;
                #endregion

                #region 数据库加载表
                case TreeNodeType.DataBaseNode: //数据库加载表

                    TreeNode tblNode = new TreeNode();
                    tblNode.Name = "表";
                    tblNode.Text = "表";
                    tblNode.Tag = new Model.TreeNodeTag() { Type = TreeNodeType.TableNode, Tag = treeNodeTag.Tag.ToString() };
                    tblNode.ImageIndex = 4;
                    tblNode.SelectedImageIndex = 4;
                    selNode.Nodes.Add(tblNode);


                    //添加视图节点
                    TreeNode viewNode = new TreeNode();
                    viewNode.Name = "视图";
                    viewNode.Text = "视图";
                    viewNode.Tag = new Model.TreeNodeTag() { Type = TreeNodeType.ViewNode, Tag = treeNodeTag.Tag.ToString() };
                    viewNode.ImageIndex = 4;
                    viewNode.SelectedImageIndex = 4;
                    selNode.Nodes.Add(viewNode);

                    break;
                #endregion

                #region 表节点加载表
                case TreeNodeType.TableNode: //表节点加载表
                    var tables = Database.GetTables(server.Id, treeNodeTag.Tag.ToString());
                    foreach (var table in tables)
                    {
                        TreeNode tblNode1 = new TreeNode();
                        tblNode1.Name = table.Name;
                        tblNode1.Text = table.Name;
                        tblNode1.ImageIndex = 2;
                        tblNode1.SelectedImageIndex = 2;
                        tblNode1.Tag = new Model.TreeNodeTag() { Type = TreeNodeType.Table, Tag = table.Name };
                        selNode.Nodes.Add(tblNode1);
                    }
                    break;
                #endregion

                #region 表加载字段
                case TreeNodeType.Table: //表加载字段
                    var fields = Database.GetFields(server.Id, ((TreeNodeTag)selNode.Parent.Tag).Tag.ToString(), ((TreeNodeTag)selNode.Tag).Tag.ToString());
                    foreach (var field in fields)
                    {
                        TreeNode fldNode = new TreeNode();
                        fldNode.Name = field.Name;
                        fldNode.Text = string.Format("{0}({1}{2},{3})", field.Name, field.Type, field.Length != -1 ? "(" + field.Length.ToString() + ")" : "", field.IsNull ? "null" : "not null");
                        fldNode.ImageIndex = field.IsPrimaryKey ? 5 : 3;
                        fldNode.SelectedImageIndex = field.IsPrimaryKey ? 5 : 3;
                        fldNode.Tag = new Model.TreeNodeTag() { Type = TreeNodeType.Field, Tag = field };
                        selNode.Nodes.Add(fldNode);
                    }

                    new Form_TableDetail(selNode.Text, fields).AddDockPannel(Form_Main.Instance.dockPanel);

                    break;
                #endregion

                default:
                    break;
            }
            selNode.Expand();
        }
        /// <summary>
        /// 获取一个节点的根节点
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public TreeNode GetRoot(TreeNode node)
        {
            TreeNode node1 = node;
            while (node1.Parent != null)
            {
                node1 = node1.Parent;
            }
            return node1;
        }
        /// <summary>
        /// 获取选择节点表集合
        /// </summary>
        /// <returns></returns>
        public List<TreeNode> GetTreeNodeSelectedList()
        {
            List<TreeNode> list = new List<TreeNode>();
            TreeNodeCollection rootNodes = treeViewLeft.Nodes;
            foreach (TreeNode n in rootNodes)
            {
                var treeNodeTag = (TreeNodeTag)n.Tag;
                if (n.Checked && (treeNodeTag.Type == TreeNodeType.Table))
                {
                    list.Add(n);
                }
                AddSelectedNode(n, list);
            }
            if (list.Count == 0)
            {
                var treeNodeTag = (TreeNodeTag)treeViewLeft.SelectedNode.Tag;
                if (treeNodeTag.Type == TreeNodeType.Table)
                {
                    list.Add(treeViewLeft.SelectedNode);
                }
            }
            return list;
        }
        /// <summary>
        /// 递归添加已选节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="list"></param>
        private void AddSelectedNode(TreeNode node, List<TreeNode> list)
        {
            TreeNodeCollection nodes = node.Nodes;
            foreach (TreeNode n in nodes)
            {
                var treeNodeTag = (TreeNodeTag)n.Tag;
                if (n.Checked && (treeNodeTag.Type == TreeNodeType.Table))
                {
                    list.Add(n);
                }
                AddSelectedNode(n, list);
            }
        }
        /// <summary>
        /// 注销服务器
        /// </summary>
        public void RemoveServers()
        {
            if (treeViewLeft.SelectedNode == null)
            {
                return;
            }
            TreeNode rootNode = GetRoot(treeViewLeft.SelectedNode);
            if (rootNode == null)
            {
                return;
            }
            Model.TreeNodeTag tag = (Model.TreeNodeTag)rootNode.Tag;
            if (tag.Type != TreeNodeType.ServerNode)
            {
                return;
            }
            Servers server = (Servers)tag.Tag;

            //ServersHelper.Delete(server);

            rootNode.Remove();
        }
        /// <summary>
        /// 导出Word
        /// </summary>
        /// <param name="fileName"></param>
        public void ExportWord(string fileName)
        {
            try
            {
                var tableNodeList = GetTreeNodeSelectedList();

                if (tableNodeList == null || !tableNodeList.Any())
                {
                    ShowBox("请选择导出的数据表");
                    return;
                }

                var dicList = new Dictionary<string, Tuple<string, List<Fields>>>();
                tableNodeList.ForEach(node =>
                {
                    var serversNode = node.Parent.Parent.Parent;
                    var serversNodeTag = (TreeNodeTag)serversNode.Tag;
                    var servers = (Servers)serversNodeTag.Tag;
                    var dataBaseName = node.Parent.Parent.Text;
                    var tableName = node.Text;
                    var fields = new BLL_Database(servers.Type).GetFields(servers.Id, dataBaseName, tableName);
                    dicList.Add(tableName, Tuple.Create<string, List<Fields>>("", fields));
                });
                var b = NPOIWordHelper.Create(fileName, dicList);
                ShowBox(b ? "导出成功" : "导出失败");
            }
            catch (Exception ex)
            {
                ShowBox(ex.Message);
            }


        }

        #endregion

    }
}

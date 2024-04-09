using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB2
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
            MessageBox.Show("Doi 1 ti form dang duoc xu ly", "Warning");
            // khoi tao list view
            FileListView.View = View.Details;
            FileListView.Columns.Add("Name", 200);
            FileListView.Columns.Add("Size", 100);
            FileListView.Columns.Add("Type", 100);


            // khoi tao treeview (files)
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                TreeNode driveNode = new TreeNode(drive.Name); // tao treenode
                driveNode.Tag = drive.RootDirectory;
                FolderTreeView.Nodes.Add(driveNode);
                CungCapInfoTreeView(drive.RootDirectory, driveNode);
            }  
        }


        private void CungCapInfoTreeView(DirectoryInfo directory, TreeNode parentNode)
        {
            try
            {
                foreach (DirectoryInfo dir in directory.GetDirectories())
                {
                    TreeNode node = new TreeNode(dir.Name);
                    node.Tag = dir;
                    parentNode.Nodes.Add(node);
                    CungCapInfoTreeView(dir, node);
                }
            }
            catch (UnauthorizedAccessException) //bat loi
            {

            }
        }

        private void FolderTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode SelectedNode = e.Node;
            if (SelectedNode.Tag is DirectoryInfo) //check tag co gan duong dan?
            {
                DirectoryInfo SelectedDirectory = (DirectoryInfo)SelectedNode.Tag;
                FileListView.Items.Clear();
                try
                {
                    foreach (var file in SelectedDirectory.GetFiles())
                    {
                        ListViewItem item = new ListViewItem(file.Name);
                        item.SubItems.Add(file.Length.ToString());
                        item.SubItems.Add("File");
                        FileListView.Items.Add(item);
                    }
                }
                catch (UnauthorizedAccessException) // bat loi 
                {

                }
            }
        }

        private void FileListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FileListView.SelectedItems.Count > 0)
            {
                string SelectedFile = FileListView.SelectedItems[0].Text;
                string SelectedPath = Path.Combine(FolderTreeView.SelectedNode.FullPath, SelectedFile);

                if (File.Exists(SelectedPath))
                {
                    try
                    {
                        if (IsImageFile(SelectedPath)) // check co phai image ko
                        {
                            pictureBox1.Image = Image.FromFile(SelectedPath);
                        }
                        else
                        {
                            using (var streamReader = new StreamReader(SelectedPath))
                            {
                                string content = streamReader.ReadToEnd();
                                MessageBox.Show(content, "Noi dung file");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Loi: {ex.Message}", "Warning");
                    }
                }
            }
        }

        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower(); // lay duoi file 
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp";
        }

    }
}

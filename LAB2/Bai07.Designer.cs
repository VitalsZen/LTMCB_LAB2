namespace LAB2
{
    partial class Bai07
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FolderTreeView = new TreeView();
            FileListView = new ListView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FolderTreeView
            // 
            FolderTreeView.Location = new Point(21, 31);
            FolderTreeView.Name = "FolderTreeView";
            FolderTreeView.Size = new Size(290, 607);
            FolderTreeView.TabIndex = 0;
            FolderTreeView.NodeMouseDoubleClick += FolderTreeView_NodeMouseDoubleClick;
            // 
            // FileListView
            // 
            FileListView.Location = new Point(361, 31);
            FileListView.Name = "FileListView";
            FileListView.Size = new Size(777, 181);
            FileListView.TabIndex = 1;
            FileListView.UseCompatibleStateImageBehavior = false;
            FileListView.SelectedIndexChanged += FileListView_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(361, 239);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(777, 399);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 650);
            Controls.Add(pictureBox1);
            Controls.Add(FileListView);
            Controls.Add(FolderTreeView);
            Name = "Bai07";
            Text = "Bai07";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView FolderTreeView;
        private ListView FileListView;
        private PictureBox pictureBox1;
    }
}
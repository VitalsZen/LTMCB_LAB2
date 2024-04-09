namespace LAB2
{
    partial class Bai03
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
            rtb1 = new RichTextBox();
            bt1_Read = new Button();
            bt2_Write = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // rtb1
            // 
            rtb1.Location = new Point(21, 27);
            rtb1.Name = "rtb1";
            rtb1.Size = new Size(347, 229);
            rtb1.TabIndex = 6;
            rtb1.Text = "";
            // 
            // bt1_Read
            // 
            bt1_Read.Location = new Point(457, 310);
            bt1_Read.Name = "bt1_Read";
            bt1_Read.Size = new Size(226, 53);
            bt1_Read.TabIndex = 5;
            bt1_Read.Text = "Đọc file";
            bt1_Read.UseVisualStyleBackColor = true;
            bt1_Read.Click += bt1_Read_Click_1;
            // 
            // bt2_Write
            // 
            bt2_Write.Location = new Point(90, 310);
            bt2_Write.Name = "bt2_Write";
            bt2_Write.Size = new Size(226, 53);
            bt2_Write.TabIndex = 4;
            bt2_Write.Text = "Tính và ghi vào file";
            bt2_Write.UseVisualStyleBackColor = true;
            bt2_Write.Click += bt2_Write_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.MenuBar;
            richTextBox1.Enabled = false;
            richTextBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(406, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(347, 229);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "Viết nội dung vào file input3.txt, ví dụ\n1 + 2 + 3 + 4\n12 - 7 - 5 + 2 - 3\n2024 - 1 - 2 + 3\n222 + 333 - 444 + 1";
            // 
            // Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 402);
            Controls.Add(richTextBox1);
            Controls.Add(rtb1);
            Controls.Add(bt1_Read);
            Controls.Add(bt2_Write);
            Name = "Bai03";
            Text = "Bai03";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb1;
        private Button bt1_Read;
        private Button bt2_Write;
        private RichTextBox richTextBox1;
    }
}
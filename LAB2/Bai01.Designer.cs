namespace LAB2
{
    partial class Bai01
    {

        

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ofd1 = new OpenFileDialog();
            bt1_Read = new Button();
            rtb1 = new RichTextBox();
            bt2_Write = new Button();
            SuspendLayout();
            // 
            // ofd1
            // 
            ofd1.FileName = "openFileDialog1";
            // 
            // bt1_Read
            // 
            bt1_Read.Location = new Point(134, 223);
            bt1_Read.Name = "bt1_Read";
            bt1_Read.Size = new Size(211, 56);
            bt1_Read.TabIndex = 2;
            bt1_Read.Text = "Read";
            bt1_Read.UseVisualStyleBackColor = true;
            bt1_Read.Click += bt1_Read_Click;
            // 
            // rtb1
            // 
            rtb1.Location = new Point(28, 26);
            rtb1.Name = "rtb1";
            rtb1.Size = new Size(730, 178);
            rtb1.TabIndex = 3;
            rtb1.Text = "";
            // 
            // bt2_Write
            // 
            bt2_Write.Location = new Point(476, 223);
            bt2_Write.Name = "bt2_Write";
            bt2_Write.Size = new Size(211, 55);
            bt2_Write.TabIndex = 1;
            bt2_Write.Text = "Write";
            bt2_Write.UseVisualStyleBackColor = true;
            bt2_Write.Click += bt2_Write_Click;
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 300);
            Controls.Add(rtb1);
            Controls.Add(bt1_Read);
            Controls.Add(bt2_Write);
            Name = "Bai01";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog ofd1;
        private Button bt1_Read;
        private RichTextBox rtb1;
        private Button bt2_Write;
    }
}

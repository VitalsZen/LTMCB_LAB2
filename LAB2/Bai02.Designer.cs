namespace LAB2
{
    partial class Bai02
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
            openFileDialog1 = new OpenFileDialog();
            rtb1 = new RichTextBox();
            bt1_Read = new Button();
            tb1_Name = new TextBox();
            tb5_WordsC = new TextBox();
            tb4_LineC = new TextBox();
            tb3_URL = new TextBox();
            tb2_Size = new TextBox();
            tb6_CharC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtb1
            // 
            rtb1.Location = new Point(507, 111);
            rtb1.Name = "rtb1";
            rtb1.Size = new Size(275, 292);
            rtb1.TabIndex = 6;
            rtb1.Text = "";
            // 
            // bt1_Read
            // 
            bt1_Read.Location = new Point(47, 12);
            bt1_Read.Name = "bt1_Read";
            bt1_Read.Size = new Size(716, 59);
            bt1_Read.TabIndex = 5;
            bt1_Read.Text = "Read From File";
            bt1_Read.UseVisualStyleBackColor = true;
            bt1_Read.Click += bt1_Read_Click;
            // 
            // tb1_Name
            // 
            tb1_Name.BorderStyle = BorderStyle.FixedSingle;
            tb1_Name.Location = new Point(151, 109);
            tb1_Name.Name = "tb1_Name";
            tb1_Name.Size = new Size(307, 27);
            tb1_Name.TabIndex = 7;
            // 
            // tb5_WordsC
            // 
            tb5_WordsC.BorderStyle = BorderStyle.FixedSingle;
            tb5_WordsC.Location = new Point(151, 317);
            tb5_WordsC.Name = "tb5_WordsC";
            tb5_WordsC.Size = new Size(307, 27);
            tb5_WordsC.TabIndex = 8;
            // 
            // tb4_LineC
            // 
            tb4_LineC.BorderStyle = BorderStyle.FixedSingle;
            tb4_LineC.Location = new Point(151, 261);
            tb4_LineC.Name = "tb4_LineC";
            tb4_LineC.Size = new Size(307, 27);
            tb4_LineC.TabIndex = 9;
            // 
            // tb3_URL
            // 
            tb3_URL.BorderStyle = BorderStyle.FixedSingle;
            tb3_URL.Location = new Point(151, 210);
            tb3_URL.Name = "tb3_URL";
            tb3_URL.Size = new Size(307, 27);
            tb3_URL.TabIndex = 10;
            // 
            // tb2_Size
            // 
            tb2_Size.BorderStyle = BorderStyle.FixedSingle;
            tb2_Size.Location = new Point(151, 160);
            tb2_Size.Name = "tb2_Size";
            tb2_Size.Size = new Size(307, 27);
            tb2_Size.TabIndex = 11;
            // 
            // tb6_CharC
            // 
            tb6_CharC.BorderStyle = BorderStyle.FixedSingle;
            tb6_CharC.Location = new Point(151, 376);
            tb6_CharC.Name = "tb6_CharC";
            tb6_CharC.Size = new Size(307, 27);
            tb6_CharC.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 107);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 13;
            label1.Text = "Filename";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 158);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 14;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 208);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 15;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1, 374);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 16;
            label4.Text = "Characters count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 255);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 17;
            label5.Text = "Line count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 313);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 18;
            label6.Text = "Words count";
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb6_CharC);
            Controls.Add(tb2_Size);
            Controls.Add(tb3_URL);
            Controls.Add(tb4_LineC);
            Controls.Add(tb5_WordsC);
            Controls.Add(tb1_Name);
            Controls.Add(rtb1);
            Controls.Add(bt1_Read);
            Name = "Bai02";
            Text = "Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private RichTextBox rtb1;
        private Button bt1_Read;
        private TextBox tb1_Name;
        private TextBox tb5_WordsC;
        private TextBox tb4_LineC;
        private TextBox tb3_URL;
        private TextBox tb2_Size;
        private TextBox tb6_CharC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
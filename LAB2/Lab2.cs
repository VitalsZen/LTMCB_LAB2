using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ChildForm = new Bai01();
            ChildForm.Show();
        }

        private void bt_Bai02_Click(object sender, EventArgs e)
        {
            var ChildForm = new Bai02();
            ChildForm.Show();
        }

        private void bt_Bai03_Click(object sender, EventArgs e)
        {
            var ChildForm = new Bai03();
            ChildForm.Show();
        }

        private void bt_Bai04_Click(object sender, EventArgs e)
        {
            var ChildForm = new Bai04();
            ChildForm.Show();
        }

        private void bt_Bai05_Click(object sender, EventArgs e)
        {
            var ChildForm = new Bai05();
            ChildForm.Show();
        }

        private void bt_Bai06_Click(object sender, EventArgs e)
        {
            var ChildForm = new Bai06();
            ChildForm.Show();
        }

        private void bt_Bai07_Click(object sender, EventArgs e)
        {
            var ChildForm = new Bai07();
            ChildForm.Show();
        }
    }
}

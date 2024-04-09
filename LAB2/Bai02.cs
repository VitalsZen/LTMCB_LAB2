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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void bt1_Read_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string s = fs.Name.ToString();
                int dem = sr.Peek();
                string k = sr.ReadToEnd();               
                tb1_Name.Text = ofd.SafeFileName.ToString();
                long ByteFile = new FileInfo(s).Length;
                tb2_Size.Text = ByteFile.ToString() + " bytes";
                tb3_URL.Text = s.ToString();
                tb4_LineC.Text = k.Split('\n').Length.ToString() ;
                tb5_WordsC.Text = k.Split(' ','\n').Length.ToString();
                tb6_CharC.Text = k.Length.ToString();
                rtb1.Text = k;
                fs.Close();
                if (k == "")
                    MessageBox.Show("File khong co du lieu nao");
                else
                    MessageBox.Show("Hien thi noi dung file tren richtextbox");
            }

            catch (IOException)
            {
                MessageBox.Show("Da xay ra loi doc file");
            }
            catch (Exception)
            {
                MessageBox.Show("Da xay ra loi");
            }
        }
    }
}

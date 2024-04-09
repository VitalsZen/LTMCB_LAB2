namespace LAB2
{

    public partial class Bai01 : Form
    {

        public Bai01()
        {
            InitializeComponent();
        }

        private void bt1_Read_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("input1.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                rtb1.Text = sr.ReadToEnd();
                fs.Close();
                if (rtb1.Text == "")
                    MessageBox.Show("File intput1.txt khong co du lieu nao");
                else
                    MessageBox.Show("Hien thi noi dung file");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Khong tim thay file input1.txt, tu chon file khac");
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                rtb1.Text = sr.ReadToEnd();
                fs.Close();
                if (rtb1.Text == "")
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

        private void bt2_Write_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("output1.txt", FileMode.Create);
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    sr.WriteLine(rtb1.Text);
                    MessageBox.Show("Da ghi file thanh cong");
                    sr.Close();
                }                    
            }
            catch (IOException)
            {
                MessageBox.Show("Da xay ra loi ghi file");
            }
            catch (Exception)
            {
                MessageBox.Show("Da xay ra loi");
            }
        }
    }
}

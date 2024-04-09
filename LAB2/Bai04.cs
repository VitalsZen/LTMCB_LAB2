using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LAB2
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }
        static int n = 0;
        static int page = 1;
        List<Bai04_Student> students = new List<Bai04_Student>();
        private void bt1_WtF_Click(object sender, EventArgs e)
        {
            if (tb7_Total.Text == "")
            {
                MessageBox.Show("Nhap so hoc sinh vao Total");
                tb7_Total.Enabled = true;
                rtb1_Show.Text = "Bấm vào đúng số lượng học sinh cần nhập vào ô Total";
                return;
            }

        }

        private void SerializeJson(object obj, string Filepath)
        {
            string json = JsonSerializer.Serialize(students);
            File.WriteAllText(Filepath, json);
        }
        private void ShowStudent(int pagenum)
        {
            pagenum--;
            tb1_OName.Text = students[pagenum].FullName;
            tb2_OID.Text = students[pagenum].ID.ToString();
            tb3_OPhone.Text = students[pagenum].PhoneNum;
            tb4_OC1.Text = students[pagenum].C1.ToString();
            tb5_OC2.Text = students[pagenum].C2.ToString();
            tb6_OC3.Text = students[pagenum].C3.ToString();
            tb7_OAvg.Text = students[pagenum].Avg.ToString();
        }

        private void EnableInput()
        {
            tb1_Name.Enabled = true;
            tb2_ID.Enabled = true;
            tb3_Phone.Enabled = true;
            tb4_C1.Enabled = true;
            tb5_C2.Enabled = true;
            tb6_C3.Enabled = true;
            bt2_Add.Enabled = true;
        }

        private void DisableInput()
        {
            tb1_Name.ReadOnly = true;
            tb2_ID.ReadOnly = true;
            tb3_Phone.ReadOnly = true;
            tb4_C1.ReadOnly = true;
            tb5_C2.ReadOnly = true;
            tb6_C3.ReadOnly = true;
            bt2_Add.Enabled = false;
            tb1_Name.Enabled = false;
            tb2_ID.Enabled = false;
            tb3_Phone.Enabled = false;
            tb4_C1.Enabled = false;
            tb5_C2.Enabled = false;
            tb6_C3.Enabled = false;
        }

        private void EnableOBt()
        {
            bt4_Next.Enabled = true;
            bt5_Prev.Enabled = true;
        }
        private List<Bai04_Student> DeserializeJson(string Filepath)
        {
            string json = File.ReadAllText(Filepath);
            List<Bai04_Student> students = JsonSerializer.Deserialize<List<Bai04_Student>>(json);
            return students;
        }
        private bool CheckLoiNhap()
        {
            if (tb2_ID.Text.Length != 8)
            {
                MessageBox.Show("ID can phai co 8 chu so!!");
                return true;
            }
            if (tb3_Phone.Text.Length != 10)
            {
                MessageBox.Show("So dien thoai can phai co 10 chu so!!");
                return true;
            }
            if (tb3_Phone.Text[0] != '0')
            {
                MessageBox.Show("So dien thoai can co so 0 dau tien");
                return true;
            }
            double num = Double.Parse(tb4_C1.Text);
            if (num < 0 || num > 10)
            {
                MessageBox.Show("So diem nhap o mon 1 khong hop li");
                return true;
            }
            num = Double.Parse(tb5_C2.Text);
            if (num < 0 || num > 10)
            {
                MessageBox.Show("So diem nhap o mon 2 khong hop li");
                return true;
            }
            num = Double.Parse(tb6_C3.Text);
            if (num < 0 || num > 10)
            {
                MessageBox.Show("So diem nhap o mon 3 khong hop li");
                return true;
            }
            if (tb1_Name.Text == "" ||
                tb2_ID.Text == "" ||
                tb3_Phone.Text == "" ||
                tb4_C1.Text == "" ||
                tb5_C2.Text == "" ||
                tb6_C3.Text == "")
            {
                MessageBox.Show("Xin moi nhap day du thong tin");
                return true;
            }
            return false;
        }
        private void bt2_Add_Click(object sender, EventArgs e)
        {
            if (CheckLoiNhap())
            {
                return;
            }

            Bai04_Student student = new Bai04_Student();
            int num = Int32.Parse(tb8_Count.Text);
            student.FullName = tb1_Name.Text;
            student.ID = Int32.Parse(tb2_ID.Text);
            student.PhoneNum = tb3_Phone.Text;
            student.C1 = float.Parse(tb4_C1.Text);
            student.C2 = float.Parse(tb5_C2.Text);
            student.C3 = float.Parse(tb6_C3.Text);
            students.Add(student);
            tb8_Count.Text = (num - 1).ToString();
            {
                MessageBox.Show("Nhap thanh cong!!, con lai " + tb8_Count.Text + " lan nhap");
                tb1_Name.Text = "";
                tb2_ID.Text = "";
                tb3_Phone.Text = "";
                tb4_C1.Text = "";
                tb5_C2.Text = "";
                tb6_C3.Text = "";
                tb7_Total.ReadOnly = true;
                tb7_Total.Enabled = false;
            }
            if (tb8_Count.Text == "0")
            {
                MessageBox.Show("Thực hiện đẩy thông tin vào file ....", "Canh bao", MessageBoxButtons.OK);
                SerializeJson(students, "input4.txt");
                rtb1_Show.Text = @"Ấn ""Read a file"" để đọc thông tin";
                DisableInput();
                bt3_Read.Enabled = true;
            }

        }

        private void tb7_Total_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(tb7_Total.Text, out int temp))
            {
                MessageBox.Show(@"Nhap so nguyen vao thanh ""Tong hoc sinh"": ");
                return;
            }
            n = temp;
            rtb1_Show.Text = "";
            tb8_Count.Text = n.ToString();
            MessageBox.Show("Nhap day du thong tin hoc sinh vao cac o phia duoi!! ");
            EnableInput();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rtb1_Show.Text = "";
                students = DeserializeJson("input4.txt");
                foreach (var student in students)
                {
                    student.Avg = (student.C1 + student.C2 + student.C3) / 3;
                    rtb1_Show.Text += student.FullName + '\n' + student.ID.ToString() + '\n' + student.PhoneNum + '\n' +
                       student.C1.ToString() + '\n' + student.C2.ToString() + '\n' + student.C3.ToString() + '\n' + student.Avg.ToString() + "\n\n\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SerializeJson(students, "output4.txt");
            bt3_Read.Enabled = false;
            ShowStudent(page);
            tb8_OPage.Text = page.ToString();
            EnableOBt();
        }

        private void bt4_Next_Click(object sender, EventArgs e)
        {
            if (page + 1 <= n)
            {
                page++;
                ShowStudent(page);
                tb8_OPage.Text = (page).ToString();
            }

        }

        private void bt5_Prev_Click(object sender, EventArgs e)
        {
            if (page - 1 > 0)
            {
                page--;
                ShowStudent(page);
                tb8_OPage.Text = (page).ToString();
            }

        }

    }
}

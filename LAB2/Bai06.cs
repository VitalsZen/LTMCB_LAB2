using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Bai06 : Form
    {
        private SQLiteConnection conn;
        private Random rnd;
        static string connstring = "Bai07_Database.db";
        static int CountMonAn = 1;
        static int CountNguoiDung = 1;

        public Bai06()
        {
            InitializeComponent();
            CheckIfDataExists("Bai07_Database.db");
            dataGridView2.DataSource = LoadJointList(connstring);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data source=" + connstring + ";Version = 3"))
            {
                //conn.Open();
                //SQLiteCommand delete = new SQLiteCommand("DELETE FROM MONAN ", conn);
                //delete.ExecuteNonQuery();
                //delete = new SQLiteCommand("DELETE FROM NGUOIDUNG ", conn);
                //delete.ExecuteNonQuery();
                //conn.Close();
                string query = "INSERT INTO MonAn ([IDMA], [TenMonAn], [HinhAnh], [IDNCC]) VALUES (@IDMA, @TenMonAn, @HinhAnh, @IDNCC)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@IDMA", "IDMA" + CountMonAn.ToString());
                    cmd.Parameters.AddWithValue("@TenMonAn", textBox1.Text);
                    cmd.Parameters.AddWithValue("@HinhAnh", textBox2.Text);
                    cmd.Parameters.AddWithValue("@IDNCC", "IDNCC" + CountNguoiDung.ToString());

                    cmd.ExecuteNonQuery();
                    CountMonAn++;
                }
                string query1 = "INSERT INTO NguoiDung ([IDNCC] , [HoVaTen], [QuyenHan]) VALUES (@IDNCC,@HoVaTen, @QuyenHan)";
                using (SQLiteCommand cmd = new SQLiteCommand(query1, conn))
                {

                    cmd.Parameters.AddWithValue("@IDNCC", "IDNCC" + CountNguoiDung.ToString());
                    cmd.Parameters.AddWithValue("@HoVaTen", textBox3.Text);
                    cmd.Parameters.AddWithValue("@QuyenHan", textBox4.Text);

                    cmd.ExecuteNonQuery();
                    CountNguoiDung++;
                }
                

            }
            dataGridView1.DataSource = LoadMonAnList(connstring);
            dataGridView2.DataSource = LoadJointList(connstring);

        }

        private void CheckIfDataExists(string filepath)
        {
            if (!File.Exists(filepath))
            {
                SQLiteConnection.CreateFile(filepath);
                using (SQLiteConnection conn = new SQLiteConnection("Data source=" + filepath + ";Version = 3"))
                {
                    string command_createtb_MonAn = "CREATE TABLE MonAn (IDMA TEXT (10) PRIMARY KEY NOT NULL UNIQUE,TenMonAn TEXT  NOT NULL," +
                        " HinhAnh TEXT, IDNCC TEXT REFERENCES NguoiDung (IDNCC) );";
                    using (SQLiteCommand cmd = new SQLiteCommand(command_createtb_MonAn, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                dataGridView1.DataSource = LoadMonAnList(filepath);
                CountNguoiDung = LoadNguoiDungList(filepath).Rows.Count + 1;
                CountMonAn = dataGridView1.RowCount + 1;
            }
        }
        private DataTable LoadNguoiDungList(string filepath)
        {
            DataTable dta = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data source=" + filepath + ";Version = 3"))
            {
                string query = "SELECT * FROM NguoiDung";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    dta.Load(reader);
                }
            }
            return dta;

        }

        private DataTable LoadMonAnList(string filepath)
        {
            DataTable dta = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data source=" + filepath + ";Version = 3"))
            {
                string query = "SELECT IDMA, TENMONAN, HINHANH, IDNCC FROM MonAn";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    dta.Load(reader);
                }
            }
            return dta;

        }
        private DataTable LoadJointList(string filepath)
        {
            DataTable dta = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data source=" + filepath + ";Version = 3"))
            {
                string query = "SELECT TenMonAn, HinhAnh, HoVaTen FROM MonAn JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    dta.Load(reader);
                }
            }
            return dta;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadNguoiDungList(connstring);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadMonAnList(connstring);
        }
        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower(); // lay duoi file 
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = LoadJointList(connstring);
            DataRow row = dt.Rows[RandomNumberGenerator.GetInt32(dt.Rows.Count)];
            string s = row["HinhAnh"].ToString() ;
            if (IsImageFile(s)) // check co phai image ko
            {
                pictureBox1.Image = Image.FromFile(s);
            }
            MessageBox.Show($"Món ăn hôm nay là = {row["TenMonAn"]}, Hinh anh = {row["HinhAnh"]}, Nguoi cung cap = {row["HoVaTen"]}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LAB2
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }


        private int Uutien(char op)
        {
            if (op == '+' || op == '-')
                return 1;
            if (op == '*' || op == '/')
                return 2;
            return 0;
        }

        private double TinhCapSo(double a, double b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
                default: return 0;
            }
        }

        private double Tinh(string chuoiso)
        {
            Stack<double> values = new Stack<double>(); 
            Stack<char> ops = new Stack<char>();

            for (int i = 0; i < chuoiso.Length; i++)
            {
                if (chuoiso[i] == ' ')
                    continue;

                if (char.IsDigit(chuoiso[i]) || chuoiso[i] == '.') // chuoiso[i] = so
                {
                    string operand = "";
                    while (i < chuoiso.Length && (char.IsDigit(chuoiso[i]) || chuoiso[i] == '.')) // truong hop so co tren 1 chu so
                    {
                        operand += chuoiso[i];
                        i++;
                    }
                    i--;
                    values.Push(double.Parse(operand)); // push vao luu trong stack
                }
                else if (chuoiso[i] == '(')
                {
                    ops.Push(chuoiso[i]);
                }
                else if (chuoiso[i] == ')')
                {
                    while (ops.Count > 0 && ops.Peek() != '(') // check da o trong ngoac don hay chua ? 
                    {
                        double val2 = values.Pop();
                        double val1 = values.Pop();
                        char op = ops.Pop();
                        values.Push(TinhCapSo(val1, val2, op));
                    }
                    if (ops.Count > 0 && ops.Peek() == '(')
                        ops.Pop(); // Remove '('
                }
                else
                {
                    while (ops.Count > 0 && Uutien(ops.Peek()) >= Uutien(chuoiso[i])) // check dau de uu tien nhan chia truoc
                    {
                        double val2 = values.Pop();
                        double val1 = values.Pop();
                        char op = ops.Pop();
                        values.Push(TinhCapSo(val1, val2, op));
                    }
                    ops.Push(chuoiso[i]);
                }
            }

            while (ops.Count > 0) // tinh nhưng gì còn lại trong stack
            {
                double val2 = values.Pop();
                double val1 = values.Pop();
                char op = ops.Pop();
                values.Push(TinhCapSo(val1, val2, op));
            }

            return values.Peek();
        }

        private void TinhvaGhi(string inputFile, string outputFile)
        {
            using (StreamReader sr = new StreamReader(inputFile))
            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    double result = Tinh(line);
                    sw.WriteLine($"{line} = {result}");
                }
            }
        }

        private void bt1_Read_Click_1(object sender, EventArgs e)
        {
            rtb1.Clear();
            try
            {
                FileStream fs = new FileStream("output3.txt", FileMode.Open);
                using (StreamReader sr = new StreamReader(fs))
                {
                    rtb1.Text += sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void bt2_Write_Click(object sender, EventArgs e)
        {
            try
            {
                TinhvaGhi("input3.txt", "output3.txt");
                MessageBox.Show("Tinh thanh cong ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

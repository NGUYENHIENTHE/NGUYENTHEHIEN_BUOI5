using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
            errorProvider2 = new ErrorProvider();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_a(object sender,EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
                this.errorProvider1.SetError(ctr, "Day khong phai la so");
            else
                this.errorProvider1.Clear();
        }
        private void textBox2_b(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
                this.errorProvider2.SetError(ctr, "Day khong phai la so");
            else
                this.errorProvider2.Clear();
        }
        private void frmBT1_FormClosing(object sender, CancelEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int soThuNhat = Convert.ToInt32(textBox1.Text);
            int soThuHai = Convert.ToInt32(textBox2.Text);
            int Kq = soThuNhat + soThuHai;
            textBox3.Text = Kq.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int soThuNhat = Convert.ToInt32(textBox1.Text);
            int soThuHai = Convert.ToInt32(textBox2.Text);
            int Kq = soThuNhat - soThuHai;
            textBox3.Text = Kq.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int soThuNhat = Convert.ToInt32(textBox1.Text);
            int soThuHai = Convert.ToInt32(textBox2.Text);
            int Kq = soThuNhat * soThuHai;
            textBox3.Text = Kq.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            float soThuNhat = float.Parse(textBox1.Text);
            float soThuHai = float.Parse(textBox2.Text);
            if (soThuHai == 0)
            {
                MessageBox.Show("nhap so b khac 0");
            }
            else
            {
                float chia = soThuNhat / soThuHai;
                textBox3.Text = chia.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please enter your user name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }
    }
}
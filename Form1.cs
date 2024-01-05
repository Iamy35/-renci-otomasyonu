using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace öğrenci_kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.No1 = maskedTextBox1.Text; //bu bilgiler showdan önce yazılmalı ki kaydedilsin.
            form2.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text == "1111")
            {
                Ogretmensayfa ogrt = new Ogretmensayfa();
                ogrt.Show();
            }
        }
    }
}

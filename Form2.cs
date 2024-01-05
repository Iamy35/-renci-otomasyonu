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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        public string No1;
        SqlConnection connection1 = new SqlConnection(@"Data Source=TSUMUGI-KOTOBUK\SQLEXPRESS;Initial Catalog=Dbnotkayit;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            labelNo.Text = No1;
            connection1.Open(); // bağlanti kuruluyor...
            SqlCommand komut1 = new SqlCommand("Select * from tbldersler where ogrenumara = @p1", connection1);
            komut1.Parameters.AddWithValue("@p1", No1);
            SqlDataReader verioku = komut1.ExecuteReader();
            while(verioku.Read()) // verileri okuması döngüsüne girdi.
            {
                labelname.Text = verioku[1].ToString() + " " + verioku[8].ToString();
                labelmidterm.Text = verioku[3].ToString();
                labelfinaex.Text = verioku[4].ToString();
                labelretake.Text = verioku[5].ToString();
                labelstatus.Text = verioku[7].ToString();
            }
            connection1.Close();
        }
    }
}

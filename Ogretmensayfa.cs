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
    public partial class Ogretmensayfa : Form
    {
        public Ogretmensayfa()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection connection1 = new SqlConnection(@"Data Source=TSUMUGI-KOTOBUK\SQLEXPRESS;Initial Catalog=Dbnotkayit;Integrated Security=True");
        private void Ogretmensayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbnotkayitDataSet.tblders' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbldersTableAdapter.Fill(this.dbnotkayitDataSet.tblders);

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection1.Open();
            SqlCommand komut2 = new SqlCommand("insert into tblders (ogrenumara, ogradi, ogrsoyad) values (@p1, @p2,@p3)", connection1);
            komut2.Parameters.AddWithValue("@p1", msk1.Text);
            komut2.Parameters.AddWithValue("@p2", textBoxname.Text);
            komut2.Parameters.AddWithValue("@p3", textBoxsurname.Text);
            komut2.ExecuteNonQuery();
            connection1.Close();
            MessageBox.Show("Student Added Successfully.");
            this.tbldersTableAdapter.Fill(this.dbnotkayitDataSet.tblders);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            msk1.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            label2.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            label3.Text = dataGridView1.Rows[chosen].Cells[8].Value.ToString();
            txtmidterm.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            txtfinalex.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            txtretake.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double average, midterm, final, retake;
            string status;
            midterm = Convert.ToDouble(txtmidterm.Text);
            final = Convert.ToDouble(txtfinalex.Text);
            retake = Convert.ToDouble(txtretake.Text);
            average = (midterm * 0.4) + (final * 0.6);
            if (average < 60)
            {
                average = (midterm * 0.4) + (retake * 0.6);
            }
            lblaverage.Text = average.ToString();
            if(average >= 60)
            {
                status = "True";
            }
            else
            {
                status = "False";
            }

            connection1.Open();
            SqlCommand komut3 = new SqlCommand("update tblders set ogrvize = @p1, ogrfinal = @p2, ogrbut = @p3, ogrortalama = @p4, ogrdurum = @p5 where ogrenumara = @p6", connection1);
            komut3.Parameters.AddWithValue("@p1", txtmidterm.Text);
            komut3.Parameters.AddWithValue("@p2", txtfinalex.Text);
            komut3.Parameters.AddWithValue("@p3", txtretake.Text);
            komut3.Parameters.AddWithValue("@p4", decimal.Parse(lblaverage.Text));
            komut3.Parameters.AddWithValue("@p5", status);
            komut3.Parameters.AddWithValue("@p6", msk1.Text);
            komut3.ExecuteNonQuery();
            connection1.Close();
            MessageBox.Show("Student grades upgraded.");
            this.tbldersTableAdapter.Fill(this.dbnotkayitDataSet.tblders);


        }
    }
}

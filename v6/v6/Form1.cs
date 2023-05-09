using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace performansV5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listele()
        {
            SQLiteConnection baglantii = new SQLiteConnection("Data Source=ege.db;version=3");

            baglantii.Open();
            SQLiteDataAdapter adaptorr = new SQLiteDataAdapter("SELECT * FROM urunler", baglantii);
            DataSet dataSet = new DataSet();
            adaptorr.Fill(dataSet, "urunler");
            dataGridView1.DataSource = dataSet.Tables["urunler"];
            baglantii.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string AD = textBox1.Text;
            string FİYAT = textBox2.Text;
            string KOD = textBox3.Text;
            string CİNS = textBox4.Text;
            string STOK = textBox5.Text;
            try
            {
                SQLiteConnection baglanti = new SQLiteConnection("Data Source=ege.db;version=3");
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO urunler VALUES('" + KOD + "','" + AD + "','" + FİYAT + "','" + CİNS + "','" + STOK + "')";
                komut.ExecuteNonQuery();
                listele();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string AD = textBox1.Text;
            string FİYAT = textBox2.Text;
            string KOD = textBox3.Text;
            string CİNS = textBox4.Text;
            string STOK = textBox5.Text;
            try
            {
                SQLiteConnection baglanti = new SQLiteConnection("Data Source=ege.db;version=3");
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE urunler SET ad='" + textBox1.Text + "',fiyat='" + textBox2.Text + "',cins='" + textBox4.Text + "',stok='" + textBox5.Text + "' WHERE ıd='" + textBox3.Text + "'";

                komut.ExecuteNonQuery();
                listele();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBox6.Text;
                SQLiteConnection baglantii = new SQLiteConnection("Data Source=ege.db;version=3");
                baglantii.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglantii;
                komut.CommandText = "DELETE FROM urunler WHERE ıd='" + num + "'";
                komut.ExecuteNonQuery();
                listele();
                baglantii.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.Message);
            }
            textBox6.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num = textBox6.Text;
            SQLiteConnection baglantii = new SQLiteConnection("Data Source=ege.db;version=3");
            baglantii.Open();
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglantii;
            komut.CommandText = "SELECT * FROM URUNLER WHERE ıd='" + num + "'";
            SQLiteDataReader okuyucu = komut.ExecuteReader();
            okuyucu.Read();
            textBox3.Text = okuyucu["ıd"].ToString();
            textBox1.Text = okuyucu["ad"].ToString();
            textBox2.Text = okuyucu["fiyat"].ToString();
            textBox4.Text = okuyucu["cins"].ToString();
            textBox5.Text = okuyucu["stok"].ToString();

            listele();
            baglantii.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Enabled = true;
            groupBox2.Visible = true;
            groupBox2.Enabled = true;

            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            listele();
        }

        private void listele2()
        {
            SQLiteConnection baglantii = new SQLiteConnection("Data Source=ege.db;version=3");
            baglantii.Open();
            SQLiteDataAdapter adaptorr = new SQLiteDataAdapter("SELECT * FROM musteri", baglantii);
            DataSet dataSet = new DataSet();
            adaptorr.Fill(dataSet, "musteri");
            dataGridView1.DataSource = dataSet.Tables["musteri"];
            baglantii.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Enabled = false;
            groupBox2.Visible = false;
            groupBox2.Enabled = false;

            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;

            SQLiteConnection baglantii = new SQLiteConnection("Data Source=ege.db;version=3");

            baglantii.Open();
            SQLiteDataAdapter adaptorr = new SQLiteDataAdapter("SELECT * FROM musteri", baglantii);
            DataSet dataSet = new DataSet();
            adaptorr.Fill(dataSet, "musteri");
            dataGridView1.DataSource = dataSet.Tables["musteri"];
            baglantii.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string ID = textBox11.Text;
            string AD = textBox10.Text;
            string SOYAD = textBox9.Text;
            string NUM = textBox8.Text;
            string SEHIR = textBox7.Text;
            try
            {
                SQLiteConnection baglanti = new SQLiteConnection("Data Source=ege.db;version=3");
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO musteri VALUES('" + ID + "','" + AD + "','" + SOYAD + "','" + NUM + "','" + SEHIR + "')";
                komut.ExecuteNonQuery();
                listele2();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.Message);
            }
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox7.Clear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string ID = textBox11.Text;
            string AD = textBox10.Text;
            string SOYAD = textBox9.Text;
            string NUM = textBox8.Text;
            string SEHIR = textBox7.Text;

            try
            {
                SQLiteConnection baglanti = new SQLiteConnection("Data Source=ege.db;version=3");
                baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE musteri SET ad='" + textBox10.Text + "',soyad='" + textBox9.Text + "',num='" + textBox8.Text + "',sehır='" + textBox7.Text + "' WHERE ıd='" + textBox11.Text + "'";
                listele2();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.Message);
            }
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox7.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string num = textBox12.Text;
                SQLiteConnection baglantii = new SQLiteConnection("Data Source=ege.db;version=3");
                baglantii.Open();
                SQLiteCommand komut = new SQLiteCommand();
                komut.Connection = baglantii;
                komut.CommandText = "DELETE FROM musteri WHERE ıd='" + num + "'";
                komut.ExecuteNonQuery();
                listele2();
                baglantii.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.Message);
            }
            textBox12.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string num = textBox12.Text;
            SQLiteConnection baglantii = new SQLiteConnection("Data Source=ege.db;version=3");
            baglantii.Open();
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglantii;
            komut.CommandText = "SELECT * FROM musteri WHERE ıd='" + num + "'";
            SQLiteDataReader okuyucu = komut.ExecuteReader();
            okuyucu.Read();
            textBox11.Text = okuyucu["ıd"].ToString();
            textBox10.Text = okuyucu["ad"].ToString();
            textBox9.Text = okuyucu["soyad"].ToString();
            textBox8.Text = okuyucu["num"].ToString();
            textBox7.Text = okuyucu["sehır"].ToString();

            listele2();
            baglantii.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

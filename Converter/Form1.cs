using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Jpeg")
            {
                TiffP.Visible = false;
                JpegP.Visible = true;
            }
            else
            {
                JpegP.Visible = false;
                TiffP.Visible = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Data.db"))
            {
                SQLiteConnection.CreateFile("Data.db");

                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Data.db;Version=3;");
                m_dbConnection.Open();

                string sql = "create table veri (jpeg int, tiff int)";

                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();

                sql = "insert into veri (jpeg, tiff) values (0, 0)";

                command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                m_dbConnection.Close();

                Jpeg.Text = "0";
                Tiff.Text = "0";
            }
            else
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Data.db;Version=3;");
                string sql = "select * from veri";
                SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, m_dbConnection);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Jpeg.Text = dt.Rows[0][0].ToString();
                Tiff.Text = dt.Rows[0][1].ToString();

            }
        }

        private void choose_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Act.Getİmage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void JpegP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TiffP.Visible == true) 
            { pictureBox2.Image = Act.SetQualityT(Convert.ToInt64(comboBox4.SelectedItem), (Bitmap)pictureBox1.Image); }
            else 
            { pictureBox2.Image = Act.SetQualityJ(Convert.ToInt64(comboBox4.SelectedItem), (Bitmap)pictureBox1.Image); }
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TiffP.Visible == true) 
            { 
                Act.SaveImageT(pictureBox2.Image);

                string deger = (int.Parse(Tiff.Text) + 1).ToString();
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Data.db;Version=3;");
                string sql = "update veri set tiff='"+  deger  +"'";
                m_dbConnection.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql,m_dbConnection);
                cmd.ExecuteNonQuery();

                string sql2 = "select * from veri";
                SQLiteDataAdapter adp = new SQLiteDataAdapter(sql2, m_dbConnection);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Jpeg.Text = dt.Rows[0][0].ToString();
                Tiff.Text = dt.Rows[0][1].ToString();
                m_dbConnection.Close();

            }
            else 
            { 
                Act.SaveImageJ(pictureBox2.Image);

                string deger = (int.Parse(Jpeg.Text) + 1).ToString();
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Data.db;Version=3;");
                string sql = "update veri set jpeg='" + deger + "'";
                m_dbConnection.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);
                cmd.ExecuteNonQuery();

                string sql1 = "select * from veri";
                SQLiteDataAdapter adp = new SQLiteDataAdapter(sql1, m_dbConnection);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Jpeg.Text = dt.Rows[0][0].ToString();
                Tiff.Text = dt.Rows[0][1].ToString();
                m_dbConnection.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Act.SetQualityT(Convert.ToInt64(comboBox4.SelectedItem), (Bitmap)pictureBox1.Image);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HowP.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HowP.Visible = false;
        }
    }
}

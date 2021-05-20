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
            if (TiffP.Visible == true) { pictureBox2.Image = Act.SetQualityT(Convert.ToInt64(comboBox4.SelectedItem), (Bitmap)pictureBox1.Image); }
            else { pictureBox2.Image = Act.SetQualityJ(Convert.ToInt64(comboBox4.SelectedItem), (Bitmap)pictureBox1.Image); }
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TiffP.Visible == true) { Act.SaveImageT(pictureBox2.Image); }
            else { Act.SaveImageJ(pictureBox2.Image); }
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

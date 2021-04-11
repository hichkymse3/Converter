using System;
using System.Drawing;
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
                demo.Visible = false;
                JpegP.Visible = true;
            }
            if (comboBox1.Text == "demo")
            {
                JpegP.Visible = false;
                demo.Visible = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void choose_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }
    }
}

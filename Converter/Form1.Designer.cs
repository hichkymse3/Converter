
namespace Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.choose = new System.Windows.Forms.Button();
            this.JpegP = new System.Windows.Forms.Panel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TiffP = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HowP = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.oran = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.JpegP.SuspendLayout();
            this.TiffP.SuspendLayout();
            this.HowP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(462, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(444, 380);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Convert to :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Jpeg",
            "Tiff"});
            this.comboBox1.Location = new System.Drawing.Point(227, 471);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(361, 414);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(195, 34);
            this.choose.TabIndex = 4;
            this.choose.Text = "Choose İmage";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // JpegP
            // 
            this.JpegP.Controls.Add(this.comboBox4);
            this.JpegP.Location = new System.Drawing.Point(676, 428);
            this.JpegP.Name = "JpegP";
            this.JpegP.Size = new System.Drawing.Size(210, 128);
            this.JpegP.TabIndex = 5;
            this.JpegP.Paint += new System.Windows.Forms.PaintEventHandler(this.JpegP_Paint);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "25",
            "50",
            "75",
            "100"});
            this.comboBox4.Location = new System.Drawing.Point(0, 43);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(182, 33);
            this.comboBox4.TabIndex = 0;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(462, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set quality to % :";
            // 
            // TiffP
            // 
            this.TiffP.Controls.Add(this.comboBox2);
            this.TiffP.Location = new System.Drawing.Point(676, 428);
            this.TiffP.Name = "TiffP";
            this.TiffP.Size = new System.Drawing.Size(189, 128);
            this.TiffP.TabIndex = 1;
            this.TiffP.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "25",
            "50",
            "75",
            "100"});
            this.comboBox2.Location = new System.Drawing.Point(0, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 33);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Compress";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(317, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 34);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HowP
            // 
            this.HowP.Controls.Add(this.button3);
            this.HowP.Controls.Add(this.pictureBox3);
            this.HowP.Location = new System.Drawing.Point(12, 12);
            this.HowP.Name = "HowP";
            this.HowP.Size = new System.Drawing.Size(894, 564);
            this.HowP.TabIndex = 7;
            this.HowP.Visible = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 38);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(894, 544);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // oran
            // 
            this.oran.AutoSize = true;
            this.oran.Location = new System.Drawing.Point(227, 507);
            this.oran.Name = "oran";
            this.oran.Size = new System.Drawing.Size(16, 25);
            this.oran.TabIndex = 8;
            this.oran.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 574);
            this.Controls.Add(this.oran);
            this.Controls.Add(this.HowP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TiffP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.JpegP);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.JpegP.ResumeLayout(false);
            this.TiffP.ResumeLayout(false);
            this.HowP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Panel JpegP;
        private System.Windows.Forms.Panel TiffP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel HowP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label oran;
    }
}


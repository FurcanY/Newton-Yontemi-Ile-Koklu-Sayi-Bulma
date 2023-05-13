namespace Newton_Yontemi_Ile_Koklu_Sayi_Bulma
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
            ustpanel = new Panel();
            label3 = new Label();
            cikis_btn = new Button();
            label2 = new Label();
            ustyazi_lbl = new Label();
            pictureBox1 = new PictureBox();
            info_lbl = new Label();
            derece_cmbox = new ComboBox();
            x1_lbl = new Label();
            x1_txtbox = new TextBox();
            panel1 = new Panel();
            baslat_btn = new Button();
            label1 = new Label();
            x6_txtbox = new TextBox();
            x4_txtbox = new TextBox();
            x2_txtbox = new TextBox();
            x5_txtbox = new TextBox();
            x3_txtbox = new TextBox();
            ilkdeger_txtbox = new TextBox();
            lotasyon_txtbox = new TextBox();
            x0_txtbox = new TextBox();
            x6_lbl = new Label();
            x4_lbl = new Label();
            x5_lbl = new Label();
            label5 = new Label();
            x3_lbl = new Label();
            x2_lbl = new Label();
            x0_lbl = new Label();
            label4 = new Label();
            sonuc_listbox = new ListBox();
            ayarlar_lbl = new Label();
            bilgi_pnl = new Panel();
            pictureBox2 = new PictureBox();
            ayar_pnl = new Panel();
            yazirenk_btn = new Button();
            textboxrenk_btn = new Button();
            bcolor_btn = new Button();
            ayartext_lbl = new Label();
            ustpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            bilgi_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ayar_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // ustpanel
            // 
            ustpanel.BackColor = Color.Black;
            ustpanel.Controls.Add(label3);
            ustpanel.Controls.Add(cikis_btn);
            ustpanel.Controls.Add(label2);
            ustpanel.Dock = DockStyle.Top;
            ustpanel.Location = new Point(0, 0);
            ustpanel.Name = "ustpanel";
            ustpanel.Size = new Size(1102, 57);
            ustpanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(697, 15);
            label3.Name = "label3";
            label3.Size = new Size(169, 29);
            label3.TabIndex = 1;
            label3.Text = "Github: FurcanY\r\nInstagram: y.furcan";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cikis_btn
            // 
            cikis_btn.FlatStyle = FlatStyle.Flat;
            cikis_btn.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cikis_btn.ForeColor = SystemColors.ControlLightLight;
            cikis_btn.ImageAlign = ContentAlignment.TopCenter;
            cikis_btn.Location = new Point(1040, 6);
            cikis_btn.Name = "cikis_btn";
            cikis_btn.Size = new Size(50, 45);
            cikis_btn.TabIndex = 3;
            cikis_btn.Text = "X";
            cikis_btn.UseVisualStyleBackColor = true;
            cikis_btn.Click += cikis_btn_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(531, 35);
            label2.TabIndex = 1;
            label2.Text = "NEWTON YONTEMI PROGRAMI";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ustyazi_lbl
            // 
            ustyazi_lbl.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ustyazi_lbl.Location = new Point(3, 9);
            ustyazi_lbl.Name = "ustyazi_lbl";
            ustyazi_lbl.Size = new Size(318, 35);
            ustyazi_lbl.TabIndex = 1;
            ustyazi_lbl.Text = "Fonskiyonun Derecesini Seciniz";
            ustyazi_lbl.TextAlign = ContentAlignment.MiddleCenter;
            ustyazi_lbl.Click += ustyazi_lbl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(666, 373);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // info_lbl
            // 
            info_lbl.BackColor = Color.Gray;
            info_lbl.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            info_lbl.ForeColor = SystemColors.ButtonHighlight;
            info_lbl.Location = new Point(876, 705);
            info_lbl.Name = "info_lbl";
            info_lbl.Size = new Size(104, 35);
            info_lbl.TabIndex = 1;
            info_lbl.Text = "Bilgi !";
            info_lbl.TextAlign = ContentAlignment.MiddleCenter;
            info_lbl.MouseEnter += info_lbl_MouseEnter;
            info_lbl.MouseLeave += info_lbl_MouseLeave;
            // 
            // derece_cmbox
            // 
            derece_cmbox.FormattingEnabled = true;
            derece_cmbox.Items.AddRange(new object[] { "1.dereceden", "2.dereceden", "3.dereceden", "4.dereceden", "5.dereceden", "6.dereceden" });
            derece_cmbox.Location = new Point(17, 47);
            derece_cmbox.Name = "derece_cmbox";
            derece_cmbox.Size = new Size(273, 23);
            derece_cmbox.TabIndex = 3;
            derece_cmbox.SelectedIndexChanged += derece_cmbox_SelectedIndexChanged;
            // 
            // x1_lbl
            // 
            x1_lbl.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            x1_lbl.Location = new Point(13, 110);
            x1_lbl.Name = "x1_lbl";
            x1_lbl.Size = new Size(208, 23);
            x1_lbl.TabIndex = 1;
            x1_lbl.Text = "x^1 katsayi girisi:";
            x1_lbl.TextAlign = ContentAlignment.MiddleCenter;
            x1_lbl.Visible = false;
            x1_lbl.Click += x1_lbl_Click;
            // 
            // x1_txtbox
            // 
            x1_txtbox.Location = new Point(239, 110);
            x1_txtbox.Name = "x1_txtbox";
            x1_txtbox.Size = new Size(51, 23);
            x1_txtbox.TabIndex = 4;
            x1_txtbox.Visible = false;
            x1_txtbox.TextChanged += x1_txtbox_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(baslat_btn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ustyazi_lbl);
            panel1.Controls.Add(x6_txtbox);
            panel1.Controls.Add(x4_txtbox);
            panel1.Controls.Add(x2_txtbox);
            panel1.Controls.Add(x5_txtbox);
            panel1.Controls.Add(x3_txtbox);
            panel1.Controls.Add(ilkdeger_txtbox);
            panel1.Controls.Add(lotasyon_txtbox);
            panel1.Controls.Add(x0_txtbox);
            panel1.Controls.Add(x1_txtbox);
            panel1.Controls.Add(x6_lbl);
            panel1.Controls.Add(x4_lbl);
            panel1.Controls.Add(x5_lbl);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(x3_lbl);
            panel1.Controls.Add(x2_lbl);
            panel1.Controls.Add(x0_lbl);
            panel1.Controls.Add(x1_lbl);
            panel1.Controls.Add(derece_cmbox);
            panel1.Location = new Point(12, 442);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 291);
            panel1.TabIndex = 5;
            // 
            // baslat_btn
            // 
            baslat_btn.BackColor = Color.White;
            baslat_btn.Enabled = false;
            baslat_btn.FlatStyle = FlatStyle.Flat;
            baslat_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            baslat_btn.Location = new Point(378, 9);
            baslat_btn.Name = "baslat_btn";
            baslat_btn.Size = new Size(89, 101);
            baslat_btn.TabIndex = 5;
            baslat_btn.Text = "Baslat";
            baslat_btn.UseVisualStyleBackColor = false;
            baslat_btn.Click += baslat_btn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 263);
            label1.Name = "label1";
            label1.Size = new Size(293, 22);
            label1.TabIndex = 1;
            label1.Text = "Literasyon Sayisini Giriniz : ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += ustyazi_lbl_Click;
            // 
            // x6_txtbox
            // 
            x6_txtbox.Location = new Point(239, 225);
            x6_txtbox.Name = "x6_txtbox";
            x6_txtbox.Size = new Size(51, 23);
            x6_txtbox.TabIndex = 4;
            x6_txtbox.Visible = false;
            x6_txtbox.TextChanged += x1_txtbox_TextChanged;
            // 
            // x4_txtbox
            // 
            x4_txtbox.Location = new Point(239, 179);
            x4_txtbox.Name = "x4_txtbox";
            x4_txtbox.Size = new Size(51, 23);
            x4_txtbox.TabIndex = 4;
            x4_txtbox.Visible = false;
            x4_txtbox.TextChanged += x1_txtbox_TextChanged;
            // 
            // x2_txtbox
            // 
            x2_txtbox.Location = new Point(239, 133);
            x2_txtbox.Name = "x2_txtbox";
            x2_txtbox.Size = new Size(51, 23);
            x2_txtbox.TabIndex = 4;
            x2_txtbox.Visible = false;
            x2_txtbox.TextChanged += x1_txtbox_TextChanged;
            // 
            // x5_txtbox
            // 
            x5_txtbox.Location = new Point(239, 202);
            x5_txtbox.Name = "x5_txtbox";
            x5_txtbox.Size = new Size(51, 23);
            x5_txtbox.TabIndex = 4;
            x5_txtbox.Visible = false;
            x5_txtbox.TextChanged += x1_txtbox_TextChanged;
            // 
            // x3_txtbox
            // 
            x3_txtbox.Location = new Point(239, 156);
            x3_txtbox.Name = "x3_txtbox";
            x3_txtbox.Size = new Size(51, 23);
            x3_txtbox.TabIndex = 4;
            x3_txtbox.Visible = false;
            x3_txtbox.TextChanged += x1_txtbox_TextChanged;
            // 
            // ilkdeger_txtbox
            // 
            ilkdeger_txtbox.Location = new Point(393, 202);
            ilkdeger_txtbox.Name = "ilkdeger_txtbox";
            ilkdeger_txtbox.Size = new Size(51, 23);
            ilkdeger_txtbox.TabIndex = 4;
            ilkdeger_txtbox.TextChanged += ilkdeger_txtbox_TextChanged;
            // 
            // lotasyon_txtbox
            // 
            lotasyon_txtbox.Location = new Point(302, 265);
            lotasyon_txtbox.Name = "lotasyon_txtbox";
            lotasyon_txtbox.Size = new Size(51, 23);
            lotasyon_txtbox.TabIndex = 4;
            lotasyon_txtbox.TextChanged += lotasyon_txtbox_TextChanged;
            // 
            // x0_txtbox
            // 
            x0_txtbox.Location = new Point(239, 87);
            x0_txtbox.Name = "x0_txtbox";
            x0_txtbox.Size = new Size(51, 23);
            x0_txtbox.TabIndex = 4;
            x0_txtbox.Visible = false;
            x0_txtbox.TextChanged += x1_txtbox_TextChanged;
            // 
            // x6_lbl
            // 
            x6_lbl.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            x6_lbl.Location = new Point(13, 225);
            x6_lbl.Name = "x6_lbl";
            x6_lbl.Size = new Size(208, 23);
            x6_lbl.TabIndex = 1;
            x6_lbl.Text = "x^6 katsayi girisi:";
            x6_lbl.TextAlign = ContentAlignment.MiddleCenter;
            x6_lbl.Visible = false;
            x6_lbl.Click += label7_Click;
            // 
            // x4_lbl
            // 
            x4_lbl.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            x4_lbl.Location = new Point(13, 179);
            x4_lbl.Name = "x4_lbl";
            x4_lbl.Size = new Size(208, 23);
            x4_lbl.TabIndex = 1;
            x4_lbl.Text = "x^4 katsayi girisi:";
            x4_lbl.TextAlign = ContentAlignment.MiddleCenter;
            x4_lbl.Visible = false;
            x4_lbl.Click += label5_Click;
            // 
            // x5_lbl
            // 
            x5_lbl.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            x5_lbl.Location = new Point(13, 202);
            x5_lbl.Name = "x5_lbl";
            x5_lbl.Size = new Size(208, 23);
            x5_lbl.TabIndex = 1;
            x5_lbl.Text = "x^5 katsayi girisi:";
            x5_lbl.TextAlign = ContentAlignment.MiddleCenter;
            x5_lbl.Visible = false;
            x5_lbl.Click += label6_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(378, 131);
            label5.Name = "label5";
            label5.Size = new Size(80, 71);
            label5.TabIndex = 1;
            label5.Text = "ilk lotasyonun\r\n degerini giriniz";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label4_Click;
            // 
            // x3_lbl
            // 
            x3_lbl.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            x3_lbl.Location = new Point(13, 156);
            x3_lbl.Name = "x3_lbl";
            x3_lbl.Size = new Size(208, 23);
            x3_lbl.TabIndex = 1;
            x3_lbl.Text = "x^3 katsayi girisi:";
            x3_lbl.TextAlign = ContentAlignment.MiddleCenter;
            x3_lbl.Visible = false;
            x3_lbl.Click += label4_Click;
            // 
            // x2_lbl
            // 
            x2_lbl.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            x2_lbl.Location = new Point(13, 133);
            x2_lbl.Name = "x2_lbl";
            x2_lbl.Size = new Size(208, 23);
            x2_lbl.TabIndex = 1;
            x2_lbl.Text = "x^2 katsayi girisi:";
            x2_lbl.TextAlign = ContentAlignment.MiddleCenter;
            x2_lbl.Visible = false;
            x2_lbl.Click += label1_Click;
            // 
            // x0_lbl
            // 
            x0_lbl.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            x0_lbl.Location = new Point(13, 87);
            x0_lbl.Name = "x0_lbl";
            x0_lbl.Size = new Size(208, 23);
            x0_lbl.TabIndex = 1;
            x0_lbl.Text = "x^0 katsayi girisi:";
            x0_lbl.TextAlign = ContentAlignment.MiddleCenter;
            x0_lbl.Visible = false;
            x0_lbl.Click += label8_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(797, 63);
            label4.Name = "label4";
            label4.Size = new Size(215, 35);
            label4.TabIndex = 1;
            label4.Text = "Sonuçlar:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sonuc_listbox
            // 
            sonuc_listbox.FormattingEnabled = true;
            sonuc_listbox.ItemHeight = 15;
            sonuc_listbox.Location = new Point(727, 101);
            sonuc_listbox.Name = "sonuc_listbox";
            sonuc_listbox.Size = new Size(350, 334);
            sonuc_listbox.TabIndex = 6;
            sonuc_listbox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ayarlar_lbl
            // 
            ayarlar_lbl.BackColor = Color.Gray;
            ayarlar_lbl.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ayarlar_lbl.ForeColor = SystemColors.ButtonHighlight;
            ayarlar_lbl.Location = new Point(986, 705);
            ayarlar_lbl.Name = "ayarlar_lbl";
            ayarlar_lbl.Size = new Size(104, 35);
            ayarlar_lbl.TabIndex = 1;
            ayarlar_lbl.Text = "Ayarlar";
            ayarlar_lbl.TextAlign = ContentAlignment.MiddleCenter;
            ayarlar_lbl.MouseEnter += ayarlar_lbl_MouseEnter;
            // 
            // bilgi_pnl
            // 
            bilgi_pnl.BackColor = Color.White;
            bilgi_pnl.Controls.Add(pictureBox2);
            bilgi_pnl.Location = new Point(9, 64);
            bilgi_pnl.Name = "bilgi_pnl";
            bilgi_pnl.Size = new Size(666, 371);
            bilgi_pnl.TabIndex = 7;
            bilgi_pnl.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(663, 313);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // ayar_pnl
            // 
            ayar_pnl.BackColor = Color.White;
            ayar_pnl.Controls.Add(yazirenk_btn);
            ayar_pnl.Controls.Add(textboxrenk_btn);
            ayar_pnl.Controls.Add(bcolor_btn);
            ayar_pnl.Controls.Add(ayartext_lbl);
            ayar_pnl.Location = new Point(876, 473);
            ayar_pnl.Name = "ayar_pnl";
            ayar_pnl.Size = new Size(214, 229);
            ayar_pnl.TabIndex = 8;
            ayar_pnl.Visible = false;
            // 
            // yazirenk_btn
            // 
            yazirenk_btn.BackColor = Color.Black;
            yazirenk_btn.FlatStyle = FlatStyle.Flat;
            yazirenk_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yazirenk_btn.ForeColor = SystemColors.ButtonFace;
            yazirenk_btn.Location = new Point(28, 153);
            yazirenk_btn.Name = "yazirenk_btn";
            yazirenk_btn.Size = new Size(163, 37);
            yazirenk_btn.TabIndex = 2;
            yazirenk_btn.Text = "Yazi Rengi";
            yazirenk_btn.UseVisualStyleBackColor = false;
            yazirenk_btn.Click += yazirenk_btn_Click;
            // 
            // textboxrenk_btn
            // 
            textboxrenk_btn.BackColor = Color.Black;
            textboxrenk_btn.FlatStyle = FlatStyle.Flat;
            textboxrenk_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textboxrenk_btn.ForeColor = SystemColors.ButtonFace;
            textboxrenk_btn.Location = new Point(28, 112);
            textboxrenk_btn.Name = "textboxrenk_btn";
            textboxrenk_btn.Size = new Size(163, 37);
            textboxrenk_btn.TabIndex = 2;
            textboxrenk_btn.Text = "Textbox Rengi";
            textboxrenk_btn.UseVisualStyleBackColor = false;
            textboxrenk_btn.Click += textboxrenk_btn_Click;
            // 
            // bcolor_btn
            // 
            bcolor_btn.BackColor = Color.Black;
            bcolor_btn.FlatStyle = FlatStyle.Flat;
            bcolor_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bcolor_btn.ForeColor = SystemColors.ButtonFace;
            bcolor_btn.Location = new Point(28, 69);
            bcolor_btn.Name = "bcolor_btn";
            bcolor_btn.Size = new Size(163, 37);
            bcolor_btn.TabIndex = 2;
            bcolor_btn.Text = "Arkaplan Rengi";
            bcolor_btn.UseVisualStyleBackColor = false;
            bcolor_btn.Click += bcolor_btn_Click;
            // 
            // ayartext_lbl
            // 
            ayartext_lbl.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ayartext_lbl.Location = new Point(31, 5);
            ayartext_lbl.Name = "ayartext_lbl";
            ayartext_lbl.Size = new Size(160, 46);
            ayartext_lbl.TabIndex = 1;
            ayartext_lbl.Text = "AYARLAR";
            ayartext_lbl.TextAlign = ContentAlignment.MiddleCenter;
            ayartext_lbl.Click += ustyazi_lbl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1102, 745);
            Controls.Add(ayar_pnl);
            Controls.Add(bilgi_pnl);
            Controls.Add(sonuc_listbox);
            Controls.Add(panel1);
            Controls.Add(ayarlar_lbl);
            Controls.Add(info_lbl);
            Controls.Add(label4);
            Controls.Add(ustpanel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = resources.GetString("$this.Text");
            Load += Form1_Load;
            ustpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            bilgi_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ayar_pnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ustpanel;
        private Button cikis_btn;
        private Label label2;
        private Label ustyazi_lbl;
        private PictureBox pictureBox1;
        private Label info_lbl;
        private ComboBox derece_cmbox;
        private Label label3;
        private Label x1_lbl;
        private TextBox x1_txtbox;
        private Panel panel1;
        private TextBox x6_txtbox;
        private TextBox x4_txtbox;
        private TextBox x2_txtbox;
        private TextBox x5_txtbox;
        private TextBox x3_txtbox;
        private TextBox x0_txtbox;
        private Label x6_lbl;
        private Label x4_lbl;
        private Label x5_lbl;
        private Label x3_lbl;
        private Label x2_lbl;
        private Label x0_lbl;
        private Label label1;
        private TextBox lotasyon_txtbox;
        private Button baslat_btn;
        private Label label4;
        private ListBox sonuc_listbox;
        private TextBox ilkdeger_txtbox;
        private Label label5;
        private Label ayarlar_lbl;
        private Panel bilgi_pnl;
        private PictureBox pictureBox2;
        private Panel ayar_pnl;
        private Button yazirenk_btn;
        private Button textboxrenk_btn;
        private Button bcolor_btn;
        private Label ayartext_lbl;
    }
}
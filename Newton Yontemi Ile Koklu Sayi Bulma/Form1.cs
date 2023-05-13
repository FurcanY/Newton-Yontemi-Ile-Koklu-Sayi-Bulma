using System.DirectoryServices.ActiveDirectory;
using System.Security.Cryptography.X509Certificates;

namespace Newton_Yontemi_Ile_Koklu_Sayi_Bulma
{
    public partial class Form1 : Form
    {
        int dereceIndex;
        int[] katsayilar = new int[7];
        int[] turevkatsayilar = new int[7];
        //turev katsayilarde 0.dereceden yok olur onu direkt yok sayabiliriz. kafa karismasin diye 7 elemanli yapilir.
        int litsayisi = 0;
        float x = 0, sonuc = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void GoruntuResetle()
        {
            x1_lbl.Visible = false;
            x1_txtbox.Visible = false;

            x2_lbl.Visible = false;
            x2_txtbox.Visible = false;

            x3_lbl.Visible = false;
            x3_txtbox.Visible = false;

            x4_lbl.Visible = false;
            x4_txtbox.Visible = false;

            x5_lbl.Visible = false;
            x5_txtbox.Visible = false;

            x6_lbl.Visible = false;
            x6_txtbox.Visible = false;
        }
        private void derece_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GoruntuResetle();
            baslat_btn.Enabled = true;
            dereceIndex = derece_cmbox.SelectedIndex + 1;
            for (int i = 0; i <= dereceIndex; i++)
            {


                switch (i)
                {

                    case 0:
                        x0_lbl.Visible = true;
                        x0_txtbox.Visible = true;
                        x0_txtbox.Text = "0";
                        break;
                    case 1:
                        x1_lbl.Visible = true;
                        x1_txtbox.Visible = true;
                        x1_txtbox.Text = "0";
                        break;
                    case 2:
                        x2_lbl.Visible = true;
                        x2_txtbox.Visible = true;
                        x2_txtbox.Text = "0";
                        break;
                    case 3:
                        x3_lbl.Visible = true;
                        x3_txtbox.Visible = true;
                        x3_txtbox.Text = "0";
                        break;
                    case 4:
                        x4_lbl.Visible = true;
                        x4_txtbox.Visible = true;
                        x4_txtbox.Text = "0";
                        break;
                    case 5:
                        x5_lbl.Visible = true;
                        x5_txtbox.Visible = true;
                        x5_txtbox.Text = "0";
                        break;
                    case 6:
                        x6_lbl.Visible = true;
                        x6_txtbox.Visible = true;
                        x6_txtbox.Text = "0";
                        break;
                }
            }


        }

        private void x1_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ustyazi_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void x1_lbl_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lotasyon_txtbox_TextChanged(object sender, EventArgs e)
        {
            litsayisi = Convert.ToInt32(lotasyon_txtbox.Text);
        }

        private void baslat_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dereceIndex; i++)
            {
                switch (i)
                {

                    case 0:
                        katsayilar[0] = Convert.ToInt32(x0_txtbox.Text);

                        break;
                    case 1:
                        katsayilar[1] = Convert.ToInt32(x1_txtbox.Text);
                        turevkatsayilar[0] = katsayilar[1];
                        break;
                    case 2:
                        katsayilar[2] = Convert.ToInt32(x2_txtbox.Text);
                        turevkatsayilar[1] = katsayilar[2] * 2;
                        break;
                    case 3:
                        katsayilar[3] = Convert.ToInt32(x3_txtbox.Text);
                        turevkatsayilar[2] = katsayilar[3] * 3;
                        break;
                    case 4:
                        katsayilar[4] = Convert.ToInt32(x4_txtbox.Text);
                        turevkatsayilar[3] = katsayilar[4] * 4;
                        break;
                    case 5:
                        katsayilar[5] = Convert.ToInt32(x5_txtbox.Text);
                        turevkatsayilar[4] = katsayilar[5] * 5;
                        break;
                    case 6:
                        katsayilar[6] = Convert.ToInt32(x6_txtbox.Text);
                        turevkatsayilar[5] = katsayilar[6] * 6;
                        break;
                }
            }
            for (int i = 1; i <= litsayisi; i++)
            {
                sonuc = x - (FonksiyonHesapla(ref katsayilar, ref dereceIndex) / TurevHesapla(ref turevkatsayilar, ref dereceIndex));
                sonuc_listbox.Items.Add(x + " icin Fonskiyon sonuc sonucu:" + FonksiyonHesapla(ref katsayilar, ref dereceIndex));
                sonuc_listbox.Items.Add(x + " icin Turev sonuc sonucu:" + TurevHesapla(ref turevkatsayilar, ref dereceIndex));
                sonuc_listbox.Items.Add(i.ToString() + ". literasyon sonucu:" + sonuc);
                sonuc_listbox.Items.Add("----------------------------");
                x = sonuc;


            }


        }
        float TurevHesapla(ref int[] turevkatsayilar, ref int dereceIndex)
        {
            float sonuc = 0;
            for (int i = 1; i < dereceIndex; i++)
            {
                sonuc += turevkatsayilar[i] * ustAl(ref x, ref i);
            }
            return sonuc;

        }
        float ustAl(ref float x, ref int derece)
        {
            float sonuc = 1;
            if (x == 0)
                return 0;
            else if (x == 1 || derece == 0)
                return 1;
            else if (derece == 1)
                return x;
            for (int i = 0; i < derece; i++)
            {
                sonuc *= x;
            }
            return sonuc;
        }
        float FonksiyonHesapla(ref int[] katsayilar, ref int dereceIndex)
        {
            float sonuc = 0;
            for (int i = 0; i <= dereceIndex; i++)
            {
                sonuc += katsayilar[i] * ustAl(ref x, ref i);
            }
            return sonuc;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ilkdeger_txtbox_TextChanged(object sender, EventArgs e)
        {
            x = Convert.ToInt32(ilkdeger_txtbox.Text);
        }

        private void info_lbl_MouseLeave(object sender, EventArgs e)
        {
            bilgi_pnl.Visible = false;
            info_lbl.BackColor = Color.Gray;
        }

        private void info_lbl_MouseEnter(object sender, EventArgs e)
        {
            bilgi_pnl.Visible = true;
            info_lbl.BackColor = Color.Green;
        }
        bool girdiMi = false;
        private void ayarlar_lbl_MouseEnter(object sender, EventArgs e)
        {
            if (girdiMi)
            {
                ayar_pnl.Visible = false;
                girdiMi = false;
                ayarlar_lbl.BackColor = Color.Gray;
            }
            else if (girdiMi == false)
            {
                ayarlar_lbl.BackColor = Color.Green;
                ayar_pnl.Visible = true;
                girdiMi = true;
            }
        }

        private void bcolor_btn_Click(object sender, EventArgs e)
        {
            ColorDialog mydialog = new ColorDialog();
            mydialog.ShowDialog();
            BackColor = mydialog.Color;
        }

        private void textboxrenk_btn_Click(object sender, EventArgs e)
        {
            ColorDialog mydialog = new ColorDialog();
            mydialog.ShowDialog();
            derece_cmbox.BackColor = mydialog.Color;
            x0_txtbox.BackColor = mydialog.Color;
            x1_txtbox.BackColor = mydialog.Color;
            x2_txtbox.BackColor = mydialog.Color;
            x3_txtbox.BackColor = mydialog.Color;
            x4_txtbox.BackColor = mydialog.Color;
            x5_txtbox.BackColor = mydialog.Color;
            x6_txtbox.BackColor = mydialog.Color;
            lotasyon_txtbox.BackColor = mydialog.Color;
            ilkdeger_txtbox.BackColor = mydialog.Color;
            sonuc_listbox.BackColor = mydialog.Color;
        }

        private void yazirenk_btn_Click(object sender, EventArgs e)
        {
            ColorDialog mydialog = new ColorDialog();
            mydialog.ShowDialog();
            ustyazi_lbl.ForeColor = mydialog.Color;
            x0_lbl.ForeColor = mydialog.Color;
            x1_lbl.ForeColor = mydialog.Color;
            x2_lbl.ForeColor = mydialog.Color;
            x3_lbl.ForeColor = mydialog.Color;
            x4_lbl.ForeColor = mydialog.Color;
            x5_lbl.ForeColor = mydialog.Color;
            x6_lbl.ForeColor = mydialog.Color;
            label1.ForeColor = mydialog.Color;
            label5.ForeColor = mydialog.Color;
            label4.ForeColor = mydialog.Color;
            derece_cmbox.ForeColor = mydialog.Color;
            x0_txtbox.ForeColor = mydialog.Color;
            x1_txtbox.ForeColor = mydialog.Color;
            x2_txtbox.ForeColor = mydialog.Color;
            x3_txtbox.ForeColor = mydialog.Color;
            x4_txtbox.ForeColor = mydialog.Color;
            x5_txtbox.ForeColor = mydialog.Color;
            x6_txtbox.ForeColor = mydialog.Color;
            lotasyon_txtbox.ForeColor = mydialog.Color;
            ilkdeger_txtbox.ForeColor = mydialog.Color;
            sonuc_listbox.ForeColor = mydialog.Color;

        }
    }
}
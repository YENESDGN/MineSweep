using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            butonUret(); // Form yüklendiğinde otomatik olarak butonlar oluşturulacak
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void butonUret()
        {
            flowLayoutPanel1.Controls.Clear();
            Random rnd = new Random();

            List<int> mayinlar = new List<int>();
            for (int i = 1; mayinlar.Count < 15; i++)
            {
                int sayi = rnd.Next(1, 69);
                if (!mayinlar.Contains(sayi))
                {
                    mayinlar.Add(sayi);
                }
            }

            for (int i = 1; i < 69; i++)
            {
                Button btn = new Button
                {
                    Size = new Size(35, 35),
                    Text = i.ToString()
                };

                if (mayinlar.Contains(i))
                {
                    btn.Tag = true;
                }
                else
                {
                    btn.Tag = false;
                }
                btn.Click += Btn_Click;

                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        int secilen = 0;
        int bulunan = 0;

        private void Btn_Click(object sender, EventArgs e)
        {
            Button basilanButon = (Button)sender;
            bool mayin = (bool)basilanButon.Tag;
            secilen++;

            if (mayin)
            {
                basilanButon.BackColor = Color.Red;
                basilanButon.Enabled = false;
                MessageBox.Show("Mayın Bulundu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bulunan++;
                secilen--;
            }
            else
            {
                basilanButon.BackColor = Color.Green;
            }

            textBox1.Text = secilen.ToString();
            textBox2.Text = bulunan.ToString();

            if (bulunan == 15)
            {
                MessageBox.Show("Tüm mayınlar bulundu. Tebrikler!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Oyuna devam edilir, sıfırlama yok
            }
        }
    }
}

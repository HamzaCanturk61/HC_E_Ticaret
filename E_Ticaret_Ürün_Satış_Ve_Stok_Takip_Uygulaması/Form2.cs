using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace market_takip
{
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frm1.tcKimlikKontrol();
            if (frm1.durum == false)
            {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
                {
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;
                    frm1.kmt.CommandText = "INSERT INTO musteribil(musteriAdi,musteriSoyadi,tcKimlik,cepTel,evTel,adres) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
                    frm1.kmt.ExecuteNonQuery();                                                    
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                    frm1.musteriListele();
                    MessageBox.Show("Kayıt işlemi tamamlandı ! ");
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                    }
                }
                else 
                { 
                    MessageBox.Show("Lütfen Ad-Soyad-Tckimlik alanlarını boş bırakmayınız");
                }
            }
            else MessageBox.Show("Girmiş olduğunuz Tc Kimlik mevcut !");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();  
        }
    }
}

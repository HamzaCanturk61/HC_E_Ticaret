﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace market_takip
{
    public partial class Form13 : Form
    {
        public Form1 frm1;
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            frm1.urunComboEkle();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frm1.urunKontrol();
            if (frm1.durum == false)
            {
                double sfiyat;
                sfiyat = double.Parse(textBox1.Text) + double.Parse(textBox1.Text) * ( double.Parse(textBox2.Text)/100);
                if (comboBox1.Text.Trim() != "")
                {
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;
                    frm1.kmt.CommandText = "INSERT INTO stokbil(urunAdi,adet,birimFiyat,kdv,satisFiyat) VALUES ('" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + sfiyat.ToString() + "') ";
                    frm1.kmt.ExecuteNonQuery();                                                   
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                   frm1.stokListele();
                    MessageBox.Show("Kayıt işlemi tamamlandı ! ");
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                         if (this.Controls[i] is CheckBox) this.Controls[i].Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Ürün Adı alanını boş bırakmayınız");
                }
            }
            else MessageBox.Show("Girmiş olduğunuz Ürün mevcut");
        }
    }
    }


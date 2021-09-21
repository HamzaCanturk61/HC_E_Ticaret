using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace market_takip
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public Form6 frm6;
        public Form7 frm7;
        public Form8 frm8;//
        public Form9 frm9;
        public Form10 frm10;
        public Form11 frm11;
        public Form12 frm12;
        public Form13 frm13;
        public Form14 frm14;
        public Form15 frm15;
        public Form16 frm16;
       
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();
            frm6 = new Form6();
            frm7 = new Form7();
            frm8 = new Form8();
            frm9 = new Form9();
            frm10 = new Form10();
            frm11 = new Form11();
            frm12 = new Form12();
            frm13 = new Form13();
            frm14 = new Form14();
            frm15 = new Form15();
            frm16 = new Form16();
           
            frm2.frm1 = this;
            frm3.frm1 = this;//
            frm4.frm1 = this;
            frm5.frm1 = this;
            frm6.frm1 = this;
            frm7.frm1 = this;
            frm8.frm1 = this;
            frm9.frm1 = this;
            frm10.frm1 = this;
            frm11.frm1 = this;
            frm12.frm1 = this;
            frm13.frm1 = this;
            frm14.frm1 = this;
            frm15.frm1 = this;
            frm16.frm1 = this;
           
        }

        public SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\data.mdf;Integrated Security=True;User Instance=True");
        
        public DataTable tabloMusteri = new DataTable();     
        public DataTable tabloUrun = new DataTable();     
        public DataTable tabloKategori= new DataTable(); 
        public DataTable tabloFirma = new DataTable(); 
        public DataTable tabloKasiyer = new DataTable();
        public DataTable tabloStok = new DataTable();
        public DataTable tabloSatis = new DataTable();
        public SqlCommand kmt = new SqlCommand();

        public bool durum;
        public void gununSatisListele()
        {
            tabloSatis.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select faturaNo,musteriAdi,musteriSoyadi,tcKimlik,urunAdi,satisFiyat,adet,toplamTutar,kasaNo,tarih from satisbil Where tarih = '" + "'", bag);   
            adtr.Fill(tabloSatis);
            dataGridView1.DataSource = tabloSatis;
            bag.Close();
        }
        public void tcKimlikKasiyerKontrol()
        {
            durum = false;
            byte sayTcKimilk;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select Count (tcKimlik) from kasiyerbil Where tcKimlik='" + frm10.textBox3.Text + "'";
            sayTcKimilk = byte.Parse(kmt.ExecuteScalar().ToString());
            if (sayTcKimilk > 0) durum = true;
            bag.Close();
        }
        public void tcKimlikKontrol()
        {
            durum = false;
            byte sayTcKimilk;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select Count (tcKimlik) from musteribil Where tcKimlik='" + frm2.textBox3.Text + "'";
            sayTcKimilk = byte.Parse(kmt.ExecuteScalar().ToString());
            if (sayTcKimilk > 0) durum = true;
            bag.Close();//
        }

        public void urunKontrol()
        {
            durum = false;
            byte sayUrun;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select Count (urunAdi) from stokbil Where urunAdi='" + frm13.comboBox1.Text + "'";
            sayUrun = byte.Parse(kmt.ExecuteScalar().ToString());//
            if (sayUrun > 0) durum = true;
            bag.Close();
        }
        public void urunKoduKontrol()
        {
            durum = false;
            byte sayUrunKodu;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select Count (urunKodu) from urunbil Where urunKodu='" + frm5.textBox2.Text + "'";
            sayUrunKodu = byte.Parse(kmt.ExecuteScalar().ToString());
            if (sayUrunKodu> 0) durum = true;
            bag.Close();
        }
        public void musteriListele()
        {
            tabloMusteri.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select musteriAdi,musteriSoyadi,tcKimlik,cepTel,evTel,adres from musteribil", bag);
            adtr.Fill(tabloMusteri);
            frm3.dataGridView1.DataSource = tabloMusteri;//
            frm16.dataGridView1.DataSource = tabloMusteri;
            bag.Close();
        }
        public void urunListele()
        {
            tabloUrun.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select urunAdi,urunKodu,firmaAdi,alisFiyati,satisFiyati,kategori from urunbil", bag);
            adtr.Fill(tabloUrun);
            frm6.dataGridView1.DataSource = tabloUrun;
            bag.Close();
        }
        public void kategoriListele()
        {
            tabloKategori.Clear();//
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select kategoriAdi from kategoribil", bag);
            adtr.Fill(tabloKategori);
            frm8.dataGridView1.DataSource = tabloKategori;
            bag.Close();
        }
        public void firmaListele()
        {
            tabloFirma.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select firmaAdi,firmaAdresi from firmabil", bag);
            adtr.Fill(tabloFirma);
            frm9.dataGridView1.DataSource = tabloFirma;
            bag.Close();
        }
        public void kasiyerListele()
        {
            tabloKasiyer.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select ad,soyad,tcKimlik,cepTel,evTel,adres,maas,kasaNo,gorevBaslangici,gorevBitimi from kasiyerbil", bag);
            adtr.Fill(tabloKasiyer);
            frm11.dataGridView1.DataSource = tabloKasiyer;
            bag.Close();
        }
        public void stokListele()//
        {
            tabloStok.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select urunAdi,adet,birimFiyat,kdv,satisFiyat from stokbil", bag);
            adtr.Fill(tabloStok);
            frm14.dataGridView1.DataSource =tabloStok;
            bag.Close();
        }
        public void urunComboEkle()
        {
            frm13.comboBox1.Items.Clear(); frm15.comboBox1.Items.Clear();
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select urunAdi from urunbil";//
            SqlDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                if (frm13.comboBox1.Items.IndexOf(oku[0].ToString()) == -1 && oku[0].ToString().Trim() != "") frm13.comboBox1.Items.Add(oku[0].ToString());
                if (frm15.comboBox1.Items.IndexOf(oku[0].ToString()) == -1 && oku[0].ToString().Trim() != "") frm15.comboBox1.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
        }

        public void urunSatisComboEkle()
        {
            frm16.comboBox2.Items.Clear();//
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select urunAdi from stokbil Where adet>0";
            SqlDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                if (frm16.comboBox2.Items.IndexOf(oku[0].ToString()) == -1 && oku[0].ToString().Trim() != "") frm16.comboBox2.Items.Add(oku[0].ToString());

            }
            bag.Close();
            oku.Dispose();
        }
        public void urunSatisFiyatTextEkle()
        {
         
            bag.Open();
            kmt.Connection = bag;//
            kmt.CommandText = "Select urunAdi,satisFiyat from stokbil";
            SqlDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                if (frm16.comboBox2.Text==oku[0].ToString()) frm16.textBox6.Text=oku[1].ToString();
                
            }
            bag.Close();
            oku.Dispose();
        }
        public void firmaComboEkle()
        {
            frm5.comboBox1.Items.Clear();
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select firmaAdi from firmabil";
            SqlDataReader oku;
            oku = kmt.ExecuteReader();//
            while (oku.Read())
            {
                if (frm5.comboBox1.Items.IndexOf(oku[0].ToString()) == -1 && oku[0].ToString().Trim() != "") frm5.comboBox1.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
        }
        public void kategoriComboEkle()
        {
            frm5.comboBox2.Items.Clear();
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select kategoriAdi from kategoribil";
            SqlDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                if (frm5.comboBox2.Items.IndexOf(oku[0].ToString()) == -1 && oku[0].ToString().Trim() != "") frm5.comboBox2.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gununSatisListele();//
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;            
                dataGridView1.Columns[0].HeaderText = "Fatura No";
                dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
                dataGridView1.Columns[2].HeaderText = "Müşteri Soyadı";
                dataGridView1.Columns[3].HeaderText = "Tc Kimlik";
                dataGridView1.Columns[4].HeaderText = "Ürün Adı";
                dataGridView1.Columns[5].HeaderText = "Satış Fiyatı";
                dataGridView1.Columns[6].HeaderText = "Adet";
                dataGridView1.Columns[7].HeaderText = "Toplam Tutar";
                dataGridView1.Columns[8].HeaderText = "Kasa No";
                dataGridView1.Columns[9].HeaderText = "Tarih";
            }
            catch
            {
                ;
            }
        }

        private void btnMusIslem_Click(object sender, EventArgs e)
        {
            frm3.ShowDialog();
            //form3 ü aç.//
            
        }

        private void btnUrunIslem_Click(object sender, EventArgs e)
        {
            frm6.ShowDialog();
        }

        private void btnKasiyerIslem_Click(object sender, EventArgs e)
        {
            frm11.ShowDialog();
        }

        private void btnStokIslem_Click(object sender, EventArgs e)
        {
            frm14.ShowDialog();
        }

        private void btnSatisIslem_Click(object sender, EventArgs e)
        {
            frm16.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSatisGoster_Click(object sender, EventArgs e)
        {
            gununSatisListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

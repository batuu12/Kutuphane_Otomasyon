using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class Main : Form
    {
        //SQL Bağlantısı için gereken satır
        SqlConnection connection = new SqlConnection("Server='yourServerName';Database='youtDatabaseName';Trusted_Connection=True");
        DataSet ds = new DataSet(); //Dataset oluşturuyoruz.
        DataTable table = new DataTable();
        public Main()
        {
            InitializeComponent();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            connection.Open(); // Bağlantıyı sağladı
            SqlCommand command = new SqlCommand("insert into Kitaplar(KitapId,KitapAdı,KitapYazar,SayfaSayısı) values (@KitapId,@KitapAdı,@KitapYazar,@SayfaSayısı)", connection);
            command.Parameters.AddWithValue("@KitapId", txtKitapId.Text);
            command.Parameters.AddWithValue("@KitapAdı", txtKitapAdı.Text);
            command.Parameters.AddWithValue("@KitapYazar", txtKitapYazarı.Text);
            command.Parameters.AddWithValue("@SayfaSayısı", txtSayfa.Text);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Üye Kaydı Yapıldı");

        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            connection.Open();
            //Select * from Kitaplar = Kitaplar tablosundaki tüm verileri listeler
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Kitaplar", connection); //Aldığım verileri listelemek için kullanılan sınıf.
            adapter.Fill(ds, "Kitaplar");
            //Data grid view'e aldığım verileri doldur.
            dgwKitaplar.DataSource = ds.Tables["Kitaplar"];
            connection.Close();

        }

        private void btnOrderYazar_Click(object sender, EventArgs e)
        {
            connection.Open();
            //Dataları bağlamam için kullanılan class
            BindingSource bs = new BindingSource();
            bs.DataSource = dgwKitaplar.DataSource;

            bs.Filter = "KitapYazar like '%" + txtKitapYazarı.Text + "%'";
            dgwKitaplar.DataSource = bs.DataSource;

            MessageBox.Show("Yazara göre listelendi", "Filtreleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
        }

        private void btnKitapFiltre_Click(object sender, EventArgs e)
        {
            connection.Open();
           
            BindingSource bs = new BindingSource();
            bs.DataSource = dgwKitaplar.DataSource;

            bs.Filter = "KitapAdı like '%" + txtKitapAdı.Text + "%'";
            dgwKitaplar.DataSource = bs.DataSource;
            connection.Close();

            MessageBox.Show("Kitaba göre listelendi","Filtreleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

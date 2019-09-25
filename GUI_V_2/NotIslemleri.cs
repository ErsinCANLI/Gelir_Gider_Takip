using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CNLGELİRGİDERTAKİP
{
    public partial class NotIslemleri : Form
    {
        //VERİTABANI BAĞLANTISI
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=db.accdb; Jet OLEDB:Database Password=zecx2016*;");
        OleDbCommand cmd2 = new OleDbCommand();
        public NotIslemleri()
        {
            InitializeComponent();
        }
        //NOTLAR ÇEKİLDİ
        void NotlariCek()        
        {     
            
            OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT *FROM Notlar", baglanti);
            DataSet ds2 = new DataSet();
            baglanti.Open();
            da2.Fill(ds2, "Notlar");
            NotListesi.DataSource = ds2.Tables["Notlar"];
            baglanti.Close();
            NotListesi.RowHeadersVisible = false;
            NotListesi.Columns[0].Visible = false;
            NotListesi.Columns[2].Visible = false;
            NotListesi.Columns[0].HeaderText = "ID";
            NotListesi.Columns[1].HeaderText = "NOTLARIM";
            NotListesi.Columns[2].HeaderText = "TARİH";
            NotListesi.ClearSelection();
    }

        private void NotIslemleri_Load(object sender, EventArgs e)
        {
            NotlariCek();
        }

        private void NotEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd2.Connection = baglanti;
            cmd2.Parameters.AddWithValue("@c1", NotAciklama.Text);
            cmd2.Parameters.AddWithValue("@c2", NotTarihi.Value.ToString());
            cmd2.CommandText = "INSERT INTO Notlar (Aciklama,Tarih) VALUES (@c1,@c2)";
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Başarılı bir şekilde kaydedildi...");
            baglanti.Close();
            NotlariCek();
        }

        private void NotListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NotId.Text = NotListesi.CurrentRow.Cells[0].Value.ToString();
            NotAciklama.Text = NotListesi.CurrentRow.Cells[1].Value.ToString();
            NotTarihi.Text = NotListesi.CurrentRow.Cells[2].Value.ToString();
        }

        private void NotGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd2.Connection = baglanti;
            cmd2.CommandText = "update Notlar set Aciklama='" + NotAciklama.Text + "',Tarih='" + NotTarihi.Text + "' where NotId=" + NotId.Text + "";
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla güncellendi...");
            baglanti.Close();
            NotlariCek();  
        }

        private void NotSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd2 = new OleDbCommand("DELETE FROM Notlar WHERE NotId=@id", baglanti);
            cmd2.Parameters.AddWithValue("@id", NotId.Text);
            cmd2.ExecuteNonQuery();            
            MessageBox.Show("Kayıt Silindi...");
            NotAciklama.Clear();
            baglanti.Close();
            NotlariCek(); 
        }
    }
}

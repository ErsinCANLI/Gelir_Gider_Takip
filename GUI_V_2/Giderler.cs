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

using CNLGELİRGİDERTAKİP;

namespace GUI_V_2
{
    public partial class Giderler : Form
    {
        //VERİTABANI BAĞLANTISI
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=db.accdb; Jet OLEDB:Database Password=zecx2016*;");
        OleDbCommand cmd = new OleDbCommand();
        public Giderler()
        {
            InitializeComponent();
        }
        void TabloGuncelle()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT *FROM Giderler", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Giderler");
            dataGridView2.DataSource = ds.Tables["Giderler"];
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "AÇIKLAMA";
            dataGridView2.Columns[2].HeaderText = "KATEGORİ";
            dataGridView2.Columns[3].HeaderText = "TUTAR";
            dataGridView2.Columns[4].HeaderText = "TARİH";
            dataGridView2.Columns[5].HeaderText = "ÖDEME TÜRÜ";
            baglanti.Close();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Giderler_Load(object sender, EventArgs e)
        {         
            TabloGuncelle();
            //notlar çekildi
            OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT *FROM Notlar", baglanti);
            DataSet ds2 = new DataSet();
            baglanti.Open();
            da2.Fill(ds2, "Notlar");
            DtNot.DataSource = ds2.Tables["Notlar"];
            baglanti.Close();
            DtNot.RowHeadersVisible = false;
            DtNot.Columns[0].Visible = false;
            DtNot.Columns[2].Visible = false;
            DtNot.Columns[0].HeaderText = "ID";
            DtNot.Columns[1].HeaderText = "NOT";
            DtNot.ClearSelection();
        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            TabloGuncelle();
        }

        private void BtnTarihFiltrele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "SELECT Aciklama,Kategori,Tutar,Tarih,HarcamaTuru FROM Gelirler Where Tarih BETWEEN @tar1 and @tar2";
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@tar1", DtPic1.Value);
            adp.SelectCommand.Parameters.AddWithValue("@tar2", DtPic2.Value);
            adp.Fill(dt);
            baglanti.Close();
            dataGridView2.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.Parameters.AddWithValue("@c1", RtxAciklama.Text);
            cmd.Parameters.AddWithValue("@c2", CmbKategori.Text);
            cmd.Parameters.AddWithValue("@c3", TxtTutar.Text);
            cmd.Parameters.AddWithValue("@c4", DtTarih.Text);
            cmd.Parameters.AddWithValue("@c5", CmbHarcamaTuru.Text);
            cmd.CommandText = "INSERT INTO Gelirler (Aciklama,Kategori,Tutar,Tarih,HarcamaTuru) VALUES (@c1,@c2,@c3,@c4,@c5)";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Başarılı bir şekilde kaydedildi...");
            baglanti.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "update Gelirler set Aciklama='" + RtxAciklama.Text + "',Kategori='" + CmbKategori.Text + "',Tutar='" + TxtTutar.Text + "',Tarih='" + DtTarih.Text + "',HarcamaTuru='" + CmbHarcamaTuru.Text + "' where GelirId=" + LblNo.Text + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla güncellendi...");
            baglanti.Close();
            TabloGuncelle();    
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new OleDbCommand("DELETE FROM Gelirler WHERE GelirId=@id", baglanti);
            cmd.Parameters.AddWithValue("@id", LblNo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi...");
            baglanti.Close();
            TabloGuncelle();    
        }

        private void BtnArama_Click(object sender, EventArgs e)
        {
            if (RbKategori.Checked)
            {
                OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT * FROM Gelirler WHERE Kategori LIKE '" + TxtArama.Text + "%'", baglanti);
                DataSet ds2 = new DataSet();
                baglanti.Open();
                da2.Fill(ds2, "Gelirler");
                dataGridView2.DataSource = ds2.Tables["Gelirler"];
                baglanti.Close();

            }
            else if (RbTutar.Checked)
            {
                OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT * FROM Gelirler WHERE Tutar LIKE '" + TxtArama.Text + "%'", baglanti);
                DataSet ds2 = new DataSet();
                baglanti.Open();
                da2.Fill(ds2, "Gelirler");
                dataGridView2.DataSource = ds2.Tables["Gelirler"];
                baglanti.Close();
            }
            else if (RbHarcama.Checked)
            {
                OleDbDataAdapter da2 = new OleDbDataAdapter("SELECT * FROM Gelirler WHERE HarcamaTuru LIKE '" + TxtArama.Text + "%'", baglanti);
                DataSet ds2 = new DataSet();
                baglanti.Open();
                da2.Fill(ds2, "Gelirler");
                dataGridView2.DataSource = ds2.Tables["Gelirler"];
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("hata");
            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            LblNo.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            RtxAciklama.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            CmbKategori.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            DtTarih.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            CmbHarcamaTuru.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            TxtTutar.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

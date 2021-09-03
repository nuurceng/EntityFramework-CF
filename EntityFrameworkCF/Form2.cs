using EntityFrameworkCF.ContextVeri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MusteriDbContext dbcontext = new MusteriDbContext();
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Uruns.ToList();
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;

            var kt = dbcontext.Kategoris.ToList();
            cbkategoriid.DataSource = kt;
            cbkategoriid.ValueMember = "kategoriid";
            cbkategoriid.DisplayMember = "kategoriadi";

            var mr = dbcontext.Markas.ToList();
            cbmarkaid.DataSource = mr;
            cbmarkaid.ValueMember = "markaid";
            cbmarkaid.DisplayMember = "markaadi";
        }
  
        private void btnekle_Click(object sender, EventArgs e)
        {
            if (tburunadi.Text != "")
            {
                var p = new Urun();
                p.kategoriid = (int)cbkategoriid.SelectedValue;
                p.markaid = (int)cbmarkaid.SelectedValue;
                p.barkodno = tbbarkodno.Text;
                p.urunadi = tburunadi.Text;
                p.miktari =Convert.ToInt32( tbmiktari.Text);
                p.alisfiyati =Convert.ToDecimal( tbalisfiyati.Text);
                p.satisfiyati = Convert.ToDecimal(tbsatisfiyati.Text);
                p.tarih = dateTarih.Value;
                dbcontext.Uruns.Add(p);
                dbcontext.SaveChanges();
                MessageBox.Show("Ürün eklendi...", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = dbcontext.Uruns.ToList();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if(tburunid.Text != "")
            {
                int id = int.Parse(tburunid.Text);
                var p = dbcontext.Uruns.FirstOrDefault(x => x.urunid == id);
                p.kategoriid = (int)cbkategoriid.SelectedValue;
                p.markaid = (int)cbmarkaid.SelectedValue;
                p.barkodno = tbbarkodno.Text;
                p.urunadi = tburunadi.Text;
                p.miktari = Convert.ToInt32(tbmiktari.Text);
                p.alisfiyati = Convert.ToDecimal(tbalisfiyati.Text);
                p.satisfiyati = Convert.ToDecimal(tbsatisfiyati.Text);
                p.tarih = dateTarih.Value;
                dbcontext.SaveChanges();
                MessageBox.Show("Ürün güncellendi...", "Güncel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = dbcontext.Uruns.ToList();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (tburunid.Text != "")
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var p = dbcontext.Uruns.FirstOrDefault(x => x.urunid == id);
                dbcontext.Uruns.Remove(p);
                dbcontext.SaveChanges();
                MessageBox.Show("Ürün silindi...", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = dbcontext.Uruns.ToList();

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tburunid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbkategoriid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbmarkaid.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbbarkodno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tburunadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbmiktari.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbalisfiyati.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbsatisfiyati.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTarih.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}

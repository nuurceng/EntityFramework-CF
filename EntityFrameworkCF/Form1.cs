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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MusteriDbContext dbcontext = new MusteriDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            var kt = dbcontext.Kategoris.ToList();
            cbkategoriid.DataSource = kt;
            cbkategoriid.ValueMember = "kategoriid";
            cbkategoriid.DisplayMember = "kategoriadi";
        }
        void temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                dateTarih.Value = DateTime.Now;
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (tbadisoyadi.Text != "" & tbtel.Text != "" & tbsehir.Text != "" )
            {
                var tbl = new Musteri();
                tbl.adisoyadi = tbadisoyadi.Text;
                tbl.telefon = tbtel.Text;
                tbl.sehir = tbsehir.Text;
                tbl.email = tbemail.Text;
                tbl.tarih = dateTarih.Value;
                dbcontext.Musteris.Add(tbl);
                dbcontext.SaveChanges();
                MessageBox.Show("Müşteri eklendi...", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                dataGridView1.DataSource = dbcontext.Musteris.ToList();
            }
            if(tbkategoriadi.Text!="")
            {
                var k = new Kategori();
                k.kategoriadi = tbkategoriadi.Text;
                dbcontext.Kategoris.Add(k);
                dbcontext.SaveChanges();
                MessageBox.Show("Kategori eklendi...", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                dataGridView1.DataSource = dbcontext.Kategoris.ToList();
            }
            if(tbmarkaadi.Text!="")
            {
                var m = new Marka();
                m.markaadi = tbmarkaadi.Text;
                m.kategoriid = (int)cbkategoriid.SelectedValue;
                dbcontext.Markas.Add(m);
                dbcontext.SaveChanges();
                MessageBox.Show("Marka eklendi...", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = dbcontext.Markas.ToList();

            }
            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if(tbmusteriid.Text!="")
            {
                int id = int.Parse(tbmusteriid.Text);
                var tbl = dbcontext.Musteris.FirstOrDefault(x => x.musteriid == id);
                tbl.adisoyadi = tbadisoyadi.Text;
                tbl.telefon = tbtel.Text;
                tbl.sehir = tbsehir.Text;
                tbl.email = tbemail.Text;
                tbl.tarih = dateTarih.Value;
                dbcontext.SaveChanges();
                MessageBox.Show("Müşteri güncellendi...", "Güncel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                dataGridView1.DataSource = dbcontext.Musteris.ToList();
            }
            if(tbkategoriid.Text!="")
            {
                int id = int.Parse(tbkategoriid.Text);
                var k = dbcontext.Kategoris.FirstOrDefault(x => x.kategoriid == id);
                k.kategoriadi = tbkategoriadi.Text;
                dbcontext.SaveChanges();
                MessageBox.Show("Kategori güncellendi...", "Güncel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                dataGridView1.DataSource = dbcontext.Kategoris.ToList();
            }
            if(tbmarkaid.Text!="")
            {
                int id = int.Parse(tbmarkaid.Text);
                var m = dbcontext.Markas.FirstOrDefault(x => x.markaid == id);
                m.markaadi = tbmarkaadi.Text;
                m.kategoriid = (int)cbkategoriid.SelectedValue;
                dbcontext.SaveChanges();
                MessageBox.Show("Marka güncellendi...", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = dbcontext.Markas.ToList();
            }
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if(tbmusteriid.Text!="")
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var tbl = dbcontext.Musteris.FirstOrDefault(x => x.musteriid == id);
                dbcontext.Musteris.Remove(tbl);
                dbcontext.SaveChanges();
                MessageBox.Show("Müşteri silindi...", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                dataGridView1.DataSource = dbcontext.Musteris.ToList();
            }
            if(tbkategoriid.Text!="")
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var kt = dbcontext.Kategoris.FirstOrDefault(x => x.kategoriid == id);
                dbcontext.Kategoris.Remove(kt);
                dbcontext.SaveChanges();
                MessageBox.Show("Kategori silindi...", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                dataGridView1.DataSource = dbcontext.Kategoris.ToList();
            }
            if(tbmarkaid.Text!="")
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var mr = dbcontext.Markas.FirstOrDefault(x => x.markaid == id);
                dbcontext.Markas.Remove(mr);
                dbcontext.SaveChanges();
                MessageBox.Show("Marka silindi...", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = dbcontext.Markas.ToList();
            }
            
        }

        private void tbara_TextChanged(object sender, EventArgs e)
        {
            var ara = from x in dbcontext.Musteris select x;
            if (tbara.Text != null)
            {
                dataGridView1.DataSource = ara.Where(x => x.adisoyadi.Contains(tbara.Text)).ToList();
            }
        }

        private void btnurun_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Show();
        }

        private void btnsepet_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Show();
        }

        private void btnmusterilist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Musteris.ToList();
        }

        private void btnurunlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Uruns.ToList();
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        private void btnmarkalist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Markas.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnkategorilist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Kategoris.ToList();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void btnsepetlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Sepets.ToList();
            dataGridView1.Columns[10].Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbmusteriid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbadisoyadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbtel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbsehir.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTarih.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}

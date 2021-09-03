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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        MusteriDbContext dbcontext = new MusteriDbContext();
        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Uruns.ToList();
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            //var sp = dbcontext.Uruns.ToList();
            //cburunid.DataSource = sp;
            //cburunid.DisplayMember = "urunid";
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            if (tburunadi.Text != "")
            {
                var p = new Sepet();
                p.urunid = Convert.ToInt32(tburunid.Text);
                p.kategoriid =Convert.ToInt32( tbkategoriid.Text);
                p.markaid = Convert.ToInt32(tbmarkaid.Text);
                p.barkodno = tbbarkodno.Text;
                p.urunadi = tburunadi.Text;
                p.miktari = Convert.ToInt32(tbmiktari.Text);
                p.birimfiyati = Convert.ToDecimal(tbbirimfiyati.Text);
                p.toplamfiyati = Convert.ToDecimal(tbtoplamfiyati.Text);
                p.tarih = dateTarih.Value;
                dbcontext.Sepets.Add(p);
                dbcontext.SaveChanges();
                MessageBox.Show("Sepet eklendi...", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = dbcontext.Sepets.ToList();
            }

        }

 

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (tbsepetid.Text != "")
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var p = dbcontext.Sepets.FirstOrDefault(x => x.sepetid == id);
                dbcontext.Sepets.Remove(p);
                dbcontext.SaveChanges();
                MessageBox.Show("Sepet silindi...", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = dbcontext.Sepets.ToList();

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tburunid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbkategoriid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbmarkaid.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbbarkodno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tburunadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbmiktari.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbbirimfiyati.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbtoplamfiyati.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTarih.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnurunlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Uruns.ToList();
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        private void btnsepetlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Sepets.ToList();
            dataGridView1.Columns[10].Visible = false;
        }
    }
}

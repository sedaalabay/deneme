using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kar_Zarar_Takip_Sistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sirketkodu = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Şirket Kodunu Giriniz", "ŞİRKET BİLGİSİ GİRİŞİ", "", 100, 100));
            Form3 ac = new Form3();
            ac.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            { 
                using(KarzararDataContext db = new KarzararDataContext()){
                    var sirketler = (from s in db.Sirkets select new {s.isim}); 
                    dgvSirketler.DataSource = sirketler;
                 } 
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.ToString());
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void şirketBilgisiDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ac = new Form5();
            ac.Show();
        }

        private void gelirGiderKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ac = new Form4();
            ac.Show();
        }

        private void gelirGiderTakibiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 ac = new Form6();
            ac.Show();
        }

        private void yıllıkAnalizToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dgvSirketler_DoubleClick(object sender, EventArgs e)
        {
            string sirketAdi = dgvSirketler.SelectedCells[0].Value.ToString();

            try
            {
                using (KarzararDataContext db = new KarzararDataContext())
                {
                    var sirketInfo = (from s in db.Sirkets where s.isim == sirketAdi select s).FirstOrDefault();

                    lblSirketAdi.Text = sirketInfo.isim;
                    lblSirketKodu.Text = sirketInfo.sirket_kodu.ToString();
                    lblTelNo.Text = sirketInfo.telefon;
                    lblFaxNo.Text = sirketInfo.fax;
                    lblEposta.Text = sirketInfo.eposta;
                    lblYetkiliKisi.Text = sirketInfo.yetkili_kisi;

                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.ToString());
            }
            


        }

        private void dgvSirketler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void lblSirketKodu_Click(object sender, EventArgs e)
        {

        }

        private void iŞLEMLERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

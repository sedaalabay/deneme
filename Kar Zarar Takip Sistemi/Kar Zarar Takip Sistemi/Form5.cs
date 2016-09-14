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
    public partial class Form5 : Form
    {
        KarzararDataContext db = new KarzararDataContext();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                using (KarzararDataContext db = new KarzararDataContext())
                {
                    var sirketler = (from s in db.Sirkets select new { s.isim });
                    dgvduzen.DataSource = sirketler;
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.ToString());
            }
        }

        private void dgvduzen_doubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sirketAdi = dgvduzen.SelectedCells[0].Value.ToString();

            try
            {
                using (KarzararDataContext db = new KarzararDataContext())
                {
                    var sirketInfo = (from s in db.Sirkets where s.isim == sirketAdi select s).FirstOrDefault();

                    txtduzen1.Text = sirketInfo.isim;
                    txtduzen2.Text = sirketInfo.sirket_kodu.ToString();
                    txtduzen3.Text = sirketInfo.telefon;
                    txtduzen4.Text = sirketInfo.fax;
                    txtduzen5.Text = sirketInfo.eposta;
                    txtduzen6.Text = sirketInfo.yetkili_kisi;

                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var query =
    from ord in db.Sirkets
    where ord.sirket_kodu == Convert.ToInt32(txtduzen2.Text)
    select ord;

            foreach (Sirket ord in query)
            {
                ord.isim = txtduzen1.Text;
                ord.telefon = txtduzen3.Text;
                ord.fax = txtduzen4.Text;
                ord.eposta = txtduzen4.Text;
                ord.yetkili_kisi = txtduzen6.Text;
                
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
               
            }
            MessageBox.Show("Düzenleme gerçekleştirildi!");
            txtduzen1.Text = "";
            txtduzen2.Text = "";
            txtduzen3.Text = "";
            txtduzen4.Text = "";
            txtduzen5.Text = "";
            txtduzen6.Text = "";
            }

        private void button2_Click(object sender, EventArgs e)
        {
            var query =
               from ord in db.Sirkets
               where ord.sirket_kodu == Convert.ToInt32(txtduzen2.Text)
               select ord;

            foreach (var detail in query)
            {
                db.Sirkets.DeleteOnSubmit(detail);
            }

            try
            {
                db.SubmitChanges();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                
            }
            MessageBox.Show("Kayıt Silindi!");
            txtduzen1.Text = "";
            txtduzen2.Text = "";
            txtduzen3.Text = "";
            txtduzen4.Text = "";
            txtduzen5.Text = "";
            txtduzen6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }
    }


    

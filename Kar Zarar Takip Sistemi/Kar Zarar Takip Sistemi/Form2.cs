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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSirketKaydet_Click(object sender, EventArgs e)
        {
            string sirketAdi = txtSirketAdi.Text;
            int sirketKodu = (string.IsNullOrEmpty(txtSirketKodu.Text) ? 0 : Convert.ToInt32(txtSirketKodu.Text));
            string telNo = txtTelNo.Text;
            string faxNo = txtFaxNo.Text;
            string eposta = txtEposta.Text;
            string yetkiliKisi = txtYetkiliKisi.Text;

            if (string.IsNullOrEmpty(sirketAdi) ||
                sirketKodu == 0 ||
                string.IsNullOrEmpty(telNo) ||
                string.IsNullOrEmpty(yetkiliKisi))
            {
                MessageBox.Show("Zorunlu Alanları Doldurunuz!");
            }
            else
            {

                try
                {
                    using (KarzararDataContext db = new KarzararDataContext())
                    {
                        Sirket kayit = new Sirket
                        {
                            isim = sirketAdi,
                            sirket_kodu = sirketKodu,
                            telefon = telNo,
                            fax = faxNo,
                            eposta = eposta,
                            yetkili_kisi = yetkiliKisi
                        };

                        db.Sirkets.InsertOnSubmit(kayit);
                        db.SubmitChanges();
                    }
                    MessageBox.Show("Kayıt başarı ile eklendi!");
                    txtEposta.Text = "";
                    txtFaxNo.Text = "";
                    txtSirketAdi.Text = "";
                    txtSirketKodu.Text = "";
                    txtTelNo.Text = "";
                    txtYetkiliKisi.Text = "";
                }
                catch (Exception exp)
                {

                    MessageBox.Show(exp.ToString());
                }


            }
            

        }

        private void txtSirketAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form8 : Form
    {
        KarzararDataContext db = new KarzararDataContext();
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            var abc = db.GelirGiders.Select(x => x.Sirket.isim).Distinct().ToList();

            foreach (var item in abc)
            {
                listBox1.Items.Add(item);
            }

            try
            {
               
                    var sirketler = (from s in db.Sirkets select new { s.isim });
                    dgvanaliz.DataSource = sirketler;
                  
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.ToString());
            }
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
       
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvanaliz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

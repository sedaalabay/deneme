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
    
    public partial class Form4 : Form
    {
        KarzararDataContext db = new KarzararDataContext();
        public Form4()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int a = Convert.ToInt32(comboBox1.SelectedValue);
         
            try
            {
                var abc = db.GelirGiders.Where(x => x.sirket_ID == a).Select(x=>new{x.gelir , x.gider , x.tarih});
                dgvgelirgider.DataSource = abc;
               
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.ToString());
            }
           



        }

        private void Form4_Load(object sender, EventArgs e)
        {

            this.sirketTableAdapter.Fill(this.kar_zararDataSet.Sirket);
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnonayla_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(comboBox1.SelectedValue);
            var abc = db.GelirGiders.Where(x => x.sirket_ID == a).FirstOrDefault();
            GelirGider ekle = new GelirGider
            {
                sirket_ID=a,
                gelir = Convert.ToDecimal(txtgelir.Text),
                gider = Convert.ToDecimal(txtgider.Text),
                tarih = dTpdate.Value.Date,

            };

            db.GelirGiders.InsertOnSubmit(ekle);
            db.SubmitChanges();


            var bb = db.GelirGiders.Where(x => x.sirket_ID == a).Select(x => new { x.gelir, x.gider, x.tarih });
            dgvgelirgider.DataSource = bb;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

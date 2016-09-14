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
    public partial class Form6 : Form
    {
        KarzararDataContext db = new KarzararDataContext();
        public Form6()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(comboBox1.SelectedValue);

            try
            {
                var abc = db.GelirGiders.Where(x => x.sirket_ID == a).Select(x => new { x.gelir, x.gider, x.tarih });
                dataGridView1.DataSource = abc;

            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.ToString());
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
            this.sirketTableAdapter.Fill(this.kar_zararDataSet.Sirket);
            
            
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

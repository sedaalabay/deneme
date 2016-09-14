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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ac = new Form2();
            ac.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ac = new Form3();
            ac.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 ac = new Form8();
            ac.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }
    }
}

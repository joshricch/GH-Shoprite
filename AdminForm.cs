using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GH_Shoprite
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MUsers mu = new MUsers();
            mu.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MProducts mu = new MProducts();
            mu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MCategories mu = new MCategories();
            mu.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }
    }
}

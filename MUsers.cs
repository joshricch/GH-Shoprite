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
    public partial class MUsers : Form
    {
        public MUsers()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm sf = new AdminForm();
            sf.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_1
{
    public partial class frmSumma : Form
    {
        public frmSumma()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int summa = Int32.Parse(txtA.Text) + 
            Int32.Parse(txtB.Text) + Int32.Parse(txtC.Text);
            txtSumma.Text = summa.ToString();
        }

        private void txtA_Click(object sender, EventArgs e)
        {
            txtA.Clear();
        }

        private void txtB_Click(object sender, EventArgs e)
        {
            txtB.Clear();
        }

        private void txtC_Click(object sender, EventArgs e)
        {
            txtC.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_1_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = Int32.Parse(txtA.Text) - Int32.Parse(txtB.Text) * (Int32.Parse(txtC.Text) + Int32.Parse(txtD.Text)); Rasstoyanie.Text = sum.ToString();
        }
    }
}

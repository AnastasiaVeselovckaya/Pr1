using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_1_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedItem == "черный")
            {
                txt.BackColor = System.Drawing.Color.Black;
            }
            else if (lst.SelectedItem == "красный")
            {
                txt.BackColor = System.Drawing.Color.Red;
            }
            else if (lst.SelectedItem == "синий")
            {
                txt.BackColor = System.Drawing.Color.Blue;
            }
            else if (lst.SelectedItem == "зеленый")
            {
                txt.BackColor = System.Drawing.Color.Green;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lst_Click_1(object sender, EventArgs e)
        {

        }
    }
}

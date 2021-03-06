using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgyptionCurrancy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEgypt_TextChanged(object sender, EventArgs e)
        {
            float LE = float.Parse(txtEgypt.Text);
            txtdollar.Text = (LE / 16.25).ToString();
            txteuro.Text = (LE / 9.8).ToString();
            txtsar.Text = (LE / 2.14).ToString();

        }
    }
}

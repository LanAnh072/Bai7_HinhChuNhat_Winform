using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7_HinhChuNhat_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            double cd = Convert.ToDouble(txtCD.Text);
            double cr = Convert.ToDouble(txtCR.Text);
            double p = (cd + cr) * 2;
            txtKQ.Text = p.ToString();
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            double cd = Convert.ToDouble(txtCD.Text);
            double cr = Convert.ToDouble(txtCR.Text);
            double s = cd * cr;
            txtKQ.Text = s.ToString();
        }
    }
}

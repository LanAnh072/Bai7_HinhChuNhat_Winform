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

private void btnTinh_Click(object sender, EventArgs e)
        {
            double cd = double.Parse(txtCD.Text);
            double cr = double.Parse(txtCR.Text);
            lblKQ.Text = "- Diện tích: " + TinhDT(cd, cr) + "\n- Chu vi: " + TinhCV(cd, cr);
        }
        double TinhDT (double cd, double cr) { return cd * cr; }
        double TinhCV (double cd, double cr) { return  (cd + cr)*2; }
    }
}

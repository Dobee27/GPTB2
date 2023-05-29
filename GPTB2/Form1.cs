using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GPTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, c, denta;

        private void btnXoa_Click(object sender, EventArgs e)
        {
            richTextBoxketqua.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
            }
            catch
            {
                MessageBox.Show("bạn nhập sai kiểu dữ liệu", "thông báo", MessageBoxButtons.OK);
            }
            denta = (b * b) - (4 * b * c);
            if (denta < 0)
            {
                richTextBoxketqua.Text = "phương trình vô nghiệm";
            }
            else if (denta == 0)
            {
                richTextBoxketqua.Text = "phương trình có nghiệm kép X1=X2=" + (-b / 2 / a);
            }
            else
            {
                richTextBoxketqua.Text = "phương trình có 2 nghiệm \nX1=" + ((-b + Math.Sqrt(denta)) / 2 / a) + "\nX2=" + ((-b - Math.Sqrt(denta)) / 2 / a);
            }
        }
    }
}

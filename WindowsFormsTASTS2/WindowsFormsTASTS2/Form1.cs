using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTASTS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tboxNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                short sNimber = short.Parse(tboxNumber.Text);

                lblShort.Text = sNimber.ToString();
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnlnt_Click(object sender, EventArgs e)
        {
            try
            {
                int sNimber = int.Parse(tboxNumber.Text);

                lblInt.Text = sNimber.ToString();
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double sNimber = double.Parse(tboxNumber.Text);

                lblDouble.Text = sNimber.ToString();
                lblException.Text = "-_-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            short sNumber = 0;
            int lNumber = 0;
            double dNumber = 0;

            if (short.TryParse(tboxNumber.Text, out sNumber))
            {
                lblShort.Text = sNumber.ToString();
            }
            else if (int.TryParse(tboxNumber.Text, out lNumber))
            {
                lblInt.Text = lNumber.ToString();
            }
            else if (double.TryParse(tboxNumber.Text, out dNumber))
            {
                lblDouble.Text = dNumber.ToString();
            }
            else
            {
                lblException.Text = "변환 할수 없음";
            }
        }
    }
}

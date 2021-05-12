using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpStudy2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sample,Test,Text
            string strText = lblText.Text;

            lblContain.Text = strText.Contains("Text").ToString();
            lblEquals.Text = strText.Equals("Test").ToString();
            lblLength.Text = strText.Length.ToString();
            lblReplace.Text = strText.Replace("Test", "l can").ToString();

            string[] strSplit = strText.Split(',');
            lblSplit.Text = strSplit[0].ToString();  //"Sample"
            lblSplit2.Text = strSplit[1].ToString(); //"Test"
            lblSplit3.Text = strSplit[2].ToString(); //"Text"

            lblSubstring.Text = strText.Substring(3, 5).ToString();
            lblTolower.Text = strText.ToLower().ToString();
            lblToUpper.Text = strText.ToUpper().ToString();
            lblTrim.Text = strText.Trim().ToString();
        }
    }
}

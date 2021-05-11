using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCall_Click(object sender, EventArgs e)
        {
            InputBookInfo inputBookInfo = new InputBookInfo();
            inputBookInfo.Show();
        }
    }
}

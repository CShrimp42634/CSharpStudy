using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            // int iResult = iNumA + iNumB;
            //tboxResult.Text = iResult.ToString();

            tboxResult.Text = fPlus(iNumA, iNumB).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            //int iResult = iNumA - iNumB;

            //tboxResult.Text = iResult.ToString();

            tboxResult.Text = fMinus(iNumA, iNumB).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            // int iResult = iNumA * iNumB;
            //tboxResult.Text = iResult.ToString();

            tboxResult.Text = fMulti(iNumA, iNumB).ToString();
        }

        private void btnDiMision_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            //int iResult = iNumA / iNumB; //몫
            //int iResult  = iNumA % iNumB; // 나머지
            //tboxResult.Text = iResult.ToString();

            tboxResult.Text = fDivision(iNumA, iNumB).ToString();
        }




        private int fPlus(int iA, int iB)
        {
            int iResut = 0;

            iResut = iA + iB;

            return iResut;
        }
        private int fMinus(int iA, int iB)
        {
            int iResut = 0;

            iResut = iA - iB;

            return iResut;
        }
        private int fMulti(int iA, int iB)
        {
            int iResut = 0;

            iResut = iA * iB;

            return iResut;
        }
        private int fDivision(int iA, int iB)
        {
            int iResut = 0;

            iResut = iA / iB;
            iResut = iA % iB;

            return iResut;
        }
    }
}

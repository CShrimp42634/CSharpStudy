using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.while_do_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwhileResult_Click(object sender, EventArgs e)
        {
            // 1~45 6개의 번호
            //List<int> iList = new List <int>();

            int[] iArray = new int[6];
            int iCount = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            while (Array.IndexOf(iArray , 0) != -1)
            {
                int iNumber = rd.Next(1, 46);

                if (Array.IndexOf(iArray, iNumber) == -1)
                {
                    iArray[iCount] = iNumber;
                    sb.Append(string.Format("{0}.", iNumber));
                    iCount++;
                }
            }

            lblwhileResult.Text = sb.ToString();
            lboxwhileResult.Items.Add(sb.ToString());
        }

        private void btndowhileResult_Click(object sender, EventArgs e)
        {
            //1~100

            Random rd = new Random();

            int iNumber = int.Parse(tboxNumber.Text);

            if (iNumber < 1 || iNumber > 100)
            {
                MessageBox.Show("1~100 사이의 숫자를 지정해 주세요");
            }

            int iCheckNumber = 0;
            int iCount = 0;

            do
            {
                iCheckNumber = rd.Next(1, 101); // 1<= x < 101
                iCount++;
            } while (iNumber != iCheckNumber);

            lbldowhileResult.Text = string.Format("-뽑은 숫자 {0}을 {1}회만에 찾았습니다.", iNumber, iCount);

        }
    }
}

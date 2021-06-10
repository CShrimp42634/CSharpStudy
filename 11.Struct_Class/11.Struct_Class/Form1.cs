using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.Struct_Class
{
    public partial class Form1 : Form
    {
        struct structPlayer
        {
            public int iCount; //Player가 몇회 진행 중인지

            public int iSun; // 하늘 색에 대한 값
            public int iMoon; // 검은 색에 대한 값
            public int iStar; // 살 색에 대한 값

            public int iCardSum; //  하늘 ,검은 ,살색 을 더한 값

            public int CardSun(int iSun, int iMoon, int iStar)
            {
                return iSun + iMoon + iStar;
            }

            public string ResultText()
            {
                return string.Format("{0}회) 하늘:{1}, 검은:{2} , 살색 :{3} => 합계는 {4} 입니다.", iCount ,iSun, iMoon, iStar, iCardSum);
            }
        }
        structPlayer _stPlayer1; //1번
        structPlayer _stPlayer2;// 2번

        Random _rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void pboxSun_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iSun = iNumber;
            }
            else
            {
                _stPlayer2.iSun = iNumber;
            }
            Result();

        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iMoon = iNumber;
            }
            else
            {
                _stPlayer2.iMoon = iNumber;
            }
            Result();

        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iStar = iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }

            Result();

        }

        private void pboxNone_Click(object sender, EventArgs e)
        {
            // 아무짓도 안하고 한턴을 넘긴다

            Result();

            
        }

        private void iCheckedChange()
        {
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }

        private void Result()
        {
            string strResult = string.Empty;

            int iCardSum = 0;

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iCount++;

                _stPlayer1.iCardSum = _stPlayer1.CardSun(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);


                strResult = _stPlayer1.ResultText();

                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;

                _stPlayer2.iCardSum = _stPlayer2.CardSun(_stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar);


                strResult = _stPlayer1.ResultText();

                lboxResult2.Items.Add(strResult);
            }

            iCheckedChange();

            if (_stPlayer1.iCount >= 5 && _stPlayer2.iCardSum  >= 5)
            {
                if (_stPlayer1.iCardSum > _stPlayer2.iCardSum)
                {
                    MessageBox.Show("plater1이 이겼습니다.");
                }
                else if (_stPlayer1.iCount < _stPlayer2.iCardSum)
                {
                    MessageBox.Show("plater2가 이겼습니다.");
                }
                else
                {
                    MessageBox.Show("비겼습니다.");
                }
            }
        }
    }
}

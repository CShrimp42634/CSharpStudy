using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_part
{
    public partial class Form1 : Form
    {
        cData _Data = new cData();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Enumltem[] ei = (Enumltem[])Enum.GetValues(typeof(Enumltem));

            foreach (Enumltem oitem in ei)
            {
                cboxltem.Items.Add(oitem.ToString());
            }


            foreach (EnumRate oitem in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                cboxRate.Items.Add(oitem.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboxltem.Text != null)
            {
                _Data.strltem = cboxltem.Text;
            }
            
            _Data.iRate = int.Parse(cboxRate.Text);
            _Data.iCount = (int)numCout.Value;
        }
    }
}

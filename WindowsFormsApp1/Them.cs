using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Them : Form
    {
        public Them()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = 1;
            string[] text = {tbE.Text, tbHT.Text, tbK.Text, tbMSSV.Text, tbNS.Text, tbSDT.Text};
            for (int i = 0; i < 6; i++)
            {
                if (text[i] == "")
                {
                    check = -1;
                    break;
                }
            }
            if (check == -1) {
                TB tb = new TB();   
                tb.ShowDialog();
            }
            else
            {
                TC tC = new TC();
                tC.ShowDialog();
            }
        }
    }
}

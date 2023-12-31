﻿using System;
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
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
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
            if (check == -1)
            {
                TB tB = new TB();
                tB.ShowDialog();
            }
            else
            {
                string gioitinh = rbNam.Checked ? "Nam" : "Nữ";
                dgvSinhVien.Rows.Add(tbHT.Text, tbMSSV.Text, gioitinh, NgaySinh.Text, tbNS.Text, tbK.Text, tbSDT.Text, tbE.Text);
                if (tbSDT.Text[0] != '0')
                {
                    TC tc = new TC();
                    label1.Text = "Số điện thoại phải bắt đầu bằng số 0";
                    tc.ShowDialog();
                }
                else
                {
                    TC tc = new TC();
                    tc.ShowDialog();
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvSinhVien.Rows.Clear();   
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK )
            {
                pictureBox1.ImageLocation = dlg.FileName;
            }
        }
    }
}

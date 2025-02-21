﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INEW2330_FineDining
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inew2330su21DataSet.Merchandise' table. You can move, or remove it, as needed.
            this.merchandiseTableAdapter.Fill(this.inew2330su21DataSet.Merchandise);
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.merchandiseTableAdapter.FillBy(this.inew2330su21DataSet.Merchandise);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

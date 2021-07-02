using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            lblExit.Parent = pictureBox1;
            lblMenu.Parent = pictureBox1;
            lblOrder.Parent = pictureBox1;
            lblAbout.Parent = pictureBox1;
            lblLogin.Parent = pictureBox1;
            ProgOps.OpenDatabase();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ProgOps.CloseDatabase();
            Application.Exit();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void lblOrder_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmEmployee order = new frmEmployee();
            order.ShowDialog();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

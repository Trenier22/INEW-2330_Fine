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
    public partial class frmLoginButtons : Form
    {
        public frmLoginButtons()
        {
            InitializeComponent();
        }

        private void frmLoginButtons_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee empLogin = new frmEmployee();
            empLogin.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrder order = new frmOrder();
            order.ShowDialog();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManLogin manLogin = new frmManLogin();
            manLogin.ShowDialog();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustLogin cust = new frmCustLogin();
            cust.ShowDialog();
        }
    }
}

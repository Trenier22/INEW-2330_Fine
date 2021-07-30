using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INEW2330_FineDining
{
    public partial class frmCustRegister : Form
    {
        public frmCustRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ProgOps.DatabaseSQLCommand("INSERT INTO group2su212330.Customer(CustFirstName, CustLastName, CustEmail, CustPhone, CustAddress, CustCreditCard, CustLoginUserName, CustLoginPassword)" +
                    " VALUES('" + tbxFirstName.Text + "', '" + tbxLastName.Text + "', '" + tbxEmail.Text + "', " + tbxPhone.Text + ", '" + tbxAddress.Text + "', " + tbxCreditCard.Text + ", '" + tbxUsername.Text + "', '" + tbxPassword.Text + "');");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCustRegister_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            label8.Parent = pictureBox1;
            label9.Parent = pictureBox1;
            label10.Parent = pictureBox1;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

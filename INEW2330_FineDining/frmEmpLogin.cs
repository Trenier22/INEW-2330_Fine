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
    public partial class frmEmpLogin : Form
    {
        

        public frmEmpLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmForgotPassword forgotPassword = new frmForgotPassword();
            forgotPassword.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Close button/menu has been clicked or Alt+F4, ...
                ProgOps.CloseDatabase();
            }
            else
            {
                // other cases
                ProgOps.CloseDatabase();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            String empUsername;
            String empPassword;
            empUsername = tbxUsername.Text;
            empPassword = tbxPassword.Text;

            SqlConnection _cntDatabase = new SqlConnection("Server=cstnt.tstc.edu;Database= inew2330su21;" +
                "User Id=group2su212330;password=2547258");

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM group2su212330.Employees WHERE EmpLoginUsername = '" + empUsername
                + "' AND EmpLoginPassword = '" + empPassword + "'", _cntDatabase);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmForgotPassword forgotPassword = new frmForgotPassword();
            forgotPassword.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        public string MyValue
        {
            get { return tbxUsername.Text; }
        }
        

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

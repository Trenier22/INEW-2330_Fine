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
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text == tbxRePassword.Text)
            {
                SqlConnection _cntDatabase = new SqlConnection("Server=cstnt.tstc.edu;Database= inew2330su21;" +
                   "User Id=group2su212330;password=2547258");

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM group2su212330.Employees WHERE EmpLoginUsername = '" + tbxUsername.Text + "'", _cntDatabase);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    ProgOps.DatabaseSQLCommand("UPDATE group2su212330.Employees SET EmpLoginPassword = '" + tbxPassword.Text + "' WHERE EmpLoginUsername = '" + tbxUsername.Text + "'");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username");
                }
            }
            else
            {
                MessageBox.Show("Password feilds do not match.");
            }
        }
    }
}

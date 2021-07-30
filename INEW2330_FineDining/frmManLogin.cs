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
    public partial class frmManLogin : Form
    {
        public frmManLogin()
        {
            InitializeComponent();
        }

        private void frmManLogin_Load(object sender, EventArgs e)
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String manUsername;
            String manPassword;
            manUsername = tbxUsername.Text;
            manPassword = tbxPassword.Text;

            SqlConnection _cntDatabase = new SqlConnection("Server=cstnt.tstc.edu;Database= inew2330su21;" +
                "User Id=group2su212330;password=2547258");

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM group2su212330.Manager WHERE ManLoginUsername = '" + manUsername
                + "' AND ManLoginPassword = '" + manPassword + "'", _cntDatabase);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                frmManager man = new frmManager();
                man.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

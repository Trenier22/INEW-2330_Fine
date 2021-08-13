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
    
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;

            if (ProgOps.Counter == 0)
            {
                ProgOps.OpenDatabase();
            }
            ProgOps.Counter++;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ProgOps.CustLoginCommand(tbxUsername, tbxPassword);
            ProgOps.EmpLoginCommand(tbxUsername, tbxPassword);

            if(ProgOps._dtCustomersTable.Rows.Count == 1)
            {
                frmMain cust = new frmMain();
                //this.Hide();
                cust.Show();
            }
            else if (ProgOps._dtEmployeesTable.Rows.Count == 1)
            {
                this.Hide();
            }
            else if (tbxUsername.Text == "kathywilganowski" && tbxPassword.Text == "12345")
            {
                frmManager man = new frmManager();
                //this.Hide();
                man.Show();
            }
            else
            {
                MessageBox.Show("Error with username and password.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ProgOps.CloseDatabase();
            Application.Exit();
        }

        public string MyValue
        {
            get { return tbxUsername.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmForgotPassword reset = new frmForgotPassword();
            reset.Show();
        }
    }
}

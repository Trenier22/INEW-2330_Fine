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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ProgOps.CustLoginCommand(tbxUsername, tbxPassword);
            ProgOps.EmpLoginCommand(tbxUsername, tbxPassword);

            if(ProgOps._dtCustomersTable.Rows.Count == 1)
            {
                frmMain cust = new frmMain();
                this.Hide();
                cust.Show();
            }
            else if (ProgOps._dtEmployeesTable.Rows.Count == 1)
            {
                frmEmployee emp = new frmEmployee();
                this.Hide();
                emp.Show();
            }
            else if (tbxUsername.Text == "kathywilganowski" && tbxPassword.Text == "12345")
            {
                frmManager man = new frmManager();
                this.Hide();
                man.Show();
            }
            else
            {
                MessageBox.Show("Error with username and password.");
            }
        }
    }
}

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
    public partial class frmEmployee : Form
    {

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            var frmlogin = new frmLogin();
            frmlogin.ShowDialog(this);
            ProgOps.DatabaseCommand(dgvEmp, "SELECT EmpID, EmpFirstName, EmpLastName, EmpHoursWorked, CAST(EmpHourlyPay AS NUMERIC(15, 2)) AS EmpHourlyPay," +
                " CAST((EmpHoursWorked * EmpHourlyPay) AS NUMERIC(15, 2))AS EmpNetPay, CAST(((EmpFderalTax * (EmpHoursWorked * EmpHourlyPay)) - " +
                "(EmpHoursWorked * EmpHourlyPay))AS NUMERIC(15, 2)) AS EmpFederal, CAST(EmpSocialSecurityTax AS NUMERIC(15, 2)) AS EmpSocialSecurityTax, CAST(EmpMedicareTax AS NUMERIC(15, 2)) AS EmpMedicareTax, CAST(((EmpHoursWorked * EmpHourlyPay) - " +
                "((EmpFderalTax * (EmpHoursWorked * EmpHourlyPay)) - (EmpHoursWorked * EmpHourlyPay))) AS NUMERIC(15, 2)) AS EmpTotalPay FROM group2su212330.Employees" +
                " WHERE EmpLoginUsername = '" + frmlogin.MyValue +  "'");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }
    }
}

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
            // TODO: This line of code loads data into the 'inew2330su21DataSet3.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this.inew2330su21DataSet3.Employees);
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            ProgOps.DatabaseCommand(dgvEmp, "SELECT EmpID, EmpFirstName, EmpLastName, EmpHoursWorked, EmpHourlyPay, (EmpHoursWorked * EmpHourlyPay) AS EmpNetPay, EmpFderalTax, EmpSocialSecurityTax, EmpMedicareTax FROM group2su212330.Employees");

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

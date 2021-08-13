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
    public partial class frmManager : Form
    {
        SqlConnection con;
        SqlDataAdapter sda;
        SqlCommandBuilder sqlCmd;
        DataTable dt;

        public frmManager()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            //ProgOps.DatabaseCommand(dgvEmp, "SELECT * FROM group2su212330.Employees");
            ProgOps.DatabaseCommand(dgvManager, "SELECT CAST(OrderPrice As Numeric(15, 2)) AS OrderPrice, OrderDate, ArrivalDate, CustID, OrderID FROM group2su212330.Orders");

            con = new SqlConnection("Server=cstnt.tstc.edu;Database= inew2330su21;" +
                "User Id=group2su212330;password=2547258");
            sda = new SqlDataAdapter(@"SELECT EmpID, EmpFirstName, EmpLastName, EmpHoursWorked, CAST(EmpHourlyPay AS NUMERIC(15, 2)) AS EmpHourlyPay," +
                " CAST((EmpHoursWorked * EmpHourlyPay) AS NUMERIC(15, 2))AS EmpNetPay, CAST(((EmpFderalTax * (EmpHoursWorked * EmpHourlyPay)) - " +
                "(EmpHoursWorked * EmpHourlyPay))AS NUMERIC(15, 2)) AS EmpFederal, CAST(((EmpSocialSecurityTax * (EmpHoursWorked * EmpHourlyPay)) - (EmpHoursWorked * EmpHourlyPay)) AS NUMERIC(15, 2)) AS EmpSocialSecurityTax," +
                " CAST(((EmpMedicareTax  * (EmpHoursWorked * EmpHourlyPay)) - (EmpHoursWorked * EmpHourlyPay)) AS NUMERIC(15, 2)) AS EmpMedicareTax," +
                " CAST( (EmpHoursWorked * EmpHourlyPay) - (((EmpFderalTax * (EmpHoursWorked * EmpHourlyPay)) - (EmpHoursWorked * EmpHourlyPay) + " +
                "((EmpSocialSecurityTax * (EmpHoursWorked * EmpHourlyPay)) - (EmpHoursWorked * EmpHourlyPay)) + ((EmpMedicareTax * (EmpHoursWorked * EmpHourlyPay))" +
                " - (EmpHoursWorked * EmpHourlyPay)))) AS NUMERIC(15, 2)) AS EmpTotalPay FROM group2su212330.Employees", con);
            dt = new DataTable();
            sda.Fill(dt);
            dgvEmp.DataSource = dt;

        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            CrystalReports.crptOrders order = new CrystalReports.crptOrders();
            order.SetDatabaseLogon("group2su212330", "2547258");
            frmViewer menuViewer = new frmViewer();
            menuViewer.crvMenuViewer.ReportSource = null;
            menuViewer.crvMenuViewer.ReportSource = order;
            menuViewer.Show();
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                sqlCmd = new SqlCommandBuilder(sda);

                sda.Update(dt);

                MessageBox.Show("Employees Database Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvEmp.SelectedRows)
            {
               
                dgvEmp.Rows.RemoveAt(item.Index);
                
            }
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            CrystalReports.crptOrders order = new CrystalReports.crptOrders();
            order.SetDatabaseLogon("group2su212330", "2547258");
            frmViewer menuViewer = new frmViewer();
            menuViewer.crvMenuViewer.ReportSource = null;
            menuViewer.crvMenuViewer.ReportSource = order;
            menuViewer.Show();
        }
    }
}

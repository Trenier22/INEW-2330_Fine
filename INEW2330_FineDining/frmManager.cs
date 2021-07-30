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
        DataSet ds;
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
            ProgOps.DatabaseCommand(dgvManager, "SELECT * FROM group2su212330.Orders");

            con = new SqlConnection("Server=cstnt.tstc.edu;Database= inew2330su21;" +
                "User Id=group2su212330;password=2547258");
            sda = new SqlDataAdapter("SELECT * FROM group2su212330.Employees", con);
            ds = new System.Data.DataSet();
            sda.Fill(ds, "Employees");
            dgvEmp.DataSource = ds.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCmd = new SqlCommandBuilder(sda);
                sda.Update(ds, "Employees");
                MessageBox.Show("Employees Database Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvEmp.SelectedRows)
            {
                dgvEmp.Rows.RemoveAt(item.Index);
            }
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
    }
}

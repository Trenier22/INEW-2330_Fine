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
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }

        private void inew2330su21DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvOrders.CurrentCell.RowIndex;
            int columnIndex = dgvOrders.CurrentCell.ColumnIndex;
            string EmpID = dgvOrders.Rows[rowIndex].Cells[columnIndex].Value.ToString();
            if (EmpID == "1")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 1");
            }
            if (EmpID == "2")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 2");
            }
            if (EmpID == "3")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 3");
            }
            if (EmpID == "4")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 4");
            }
            if (EmpID == "5")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 5");
            }
            if (EmpID == "6")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 6");
            }
            if (EmpID == "7")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 7");
            }
            if (EmpID == "8")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 8");
            }
            if (EmpID == "9")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 9");
            }
            if (EmpID == "10")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 10");
            }
            if (EmpID == "11")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 11");
            }
            if (EmpID == "12")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 12");
            }
            if (EmpID == "13")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 13");
            }
            if (EmpID == "14")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 14");
            }
            if (EmpID == "15")
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity - 1 WHERE DetailID = 15");
            }

            this.Controls.Clear();
            this.InitializeComponent();
            this.orderDetailsTableAdapter.Fill(this.inew2330su21DataSet2.OrderDetails);
            ProgOps.DatabaseCommand(dgvOrders, "SELECT DetailID, DetailQuantity FROM group2su212330.OrderDetails WHERE DetailQuantity > 0");

        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            frmCheckOut checkOut = new frmCheckOut();
            checkOut.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inew2330su21DataSet4.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter2.Fill(this.inew2330su21DataSet4.OrderDetails);
            // TODO: This line of code loads data into the 'inew2330su21DataSet3.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter1.Fill(this.inew2330su21DataSet3.OrderDetails);
            // TODO: This line of code loads data into the 'inew2330su21DataSet2.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.inew2330su21DataSet2.OrderDetails);
            ProgOps.DatabaseCommand(dgvOrders, "SELECT DetailID, DetailQuantity, DetailCost FROM group2su212330.OrderDetails WHERE DetailQuantity > 0");
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label5.Parent = pictureBox1;

            lblTotal.Text = (from DataGridViewRow row in dgvOrders.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                             select Convert.ToDecimal(row.Cells[2].FormattedValue)).Sum().ToString();
        }
    }
}

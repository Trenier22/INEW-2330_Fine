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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inew2330su21DataSet1.Merchandise' table. You can move, or remove it, as needed.
            this.merchandiseTableAdapter.Fill(this.inew2330su21DataSet.Merchandise);
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            frmCart cart = new frmCart();
            cart.ShowDialog();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentCell.RowIndex == 0)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 1");
            }
            if (dgvOrders.CurrentCell.RowIndex == 1)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 2");
            }
            if (dgvOrders.CurrentCell.RowIndex == 2)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 3");
            }
            if (dgvOrders.CurrentCell.RowIndex == 3)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 4");
            }
            if (dgvOrders.CurrentCell.RowIndex == 4)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 5");
            }
            if (dgvOrders.CurrentCell.RowIndex == 5)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 6");
            }
            if (dgvOrders.CurrentCell.RowIndex == 6)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 7");
            }
            if (dgvOrders.CurrentCell.RowIndex == 7)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 8");
            }
            if (dgvOrders.CurrentCell.RowIndex == 8)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 9");
            }
            if (dgvOrders.CurrentCell.RowIndex == 9)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 10");
            }
            if (dgvOrders.CurrentCell.RowIndex == 10)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 11");
            }
            if (dgvOrders.CurrentCell.RowIndex == 11)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 12");
            }
            if (dgvOrders.CurrentCell.RowIndex == 12)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 13");
            }
            if (dgvOrders.CurrentCell.RowIndex == 13)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 14");
            }
            if (dgvOrders.CurrentCell.RowIndex == 14)
            {
                ProgOps.DatabaseSQLCommand("UPDATE inew2330su21.group2su212330.OrderDetails SET " +
                    "DetailQuantity = DetailQuantity + 1 WHERE DetailID = 15");
            }

            this.Controls.Clear();
            this.InitializeComponent();
            this.merchandiseTableAdapter.Fill(this.inew2330su21DataSet.Merchandise);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCart cart = new frmCart();
            cart.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

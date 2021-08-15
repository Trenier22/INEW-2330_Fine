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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            label4.Parent = pictureBox2;

            ProgOps.DatabaseCommand(dataGridView2, "SELECT MerchID AS ID, MerchName AS Name, MerchDescription AS Description, CAST(MerchCost AS numeric(15, 2)) AS Cost FROM group2su212330.Merchandise");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CrystalReports.crptMenu menu = new CrystalReports.crptMenu();
            menu.SetDatabaseLogon("group2su212330", "2547258");
            frmViewer menuViewer = new frmViewer();
            menuViewer.crvMenuViewer.ReportSource = null;
            menuViewer.crvMenuViewer.ReportSource = menu;
            menuViewer.Show();
        }
    }
}

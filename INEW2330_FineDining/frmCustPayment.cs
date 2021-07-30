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
    public partial class frmCustPayment : Form
    {
        public frmCustPayment()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String custCreditCard;
            String custCVV;
            custCreditCard = tbxCreditCard.Text;
            custCVV = tbxCVV.Text;

            SqlConnection _cntDatabase = new SqlConnection("Server=cstnt.tstc.edu;Database= inew2330su21;" +
                "User Id=group2su212330;password=2547258");

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM group2su212330.Customer WHERE CustCreditCard = '" + custCreditCard
                + "' AND CustCVV = '" + custCVV + "'", _cntDatabase);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCustRegister reg = new frmCustRegister();
            reg.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string MyValue
        {
            get { return tbxCreditCard.Text; }
        }

        private void frmCustPayment_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
        }
    }
}

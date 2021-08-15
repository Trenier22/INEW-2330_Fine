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
using System.Text.RegularExpressions;

namespace INEW2330_FineDining
{
    public partial class frmCustRegister : Form
    {
        public frmCustRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ProgOps.DatabaseSQLCommand("INSERT INTO group2su212330.Customer(CustFirstName, CustLastName, CustEmail, CustPhone, CustAddress, CustCreditCard, CustLoginUserName, CustLoginPassword, CustCVV)" +
                    " VALUES('" + tbxFirstName.Text + "', '" + tbxLastName.Text + "', '" + tbxEmail.Text + "', " + tbxPhone.Text + ", '" + tbxAddress.Text + "', " + tbxCreditCard.Text + ", '" + tbxUsername.Text + "', '" + tbxPassword.Text + "', '" + tbxCVV.Text + "');");
                MessageBox.Show("Registration Complete");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCustRegister_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            label8.Parent = pictureBox1;
            label9.Parent = pictureBox1;
            label10.Parent = pictureBox1;
            label11.Parent = pictureBox1;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void tbxCreditCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void tbxCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        string oldText = string.Empty;
        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (tbxFirstName.Text.All(chr => char.IsLetter(chr)))
            {
                oldText = tbxFirstName.Text;
                tbxFirstName.Text = oldText;

                tbxFirstName.BackColor = System.Drawing.Color.White;
                tbxFirstName.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbxFirstName.Text = oldText;
                tbxFirstName.BackColor = System.Drawing.Color.Red;
                tbxFirstName.ForeColor = System.Drawing.Color.White;
            }
            tbxFirstName.SelectionStart = tbxFirstName.Text.Length;
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            if (tbxLastName.Text.All(chr => char.IsLetter(chr)))
            {
                oldText = tbxLastName.Text;
                tbxLastName.Text = oldText;

                tbxLastName.BackColor = System.Drawing.Color.White;
                tbxLastName.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbxLastName.Text = oldText;
                tbxLastName.BackColor = System.Drawing.Color.Red;
                tbxLastName.ForeColor = System.Drawing.Color.White;
            }
            tbxLastName.SelectionStart = tbxLastName.Text.Length;
        }

        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (tbxEmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(tbxEmail.Text.Trim()))
                {
                    MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxEmail.Focus();
                }
            }
        }
    }
}

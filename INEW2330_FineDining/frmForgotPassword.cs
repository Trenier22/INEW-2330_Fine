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
using System.Net;
using System.Net.Mail;

namespace INEW2330_FineDining
{
    public partial class frmForgotPassword : Form
    {
        string randomCode;
        public static string to;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (tbxEmail.Text).ToString();

            from = "stephenkolls@gmail.com";
            pass = "smurff2387";
            messageBody = "your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("code send successfully " + randomCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (randomCode == (tbxVer.Text).ToString())
            {
                to = tbxEmail.Text;
                frmResetPassword rp = new frmResetPassword();
                rp.Show();
            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    SqlConnection _cntDatabase = new SqlConnection("Server=cstnt.tstc.edu;Database= inew2330su21;" +
        //       "User Id=group2su212330;password=2547258");

        //    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM group2su212330.Employees WHERE EmpLoginUsername = '" + tbxUsername.Text + "'", _cntDatabase);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    if (dt.Rows[0][0].ToString() == "1")
        //    {
        //        ProgOps.DatabaseSQLCommand("UPDATE group2su212330.Employees SET EmpLoginPassword = '" + tbxPassword.Text + "' WHERE EmpLoginUsername = '" + tbxUsername.Text + "'");
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid Username");
        //    }
        //}



    }
}

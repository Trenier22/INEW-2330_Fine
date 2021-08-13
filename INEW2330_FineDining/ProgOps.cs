using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INEW2330_FineDining
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = "Server=cstnt.tstc.edu;Database= inew2330su21;" +
        "User Id=group2su212330;password=2547258";
        //build a connection to books database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //add command object
        private static SqlCommand _sqlResultsCommand;
        //add the data adapter
        private static SqlDataAdapter _daResults = new SqlDataAdapter();
        //add the data tables
        private static DataTable _dtResultsTable = new DataTable();

        //add command object
        private static SqlCommand _sqlEmployeesCommand;
        //add the data adapter
        private static SqlDataAdapter _daEmployees = new SqlDataAdapter();
        //add the data tables
        public static DataTable _dtEmployeesTable = new DataTable();

        //add command object
        private static SqlCommand _sqlCustomersCommand;
        //add the data adapter
        private static SqlDataAdapter _daCustomers = new SqlDataAdapter();
        //add the data tables
        public static DataTable _dtCustomersTable = new DataTable();

        //add command object
        private static SqlCommand _sqlManagerCommand;
        //add the data adapter
        private static SqlDataAdapter _daManager = new SqlDataAdapter();
        //add the data tables
        public static DataTable _dtManagerTable = new DataTable();

        private static int counter = 0;


        public static void OpenDatabase()
        {
            //method to open db and to allown use of data
            //open the connection to books db
            _cntDatabase.Open();

            //message stating connection was successful
            MessageBox.Show("Conection to db was opened successfully",
                "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        public static void CloseDatabase()
        {
            //method to close data and dispose of all objects
            //close connection
            _cntDatabase.Close();
            //dispose of db
            _cntDatabase.Dispose();
            MessageBox.Show("Conection to db was closed successfully",
                "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void DatabaseCommand(DataGridView dgvTable, string sqlStatement)
        {
            //set the command object to null
            _sqlResultsCommand = null;
            //reset data adapter and datatable to new
            _daResults = new SqlDataAdapter();
            _dtResultsTable = new DataTable();

            try
            {
                //establish the command object
                _sqlResultsCommand = new SqlCommand(sqlStatement, _cntDatabase);
                //test data adapter
                _daResults.SelectCommand = _sqlResultsCommand;
                //fill data table
                _daResults.Fill(_dtResultsTable);
                //bind dgv to data table
                dgvTable.DataSource = _dtResultsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //dispose of command, adapter, and table obj
            _sqlResultsCommand.Dispose();
            _daResults.Dispose();
            _dtResultsTable.Dispose();
        }

        public static void DatabaseSQLCommand(string sqlStatement)
        {
            //set the command object to null
            _sqlResultsCommand = null;
            //reset data adapter and datatable to new
            _daResults = new SqlDataAdapter();
            _dtResultsTable = new DataTable();

            try
            {
                //establish the command object
                _sqlResultsCommand = new SqlCommand(sqlStatement, _cntDatabase);
                //test data adapter
                _daResults.SelectCommand = _sqlResultsCommand;
                //fill data table
                _daResults.Fill(_dtResultsTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //dispose of command, adapter, and table obj
            _sqlResultsCommand.Dispose();
            _daResults.Dispose();
            _dtResultsTable.Dispose();
        }

        public static void EmpLoginCommand(TextBox tbxUsername, TextBox tbxPassword)
        {
            try
            {
                string query = "SELECT * FROM group2su212330.Employees WHERE EmpLoginUsername = '" + tbxUsername.Text.Trim() + "' AND EmpLoginPassword = '" + tbxPassword.Text.Trim() + "'";
                _sqlEmployeesCommand = new SqlCommand(query, _cntDatabase);
                _daEmployees = new SqlDataAdapter();
                _daEmployees.SelectCommand = _sqlEmployeesCommand;
                _dtEmployeesTable = new DataTable();
                _daEmployees.Fill(_dtEmployeesTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "102, Error in processing EmployeeLogin SQL Statement.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _sqlEmployeesCommand.Dispose();
            _daEmployees.Dispose();
            _dtEmployeesTable.Dispose();
        }

        public static void CustLoginCommand(TextBox tbxUsername, TextBox tbxPassword)
        {
            try
            {
                string query = "SELECT * FROM group2su212330.Customer WHERE CustLoginUsername = '" + tbxUsername.Text.Trim() + "' AND CustLoginPassword = '" + tbxPassword.Text.Trim() + "'";
                _sqlCustomersCommand = new SqlCommand(query, _cntDatabase);
                _daCustomers = new SqlDataAdapter();
                _daCustomers.SelectCommand = _sqlCustomersCommand;
                _dtCustomersTable = new DataTable();
                _daCustomers.Fill(_dtCustomersTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "102, Error in processing EmployeeLogin SQL Statement.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _sqlCustomersCommand.Dispose();
            _daCustomers.Dispose();
            _dtCustomersTable.Dispose();
        }


        public static void CustResetCommand(TextBox tbxUsername)
        {
            try
            {
                string query = "SELECT * FROM group2su212330.Customer WHERE CustLoginUsername = '" + tbxUsername.Text.Trim() + "'";
                _sqlCustomersCommand = new SqlCommand(query, _cntDatabase);
                _daCustomers = new SqlDataAdapter();
                _daCustomers.SelectCommand = _sqlCustomersCommand;
                _dtCustomersTable = new DataTable();
                _daCustomers.Fill(_dtCustomersTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "102, Error in processing CustomerLogin SQL Statement.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _sqlCustomersCommand.Dispose();
            _daCustomers.Dispose();
            _dtCustomersTable.Dispose();
        }

        public static void EmpResetCommand(TextBox tbxUsername)
        {
            try
            {
                string query = "SELECT * FROM group2su212330.Employees WHERE EmpLoginUsername = '" + tbxUsername.Text.Trim() + "'";
                _sqlEmployeesCommand = new SqlCommand(query, _cntDatabase);
                _daEmployees = new SqlDataAdapter();
                _daEmployees.SelectCommand = _sqlEmployeesCommand;
                _dtEmployeesTable = new DataTable();
                _daEmployees.Fill(_dtEmployeesTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "102, Error in processing EmployeeLogin SQL Statement.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _sqlEmployeesCommand.Dispose();
            _daEmployees.Dispose();
            _dtEmployeesTable.Dispose();
        }

        public static void ManResetCommand(TextBox tbxUsername)
        {
            try
            {
                string query = "SELECT * FROM group2su212330.Manager WHERE ManLoginUsername = '" + tbxUsername.Text.Trim() + "'";
                _sqlManagerCommand = new SqlCommand(query, _cntDatabase);
                _daManager = new SqlDataAdapter();
                _daManager.SelectCommand = _sqlManagerCommand;
                _dtManagerTable = new DataTable();
                _daManager.Fill(_dtManagerTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "102, Error in processing ManagerLogin SQL Statement.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _sqlManagerCommand.Dispose();
            _daManager.Dispose();
            _dtManagerTable.Dispose();
        }
    }

    


}


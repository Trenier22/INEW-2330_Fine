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


        public static void OpenDatabase()
        {
            //method to open db and to allown use of data
            //open the connection to books db
            _cntDatabase.Open();

            //message stating connection was successful
            MessageBox.Show("Conection to db was opened successfully",
                "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //public void sqlStatement(string SQLStatement)
        //{
        //    SQLStatement = SQLStatement.ToString();
        //}

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
    }
}
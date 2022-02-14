using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Schillinger_Quest4_ErrorInputDatabase
{
    public partial class BugForm : Form
    {
        public BugForm()
        {
            InitializeComponent();
            fill_listbox();
        }

        public BugForm(string bugName)
        {
            InitializeComponent();
            //Opens with this file selected
        }

        #region ~Buttons~
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try // Temporary connection checking
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "insert into errorinput.errors(errorID, errorDescription, errorType, lineNumber, errorStatus, errorFounder) values ('"
                    + this.txtID.Text + "', '"
                    + this.txtDescription.Text + "', '"
                    + this.dropErrorType.SelectedItem + "', "
                    + this.txtLineNumber.Text + ", '"
                    + this.dropErrorStatus.SelectedItem + "', '"
                    + this.txtFounder.Text + "');";

                MySqlCommand cmdDataBase = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;

                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();

                MessageBox.Show("Error Logged Successfully");

                while(myReader.Read())
                { }

                myConn.Close();
                fill_listbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Not Logged");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try // Temporary connection checking
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "update errorinput.errors set errorID='"
                    + this.txtID.Text + "', errorDescription='"
                    + this.txtDescription.Text + "', errorType='"
                    + this.dropErrorType.SelectedItem + "', lineNumber="
                    + this.txtLineNumber.Text + ", errorStatus='"
                    + this.dropErrorStatus.SelectedItem + "', errorFounder='"
                    + this.txtFounder.Text + "' where errorID='"
                    + this.txtID.Text + "';";

                MySqlCommand cmdDataBase = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;

                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();

                MessageBox.Show("Error Updated Successfully");

                while (myReader.Read())
                { }

                myConn.Close();
                fill_listbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Not Updated");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Replay not Uploaded");
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ~ListBox~
        void fill_listbox()
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "select * from errorinput.errors";

                MySqlCommand cmdDataBase = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;

                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();

                errorList.Items.Clear();

                while (myReader.Read())
                {
                    string errorDesc = myReader.GetString("errorDescription");
                    errorList.Items.Add(errorDesc);
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ErrorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "select * from errorinput.errors where errorDescription='" + errorList.Text + "';";

                MySqlCommand cmdDataBase = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;

                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();

                while(myReader.Read())
                {
                    string errorID = myReader.GetString("errorID");
                    string errorDesc = myReader.GetString("errorDescription");
                    string errorType = myReader.GetString("errorType");
                    int errorLine = myReader.GetInt32("lineNumber");
                    string errorStatus = myReader.GetString("errorStatus");
                    string errorFounder = myReader.GetString("errorFounder");
                    txtID.Text = errorID;
                    txtDescription.Text = errorDesc;
                    dropErrorType.SelectedItem = errorType;
                    txtLineNumber.Text = errorLine.ToString();
                    dropErrorStatus.SelectedItem = errorStatus;
                    txtFounder.Text = errorFounder;
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Connected");
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void BugForm_Load(object sender, EventArgs e)
        {

        }
    }
}

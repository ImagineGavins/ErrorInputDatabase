using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

                ErrorBox.Items.Clear();

                while(myReader.Read())
                {
                    string errorDesc = myReader.GetString("errorDescription");
                    ErrorBox.Items.Add(errorDesc);
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BugForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try // Temporary connection checking
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "insert into errorinput.errors(errorID, errorDescription, errorType, lineNumber, errorStatus, errorFounder) values ('"
                    + this.textBox1.Text + "', '"
                    + this.ErrorDescriptionTextBox.Text + "', '"
                    + this.TypeOfErrorDropDown.SelectedItem + "', "
                    + this.LineNumberTextBox.Text + ", '"
                    + this.ErrorStatusDropDown.SelectedItem + "', '"
                    + this.FounderTextBox.Text + "');";

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

        private void ErrorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=root;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                string query = "select * from errorinput.errors where errorDescription='" + ErrorBox.Text + "';";

                MySqlCommand cmdDataBase = new MySqlCommand(query, myConn);

                MySqlDataReader myReader;

                myConn.Open();
                myReader = cmdDataBase.ExecuteReader();

                while(myReader.Read())
                {
                    string errorDesc = myReader.GetString("errorDescription");
                    string errorType = myReader.GetString("errorType");
                    int errorLine = myReader.GetInt32("lineNumber");
                    string errorStatus = myReader.GetString("errorStatus");
                    string errorFounder = myReader.GetString("errorFounder");
                    ErrorDescriptionTextBox.Text = errorDesc;
                    TypeOfErrorDropDown.SelectedItem = errorType;
                    LineNumberTextBox.Text = errorLine.ToString();
                    ErrorStatusDropDown.SelectedItem = errorStatus;
                    FounderTextBox.Text = errorFounder;
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Connected");
                MessageBox.Show(ex.Message);
            }
        }
    }
}

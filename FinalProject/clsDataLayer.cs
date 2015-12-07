//Include namespaces for databse access
using System.Data.OleDb;
using System.Net;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject;

/// <summary>
/// Summary description for clsDataLayer
/// </summary>
public class clsDataLayer
{
    public clsDataLayer()
    {
        //clsDataLayer constructor
    }
    // This function verifies a user in the tblUser table
    public static dsUser VerifyUser(string Database, string UserName, string UserPassword)
    {
        // New methods
        dsUser DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // Adding the connection type
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);

        // Prompt for user/password
        sqlDA = new OleDbDataAdapter("Select SecurityLevel from tblUserLogin " +
        "where UserName like '" + UserName + "' " +
        "and UserPassword like '" + UserPassword + "'", sqlConn);

        // New objects
        DS = new dsUser();
        // fill the entered information
        sqlDA.Fill(DS.tblUserLogin);

        // Return if user exists
        return DS;
    }
    //This function save user security levels
    public static bool SaveUser(string Database, string UserName, string Password,
        string SecurityLevel)
    {
        bool userSaved;
        //Create transactions object
        OleDbTransaction myTransaction = null;

        try
        {
            // Database connection object
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            //Begin transactions
            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            // Assign the insert to a variable of the user information into the user login table
            strSQL = "Insert into tblUserLogin " +
            "(UserName, UserPassword, SecurityLevel) values ('" +
            UserName + "', '" + Password + "','" + SecurityLevel + "')";

            // Set how the value of query should be used; get the sql command to execute
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            //Executes the query and returns records
            command.ExecuteNonQuery();

            // Get the values and how the values should be used
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // Executes the query
            command.ExecuteNonQuery();

            //Commint the transations
            myTransaction.Commit();

            // Closing the database connection
            conn.Close();
            userSaved = true;
        }
        catch (Exception ex)
        {
            //Rollback transactions for exceptions
            myTransaction.Rollback();

            userSaved = false;
        }
        return userSaved;

    }
    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName,
    string PayRate, string StartDate, string EndDate)
    {
        bool recordSaved;

        //Create transactions object
        OleDbTransaction myTransaction = null;

        try
        {
            // Database connection object
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            //Begin transactions
            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            // Assign the insert to a variable
            strSQL = "Insert into tblPersonnel " +
            "(FirstName, LastName) values ('" +
            FirstName + "', '" + LastName + "')";
            // Set how the value of query should be used; get the sql command to execute
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            //Executes the query and returns records
            command.ExecuteNonQuery();
            // Statement to update fields in tblPersonnel
            strSQL = "Update tblPersonnel " +
            "Set PayRate=" + PayRate + ", " +
            "StartDate='" + StartDate + "', " +
            "EndDate='" + EndDate + "' " +
            "Where ID=(Select Max(ID) From tblPersonnel)";
            // Get the values and how the values should be used
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;
            // Executes the query
            command.ExecuteNonQuery();

            //Commint the transations
            myTransaction.Commit();

            // Closing the database connection
            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {
            //Rollback transactions for exceptions
            myTransaction.Rollback();

            recordSaved = false;
        }
        return recordSaved;
    }
    /**This function get all data from tblPersonnel
    public static dsPersonnel GetPersonnel(string Database, string strSearch)
    {
        //Creating new objects
        dsPersonnel DSPerson;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;


        // Assign the connection string to variable
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);

        if (strSearch == null || strSearch.Trim() == "")
        {
            // Assign the query from the connection to a variable
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
        }
        else
        {
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearch + "'", sqlConn);
        }

        // New object
        DSPerson = new dsPersonnel();

        // Executes query activity tables
        sqlDA.Fill(DSPerson.tblPersonnel);

        // the value will return when the function is called
        return DSPerson;

    }
    // This function gets the user activity from the tblUserActivity
    public static dsUserActivity GetUserActivity(string Database)
    {
        // Creating new objects and variables
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // Assign the connection string to variable
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Database);

        // Assign the query from the connection to a variable
        sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);

        // New object
        DS = new dsUserActivity();

        // Executes query activity tables
        sqlDA.Fill(DS.tblUserActivity);

        // the value will return when the function is called
        return DS;
    }
    // This function saves the user activity **/
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        // Open database connection, execute insert statement into table and closes connection
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;
        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
        GetIP4Address() + "', '" + FormAccessed + "')";
        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }
    // This function gets the IP Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;
        foreach (IPAddress IPA in
        Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }
        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }
        return IP4Address;
    }

}
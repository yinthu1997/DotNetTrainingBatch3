// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

Console.WriteLine("Hello, World!");

// F5 => Run
// Ctrl + K,C => Disable

//Cotrl+KU => Enable

//Console.ReadLine();
// F9 => breakpoint



SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
sqlConnectionStringBuilder.DataSource = ".";
sqlConnectionStringBuilder.InitialCatalog = "testdb";
sqlConnectionStringBuilder.UserID = "sa";
sqlConnectionStringBuilder.Password = "sa@123";

string query = "select * from tbl_blog";
SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
sqlConnection.Open();

SqlCommand cmd = new SqlCommand(query,sqlConnection);
SqlDataAdapter adapter = new SqlDataAdapter(cmd);

DataTable dataTable = new DataTable();
adapter.Fill(dt);

sqlConnection.Close();

foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine(dr["BlogId"]);
    Console.WriteLine(dr["BlogTitle"]);
    Console.WriteLine(dr["BlogAuthor"]);
    Console.WriteLine(dr["BlogContent"]);
   
}




    
    Console.ReadKey();
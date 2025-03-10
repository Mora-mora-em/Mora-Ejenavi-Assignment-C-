class Program
{
    static void Main(string[] args)
    {
        // Testing the SqlConnection
        var sqlConnection = new SqlConnection("Server=myServer;Database=myDB;User  Id=myUser ;Password=myPass;");
        sqlConnection.Open(); // Output: SQL Server connection opened.
        sqlConnection.Close(); // Output: SQL Server connection closed.

        // Testing the OracleConnection
        var oracleConnection = new OracleConnection("Data Source=myOracleDB;User  Id=myUser ;Password=myPass;");
        oracleConnection.Open(); // Output: Oracle connection opened.
        oracleConnection.Close(); // Output: Oracle connection closed.
    }
}
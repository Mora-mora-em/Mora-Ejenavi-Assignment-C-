class Program
{
    static void Main(string[] args)
    {
        // Testing the DbCommand with SqlConnection
        var sqlConnection = new SqlConnection("Server=myServer;Database=myDB;User  Id=myUser ;Password=myPass;");
        var sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Users");
        sqlCommand.Execute(); // Output: SQL Server connection opened. Executing command: SELECT * FROM Users SQL Server connection closed.

        // Testing the DbCommand with OracleConnection
        var oracleConnection = new OracleConnection("Data Source=myOracleDB;User  Id=myUser ;Password=myPass;");
        var oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Employees");
        oracleCommand.Execute(); // Output: Oracle connection opened. Executing command: SELECT * FROM Employees Oracle connection closed.
    }
}
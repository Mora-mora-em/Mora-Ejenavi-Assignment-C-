using System;

public abstract class DbConnection
{
    public string ConnectionString { get; private set; }
    public TimeSpan Timeout { get; set; }

    // Constructor to initialize the connection string
    public DbConnection(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentException("Connection string cannot be null or empty.");
        }
        ConnectionString = connectionString;
    }

    // Abstract methods for opening and closing the connection
    public abstract void Open();
    public abstract void Close();
}

public class SqlConnection : DbConnection
{
    public SqlConnection(string connectionString) : base(connectionString) { }

    public override void Open()
    {
        Console.WriteLine("SQL Server connection opened.");
    }

    public override void Close()
    {
        Console.WriteLine("SQL Server connection closed.");
    }
}

public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString) : base(connectionString) { }

    public override void Open()
    {
        Console.WriteLine("Oracle connection opened.");
    }

    public override void Close()
    {
        Console.WriteLine("Oracle connection closed.");
    }
}
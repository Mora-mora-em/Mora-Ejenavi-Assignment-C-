using System;

public class DbCommand
{
    private DbConnection _connection;
    private string _instruction;

    // Constructor to initialize the command with a connection and instruction
    public DbCommand(DbConnection connection, string instruction)
    {
        _connection = connection ?? throw new ArgumentNullException(nameof(connection), "Connection cannot be null.");
        if (string.IsNullOrEmpty(instruction))
        {
            throw new ArgumentException("Instruction cannot be null or empty.");
        }
        _instruction = instruction;
    }

    // Execute method to run the command
    public void Execute()
    {
        _connection.Open(); // Open the connection
        Console.WriteLine($"Executing command: {_instruction}"); // Output the instruction
        _connection.Close(); // Close the connection
    }
}
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

class Connection
{
    static void Main()
    {

        SqlConnection connectionString = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DogDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");


        string createTableSql = "CREATE TABLE IF NOT EXISTS DOG (" +
            "id INT IDENTITY(1,1) PRIMARY KEY," +
            "dogName VARCHAR(255) NOT NULL," +
            "dogAge INT NOT NULL," +
            "dogBreed VARCHAR(255) NOT NULL," +
            "dogDescription VARCHAR(3200)," +
            "dogPhoto VARBINARY(10000)";

        SqlCommand createTableCommand = new SqlCommand(createTableSql, connectionString);

        try
        {
            connectionString.Open();
            createTableCommand.ExecuteNonQuery();
            Console.WriteLine("Table created!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            connectionString.Close();
        }

    }
}

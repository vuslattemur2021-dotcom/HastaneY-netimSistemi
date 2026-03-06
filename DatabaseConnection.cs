using System;
using System.Data.SqlClient;

public class DatabaseConnection {
    private static string connectionString = "Server=YOUR_SERVER;Database=HastaneDB;User Id=sa;Password=YOUR_PASSWORD;";

    public static SqlConnection GetConnection() {
        try {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        } catch (Exception ex) {
            Console.WriteLine("Database connection failed: " + ex.Message);
            return null;
        }
    }
}
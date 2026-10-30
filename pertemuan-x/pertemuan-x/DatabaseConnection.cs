using Npgsql;

public class DatabaseConnection
{
    private readonly string _connectionString;

    public DatabaseConnection(string host, int port, string database, string username, string password)
    {
        _connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password}";
    }

    public NpgsqlConnection CreateConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }

    public bool TestConnection()
    {
        try
        {
            using var conn = CreateConnection();
            conn.Open();
            return true;
        }
        catch (NpgsqlException ex)
        {
            Console.WriteLine($"Gagal terhubung: {ex.Message}");
            return false;
        }
    }
}

using Npgsql;

public class MahasiswaQuery {
    private readonly DatabaseConnection _db;

    public MahasiswaQuery(DatabaseConnection db) {
        _db = db;
    }

    //Menambahkan data (INSERT)
    public void Insert(string nim, string nama, string jurusan) {
        using var conn = _db.CreateConnection();
        conn.Open();

        string sql = "INSERT INTO mahasiswa (nim, nama, jurusan) VALUES (@nim, @nama, @jurusan)";
        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("nim", nim);
        cmd.Parameters.AddWithValue("nama", nama);
        cmd.Parameters.AddWithValue("jurusan", jurusan);

        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine($"Data ditambahkan sebanyak {rows}");
    }

    //Menampilkan data (SELECT)
    public void SelectAll() {
        using var conn = _db.CreateConnection();
        conn.Open();

        string sql = "SELECT id, nim, nama, jurusan FROM mahasiswa ORDER BY id";
        using var cmd = new NpgsqlCommand(sql, conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read()) {
            Console.WriteLine($"{reader.GetInt32(0)} | {reader.GetString(1)} | {reader.GetString(2)} | {reader.GetString(3)}");
        }
    }

    //Mengupdate data (UPDATE)
    public void Update(string nim, string namaBaru) {
        using var conn = _db.CreateConnection();
        conn.Open();

        string sql = "UPDATE mahasiswa SET nama = @nama WHERE nim = @nim";
        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("nama", namaBaru);
        cmd.Parameters.AddWithValue("nim", nim);

        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine($"Data diubah sebanyak {rows}");
    }

    //Menghapus data (DELETE)
    public void Delete(string nim) {
        using var conn = _db.CreateConnection();
        conn.Open();

        string sql = "DELETE FROM mahasiswa WHERE nim = @nim";
        using var cmd = new NpgsqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("nim", nim);

        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine($"Data diubah sebanyak {rows}");
    }

    public long Count() {
        using var conn = _db.CreateConnection();
        conn.Open();

        string sql = "SELECT COUNT(*) FROM mahasiswa";
        using var cmd = new NpgsqlCommand(sql, conn);

        return (long)cmd.ExecuteScalar()!;
    }
}

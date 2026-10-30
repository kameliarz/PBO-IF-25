var db = new DatabaseConnection("localhost", 5432, "praktikum_db", "postgres", "lia241105");

if (db.TestConnection()) {
    Console.WriteLine("Koneksi berhasil!");
}

var query = new MahasiswaQuery(db);


//query.Insert("241050", "Kamelia", "Sistem Informasi");

//query.Update("241050", "Taufiq");

//query.Delete("241058");

Console.WriteLine($"Jumlah data: {query.Count()}");

query.SelectAll();


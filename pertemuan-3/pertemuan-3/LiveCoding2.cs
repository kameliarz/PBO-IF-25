using System;

public class Buku {
    public string Judul;
    public string Penulis;
    public int TahunTerbit;
    public Buku() { }
    public Buku(string judul, string penulis, int tahunTerbit) {
        this.Judul = judul;
        this.Penulis = penulis;
        this.TahunTerbit = tahunTerbit;
    }
    public void InfoBuku() {
        Console.WriteLine($"Judul: {Judul}, Penulis: {Penulis}, Tahun Terbit: {TahunTerbit}");
    }
}

//child class
public class BukuDigital : Buku {
    public double ukuranFile;
    public BukuDigital(string judul, string penulis, int tahunTerbit, double ukuranFile)
        : base(judul, penulis, tahunTerbit) {
        this.ukuranFile = ukuranFile;
    }
    public void TampilkanInfoBukuDigital() {
        Console.WriteLine($"Judul: {Judul}, Penulis: {Penulis}, Tahun Terbit: {TahunTerbit}, Ukuran File: {ukuranFile}");
    }
}

//class Program {
//    static void Main() {
//        Buku buku1 = new Buku("Pemrograman C#", "John Doe", 2020);
//        buku1.InfoBuku();
//        BukuDigital bukuDigital1 = new BukuDigital("Pemrograman C# Digital", "Jane Doe", 2021, 5);
//        bukuDigital1.TampilkanInfoBukuDigital();
//    }
//}

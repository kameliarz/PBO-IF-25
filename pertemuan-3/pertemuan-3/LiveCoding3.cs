using System;

public class AnggotaPerpustakaan {
    public string Nama;
    public string IdAnggota;
    public string Alamat;
    public int Usia;

    public AnggotaPerpustakaan() { }

    public AnggotaPerpustakaan(string Nama, string IdAnggota, string Alamat, int Usia) {
        this.Nama = Nama;
        this.IdAnggota = IdAnggota;
        this.Alamat = Alamat;
        this.Usia = Usia;
    }

    public void TampilkanInfoAnggota() {
        Console.WriteLine($"Nama: {Nama}, ID Anggota: {IdAnggota}, Alamat: {Alamat}, Usia: {Usia}");
    }
}

public class Mahasiswa : AnggotaPerpustakaan {
    public string NIM;
    public string Jurusan;

    public void InfoMahasiswa() {
        Console.WriteLine($"NIM: {NIM}, Jurusan: {Jurusan}");
    }
}

public class Dosen : AnggotaPerpustakaan {
    public string NIP;
    public string Jabatan;

    public void InfoDosen() {
        Console.WriteLine($"NIP: {NIP}, Jabatan: {Jabatan}");
    }
}

class Program {
    static void Main() {
        Mahasiswa mhs1 = new Mahasiswa();
        mhs1.Nama = "Dava";
        mhs1.IdAnggota = "01";
        mhs1.Alamat = "Jember";
        mhs1.Usia = 15;
        mhs1.NIM = "252410103071";
        mhs1.Jurusan = "Informatika";

        mhs1.TampilkanInfoAnggota();
        mhs1.InfoMahasiswa();

        Console.WriteLine();

        Dosen dsn1 = new Dosen();
        dsn1.Nama = "Pak Andrew";
        dsn1.IdAnggota = "02";
        dsn1.Alamat = "Sumatra";
        dsn1.Usia = 14;
        dsn1.NIP = "10252410103069";
        dsn1.Jabatan = "Wakil rektor";

        dsn1.TampilkanInfoAnggota();
        dsn1.InfoDosen();

        AnggotaPerpustakaan perpus = new AnggotaPerpustakaan("Lingga", "03", "Jawa", 13);
        perpus.TampilkanInfoAnggota();

    }
}

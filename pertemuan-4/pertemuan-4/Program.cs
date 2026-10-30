using System.Security.Cryptography;

public class Kasir {
    public virtual void Membayar(string Pembayar) {
        Console.WriteLine($"{Pembayar} Sudah bayar Tunai Bang");
    }
    public virtual void Bertanya (string HalYgDitanya) {

    }
    public void Berhutang (string Metode) {
        Console.WriteLine($"Aku berhutang pake {Metode}");
    }
    //public void Bayar(int harga) {
    //    Console.WriteLine($"Membayar dengan 1 pecahan senilai: {harga}");
    //}
    //public void Bayar(int harga1, int harga2) {
    //    Console.WriteLine($"membayar dengan 2 pecahan dengan total: {harga1+harga2}");
    //}
    //public void Bayar(string norek) {
    //    Console.WriteLine($"Membayar dengan kartu kredit dengan no rekening: {norek}");
    //}
}

public class MesinKasir : Kasir {
    public override void Membayar(string NamaPembayar) {
        Console.WriteLine("Aku sudah bayar sendiri bang di mesin");
    }

    public override void Bertanya(string HalYgDitanya) {
        
    }

    public void Berhutang (string Nama, string Metode, int Jumlah) {
        Console.WriteLine($"{Nama} Berhutang pakai {Metode} sejumlah {Jumlah}");
    }
}

public class Program {
    public static void Main() {
        MesinKasir kasir1 = new MesinKasir();

        kasir1.Membayar("Budiono");
        kasir1.Berhutang("Dono", "ShopeePayLater", 10000);

        //kasir1.Bayar(30000);
        //kasir1.Bayar(5000, 20000);
        //kasir1.Bayar("1234567890");
    }
}

// ABSTRACT CLASS
abstract class Pembayaran {
    public string NamaMetode { get; set;  }

    public Pembayaran(string nama) {
        NamaMetode = nama;
    }

    public abstract void ProsesPembayaran(decimal jumlah);
}

class Cash : Pembayaran {
    public Cash() : base("Cash") { }

    public override void ProsesPembayaran(decimal jumlah) {
        Console.WriteLine($"Sudah sebesar {jumlah} melakukan pembayaran dengan {NamaMetode}...");
    }
}

class QRIS : Pembayaran{
   public QRIS() : base("QRIS") { }

    public override void ProsesPembayaran(decimal jumlah) {
        Console.WriteLine($"Pembayaran masuk melalui {NamaMetode} senilai {jumlah}");
    }
}

//class Program {
//    public static void Main(string[] args) {
//        Pembayaran pembayaran1 = new Cash();
//        Pembayaran pembayaran2 = new QRIS();

//        Console.WriteLine(pembayaran1.NamaMetode);
//        pembayaran1.ProsesPembayaran(30000);
//        Console.WriteLine(pembayaran2.NamaMetode);
//        pembayaran2.ProsesPembayaran(50000);
//    }
//}


// INTERFACE

interface IHewan {
    void Suara();
}

interface IBisaTerbang {
    void Terbang();
}

class Burung : IHewan, IBisaTerbang {
    public void Suara() {
        Console.WriteLine("Cit cit cuit..!");
    }

    public void Makan() {
        Console.WriteLine("Burung makan biji-bijian.");
    }

    public void Terbang() {
        Console.WriteLine("Burung bisa terbang");
    }
}

class Program {
    public static void Main() {
        IHewan burung1 = new Burung(); // kalau interfacenya 1

        //kalau interfacenya > 1
        Burung burung = new Burung();
        IHewan hewan = burung;
        IBisaTerbang penerbang = burung;

        burung.Makan();
        hewan.Suara();
        penerbang.Terbang();
    }
}

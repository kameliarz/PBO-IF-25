public class Kendaraan {
    public string Merek;
    public int TahunProduksi;

    public Kendaraan() { }

    public Kendaraan(string merek, int tahunProduksi) {
        this.Merek = merek;
        this.TahunProduksi = tahunProduksi;
    }

    public void TampilkanKendaraan() {
        Console.WriteLine($"mereknya itu: {Merek}");
        Console.WriteLine($"tahun produksi nya: {TahunProduksi}");
    }
}

public class Mobil : Kendaraan {
    public int JumlahPintu;

    public Mobil(int  jumlahPintu, string merek, int tahunProduksi) :base(merek,tahunProduksi) {

    }

}

public class Motor : Kendaraan {
    public string JenisMotor;

    public Motor(string jenisMotor, string merek, int tahunProduksi) : base(merek, tahunProduksi) {
        this.JenisMotor = jenisMotor;
    }
}

//class Program {

//    static void Main(string[] args) {
//    Kendaraan kendaraan1 = new Kendaraan("merek1", 2026);
//        Motor motor1 = new Motor("racing", "merek1", 2026);
//    kendaraan1.TampilkanKendaraan();
//        Console.WriteLine($"motor dengan merek {kendaraan1.Merek} dengan jenis {motor1.JenisMotor}");

//    }
    
//}

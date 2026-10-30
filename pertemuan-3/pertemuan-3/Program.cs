using System;

public class PegawaiRestoran {
    public string NamaPegawai;
    public int Umur;
    public string NomorTelepon;

    public PegawaiRestoran() { }
    public PegawaiRestoran(string NamaPegawai, int Umur, string NomorTelepon) {
        this.NamaPegawai = NamaPegawai;
        this.Umur = Umur;
        this.NomorTelepon = NomorTelepon;
    }

    public void Absensi() {
        Console.WriteLine("Pegawai Ini Absensi");
    }
}

public class Waitress : PegawaiRestoran {

}

public class Koki : PegawaiRestoran {
    public Koki(string NamaPegawai, int Umur, string NomorTelepon) : base(NamaPegawai, Umur, NomorTelepon) {

    }
}

public class Kasir : PegawaiRestoran {
    public string JenisShift;
    public Kasir (string NamaPegawai, int Umur, string NomorTelepon, string JenisShift) : base(NamaPegawai, Umur, NomorTelepon){
        this.JenisShift = JenisShift;
    }
}




//class Program {
//    static void Main () {
//        Waitress Pegawai1 = new Waitress();
//        Pegawai1.NamaPegawai = "Handoko";
//        Pegawai1.Umur = 35;
//        Pegawai1.NomorTelepon = "0812345678";
//        Pegawai1.Absensi();

//        Koki Pegawai2 = new Koki("Budi", 40, "08987654321");
//        Console.WriteLine(Pegawai2.NamaPegawai);

//        Kasir Pegawai3 = new Kasir("Dina", 25, "0897588277222", "Malam");
//        Console.WriteLine($"{Pegawai3.NamaPegawai} Bekerja pada shift {Pegawai3.JenisShift}");
//    }
//}

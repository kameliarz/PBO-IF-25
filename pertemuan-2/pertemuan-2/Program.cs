//class Kucing {

//    //atributte
//    public string nama;
//    public string warna;
//    public string ras;
//    public int umur;

//    // Konstruktor
//    public Kucing(string Nama, string Warna, string Ras, int Umur) {
//        Nama = nama;
//        Warna = warna;
//        Ras = ras;
//        Umur = umur;
//    }

//    // Method
//    public void Mengeong() {
//        Console.WriteLine($"Kucing berwarna {warna} sedang mengeong!");
//    }
//}

namespace Kucing.Rumahan {
    class Kucing {

        //atributte
        public string nama;
        public static string warna = "Oren";
        public static int banyakNgeong = 0;
        public string ras;
        public int umur;

        // Konstruktor
        public Kucing(string nama, string ras, int umur) {
            this.nama = nama;
            this.ras = ras;
            this.umur = umur;
        }

        // Method
        public static int Mengeong() {
            Console.WriteLine($"Kucing berwarna {warna} sedang mengeong!");
            banyakNgeong ++;
            return banyakNgeong;
        }
    }
}

namespace Kucing.Liar {
    class Kucing {

        //atributte
        public string warna;
        public string ras;
        public int umur;

        // Konstruktor
        public Kucing(string Warna, string Ras, int Umur) {
            Warna = warna;
            Ras = ras;
            Umur = umur;
        }

        // Method
        public void Mengeong() {
            Console.WriteLine($"Kucing berwarna {warna} sedang mengeong!");
        }
    }
} 


class Program {
    public static void Main(string[] args) {
        //pakai konstruktor
        Kucing.Rumahan.Kucing kucing1 = new Kucing.Rumahan.Kucing("Mimi", "Anggora", 5);

        Console.WriteLine(Kucing.Rumahan.Kucing.warna);
        Console.WriteLine(kucing1.nama);
        //Console.WriteLine(kucing1.warna);
        //tidak pakai konstruktor
        //Kucing kucing1 = new Kucing();
        //kucing1.nama = "Mimi";
        //kucing1.warna = "Oren";
        //kucing1.ras = "Anggora";
        //kucing1.umur = 5;

        Kucing.Rumahan.Kucing.Mengeong();
        Kucing.Rumahan.Kucing.Mengeong();
        Kucing.Rumahan.Kucing.Mengeong();
        Kucing.Rumahan.Kucing.Mengeong();
        Kucing.Rumahan.Kucing.Mengeong();
        Kucing.Rumahan.Kucing.Mengeong();
        Kucing.Rumahan.Kucing.Mengeong();

        Console.WriteLine($"Kucing ku sudah mengeong {Kucing.Rumahan.Kucing.banyakNgeong} Kali");
    }
}

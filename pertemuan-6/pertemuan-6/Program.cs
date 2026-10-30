//class Mahasiswa {
//    public string Nama {  get; set; }

//    public void Mengikuti(Matkul matkul) { //method yang menghubungkan mahasiswa - matkul
//        Console.WriteLine($"{Nama} mengikuti mata kuliah {matkul.Nama}");
//    }
//}

//class Matkul {
//    public string Nama { get; set; }

//    public Matkul(string Nama){
//        this.Nama = Nama;
//    }
//}


//class Program {
//    public static void Main() {
//        Matkul matkul = new Matkul("Pemrograman C#");

//        Mahasiswa mahasiswa = new Mahasiswa();
//        mahasiswa.Nama = "Agus";

//        Console.WriteLine(matkul.Nama);
//        Console.WriteLine(mahasiswa.Nama);

//        //mahasiswa.Mengikuti(matkul); // association
//    }
//}


//class Wheel {
//    public string Brand { get; set; }

//    public Wheel(string brand) {
//        Brand = brand;
//    }
//}

//class Car {
//    public string Model { get; set; }
//    public List<Wheel> Wheels { get; set; }

//    public Car(string model, List<Wheel> wheels) {
//        Model = model;
//        Wheels = wheels;
//    }
//}

//class Program {
//    static void Main () {
//        Wheel ban1 = new Wheel("Michelin");
//        Wheel ban2 = new Wheel("Dunlop");
//        Wheel ban3 = new Wheel("BridgeStone");
//        Wheel ban4 = new Wheel("BatLax");

//        Console.WriteLine(ban4.Brand);

//        List<Wheel> wheels= new List<Wheel> {
//            ban1,
//            ban2,
//            ban3,
//            ban4
//        };

//        Car car1 = new Car("Toyota", wheels);

//        foreach (Wheel ban in car1.Wheels) {
//            Console.WriteLine(ban.Brand);
//        }
//    }
//}

using System.ComponentModel;

class Room {
    public string Name { get; set; }

    public Room(string name) {
        Name = name;
    }
}

class House {
    public string Address { get; set; }
    public List<Room> Rooms { get; set; }

    public House(string address) {
        Address = address;

        Rooms = new List<Room>
        {
            new Room("Living Room"),
            new Room("Bedroom")
        };
    }

    public void AddRoom(string nama) {
        Room ruanganBaru = new Room(nama);

        Rooms.Add(ruanganBaru);
    }
}

class Program {
    static void Main() {
        House Rumah1 = new House("Jalan Jalan Setapak");
        Console.WriteLine(Rumah1.Rooms);
        foreach (Room Ruangan in Rumah1.Rooms){
            Console.WriteLine(Ruangan.Name);
        }
        Rumah1.AddRoom("Ruang Keluarga");
        Console.WriteLine("Setelah Ditambah : ");
        foreach (Room Ruangan in Rumah1.Rooms) {
            Console.WriteLine(Ruangan.Name);
        }
    }
}

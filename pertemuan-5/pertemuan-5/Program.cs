class RekeningBank {
    public string namaPemilik;
    private decimal saldo;

    public decimal Saldo {
        get { return saldo; }
        set { saldo = value; }
    }

    public void TampilkanSaldo() {
        Console.WriteLine(Saldo);
    }
}

class Program {
    static void Main(string[] args) {
        RekeningBank rekening = new RekeningBank();

        rekening.namaPemilik = "Nina";
        rekening.Saldo = 500000;
        Console.WriteLine($"Saldo awal : {rekening.Saldo}");
    }
}

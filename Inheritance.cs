// Inheritance

using System;

public class Kendaraan
{
    public string Merk { get; set; }
    public string Model { get; set; }
    public int Tahun { get; set; }
}

public class Mobil : Kendaraan
{
    public void Start()
    {
        Console.WriteLine("Mobil telah dinyalakan");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Mobil mobil1 = new Mobil();
        mobil1.Merk = "Toyota";
        mobil1.Model = "Avanza";
        mobil1.Tahun = 2020;

        Console.WriteLine("Merk mobil: " + mobil1.Merk);
        Console.WriteLine("Model mobil: " + mobil1.Model);
        Console.WriteLine("Tahun mobil: " + mobil1.Tahun);

        mobil1.Start();
    }
}

/*
Keterangan: Program ini menunjukkan konsep inheritance dengan membuat kelas anak Mobil yang mewarisi kelas Kendaraan. Kelas Mobil memiliki metode Start() yang khusus hanya ada di kelas Mobil. Dalam contoh ini, objek mobil1 adalah objek dari kelas Mobil, sehingga kita dapat mengakses metode Start() yang didefinisikan dalam kelas tersebut.
*/
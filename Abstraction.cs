// Abstraction

using System;

public abstract class Kendaraan
{
    public abstract void Start();
}

public class Mobil : Kendaraan
{
    public override void Start()
    {
        Console.WriteLine("Mobil telah dinyalakan");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Mobil mobil1 = new Mobil();
        mobil1.Start();
    }
}

/*
Keterangan: Program ini menunjukkan konsep abstraction dengan menggunakan kelas abstrak Kendaraan yang memiliki metode abstrak Start(). Kelas abstrak tidak dapat diinstansiasi langsung, tetapi harus diwarisi oleh kelas turunan. Dalam contoh ini, kita membuat objek mobil1 dari kelas Mobil yang mewarisi kelas Kendaraan dan mengimplementasikan metode Start() sesuai dengan kebutuhan.
*/
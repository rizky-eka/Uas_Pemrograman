// Polymorphism

using System;

public class Kendaraan
{
    public virtual void Start()
    {
        Console.WriteLine("Kendaraan telah dinyalakan");
    }
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
        Kendaraan kendaraan = new Kendaraan();
        kendaraan.Start();

        Mobil mobil1 = new Mobil();
        mobil1.Start();

        Kendaraan mobil2 = new Mobil();
        mobil2.Start();
    }
}

/*
Keterangan: Program ini menunjukkan konsep polymorphism dengan menggunakan metode Start() yang dioverride pada kelas turunan. Di dalam metode Main(), kita membuat objek kendaraan dari kelas Kendaraan, objek mobil1 dari kelas Mobil, dan objek mobil2 dari kelas Mobil yang disimpan dalam referensi Kendaraan. Saat memanggil metode Start(), perilaku metode akan berbeda sesuai dengan jenis objek yang dipanggil. Ini menunjukkan kemampuan objek yang sama untuk mengambil banyak bentuk.
*/
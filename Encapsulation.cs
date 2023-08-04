
using System;

class Biodata
{
    // Properti Nama menggunakan Auto-implemented Properties
    public string Nama { get; set; }
    
    // Properti Umur menggunakan Auto-implemented Properties
    public int Umur { get; set; }
    
    // Properti Alamat menggunakan Auto-implemented Properties
    public string Alamat { get; set; }

    // Constructor untuk menginisialisasi objek Biodata dengan nilai yang valid
    public Biodata(string nama, int umur, string alamat)
    {
        Nama = nama;
        Umur = umur;
        Alamat = alamat;
    }

    // Metode untuk menampilkan informasi biodata
    public void DisplayInfo()
    {
        Console.WriteLine($"Nama: {Nama}");
        Console.WriteLine($"Umur:{Umur}")
        Console.WriteLine($"Alamat: {Alamat}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek biodata dan menginisialisasinya dengan nilai menggunakan constructor initializer
        var biodata = new Biodata("Rizky Eka Haryadi", 20, "Bekasi");
        
        // Memanggil metode DisplayInfo() untuk menampilkan informasi biodata
        biodata.DisplayInfo();
    }
}

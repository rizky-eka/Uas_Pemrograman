using System;

namespace TransportationApp
{
    // Deklarasi kelas Tiket
    class Tiket
    {
        // Properti Nama untuk menyimpan nama pengguna
        public string Nama { get; set; }

        // Properti NIK untuk menyimpan nomor identitas pengguna
        public string NIK { get; set; }

        // Properti NomorTelepon untuk menyimpan nomor telepon pengguna
        public string NomorTelepon { get; set; }

        // Properti NomorKartuVaksin untuk menyimpan nomor kartu vaksin pengguna
        public string NomorKartuVaksin { get; set; }

        // Properti AlamatRumah untuk menyimpan alamat rumah pengguna
        public string AlamatRumah { get; set; }

        // Konstruktor Tiket untuk inisialisasi objek dengan data pengguna yang diberikan
        public Tiket(string nama, string nik, string nomorTelepon, string nomorKartuVaksin, string alamatRumah)
        {
            Nama = nama;
            NIK = nik;
            NomorTelepon = nomorTelepon;
            NomorKartuVaksin = nomorKartuVaksin;
            AlamatRumah = alamatRumah;
        }

        // Metode PesanTiket untuk meminta pengguna memasukkan data pribadi mereka
        public static Tiket PesanTiket()
        {
            // Menampilkan pesan selamat datang dan instruksi
            Console.WriteLine("Selamat datang di Aplikasi Pemesanan Tiket Pesawat");
            Console.WriteLine("Silakan masukkan data Anda.");

            // Meminta pengguna memasukkan Nama dan menyimpannya dalam variabel nama
            Console.Write("Masukkan Nama: ");
            string nama = Console.ReadLine();

            // Meminta pengguna memasukkan NIK dan menyimpannya dalam variabel nik
            Console.Write("Masukkan NIK: ");
            string nik = Console.ReadLine();

            // Meminta pengguna memasukkan NomorTelepon dan menyimpannya dalam variabel nomorTelepon
            Console.Write("Masukkan Nomor Telepon: ");
            string nomorTelepon = Console.ReadLine();

            // Meminta pengguna memasukkan NomorKartuVaksin dan menyimpannya dalam variabel nomorKartuVaksin
            Console.Write("Masukkan Nomor Kartu Vaksin: ");
            string nomorKartuVaksin = Console.ReadLine();

            // Meminta pengguna memasukkan AlamatRumah dan menyimpannya dalam variabel alamatRumah
            Console.Write("Masukkan Alamat Rumah: ");
            string alamatRumah = Console.ReadLine();

            // Membuat objek Tiket dengan data pengguna yang diberikan
            Tiket tiket = new Tiket(nama, nik, nomorTelepon, nomorKartuVaksin, alamatRumah);

            // Menampilkan pesan terima kasih dan data pemesanan tiket pengguna
            Console.WriteLine("\nTerima kasih! Berikut adalah data pemesanan tiket Anda:");
            Console.WriteLine($"Nama: {tiket.Nama}\nNIK: {tiket.NIK}\nNomor Telepon: {tiket.NomorTelepon}\nNomor Kartu Vaksin: {tiket.NomorKartuVaksin}\nAlamat Rumah: {tiket.AlamatRumah}");

            // Mengembalikan objek tiket
            return tiket;
        }
    }

    // Deklarasi kelas Program
    class Program
    {
        // Metode utama
        static void Main(string[] args)
        {
            // Memanggil metode PesanTiket dan menyimpan hasilnya dalam variabel tiket
            Tiket tiket = Tiket.PesanTiket();
        }
    }
}

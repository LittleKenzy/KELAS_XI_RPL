using System;

namespace Tugas1
{
    class Kalkulator
    {
        public static int Tambah(int a, int b)
        {
            return a + b;
        }

        public static int Kurang(int a, int b)
        {
            return a - b;
        }

        public static int Kali(int a, int b)
        {
            return a * b;
        }

        public static double Bagi(double a, double b)
        {
            return a / b;
        }
    }

    class BangunDatar
    {
        public double LuasPersegi(double sisi)
        {
            return sisi * sisi;
        }

        public double LuasPersegiPanjang(double panjang, double lebar)
        {
            return panjang * lebar;
        }

        public double LuasSegitiga(double alas, double tinggi)
        {
            return 0.5 * alas * tinggi;
        }
    }

    class BangunRuang
    {
        public double VolumeKubus(double sisi)
        {
            return sisi * sisi * sisi;
        }

        public double VolumeBalok(double panjang, double lebar, double tinggi)
        {
            return panjang * lebar * tinggi;
        }

        public double VolumeTabung(double jariJari, double tinggi)
        {
            return 3.14 * jariJari * jariJari * tinggi;
        }
    }

    class Zodiak
    {
        public string CekZodiak(int tanggal, int bulan)
        {
            if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19)) return "Aries";
            if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20)) return "Taurus";
            if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20)) return "Gemini";
            if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22)) return "Cancer";
            if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22)) return "Leo";
            if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22)) return "Virgo";
            if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22)) return "Libra";
            if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21)) return "Scorpio";
            if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21)) return "Sagittarius";
            if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19)) return "Capricorn";
            if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18)) return "Aquarius";
            if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20)) return "Pisces";
            return "Tanggal tidak valid";
        }
    }

    class Menu
    {
        public static void TampilkanMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== MENU UTAMA TUGAS 1 ===");
                Console.WriteLine("1. Kalkulator");
                Console.WriteLine("2. Hitung Bangun Datar");
                Console.WriteLine("3. Hitung Bangun Ruang");
                Console.WriteLine("4. Cek Zodiak");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih menu (1-5): ");

                string pilihan = Console.ReadLine();
                Console.Clear();

                if (pilihan == "1")
                {
                    Console.WriteLine("=== HALAMAN KALKULATOR ===");
                    Console.WriteLine("10 + 5 = " + Kalkulator.Tambah(10, 5));
                    Console.WriteLine("10 - 5 = " + Kalkulator.Kurang(10, 5));
                    Console.WriteLine("10 * 5 = " + Kalkulator.Kali(10, 5));
                    Console.WriteLine("10 / 5 = " + Kalkulator.Bagi(10, 5));
                }
                else if (pilihan == "2")
                {
                    Console.WriteLine("=== HALAMAN BANGUN DATAR ===");
                    BangunDatar hitungDatar = new BangunDatar();
                    Console.WriteLine("Luas Persegi (sisi 5) = " + hitungDatar.LuasPersegi(5));
                    Console.WriteLine("Luas Persegi Panjang (10x4) = " + hitungDatar.LuasPersegiPanjang(10, 4));
                    Console.WriteLine("Luas Segitiga (alas 6, tinggi 8) = " + hitungDatar.LuasSegitiga(6, 8));
                }
                else if (pilihan == "3")
                {
                    Console.WriteLine("=== HALAMAN BANGUN RUANG ===");
                    BangunRuang hitungRuang = new BangunRuang();
                    Console.WriteLine("Volume Kubus (sisi 4) = " + hitungRuang.VolumeKubus(4));
                    Console.WriteLine("Volume Balok (6x4x3) = " + hitungRuang.VolumeBalok(6, 4, 3));
                    Console.WriteLine("Volume Tabung (r 7, tinggi 10) = " + hitungRuang.VolumeTabung(7, 10));
                }
                else if (pilihan == "4")
                {
                    Console.WriteLine("=== HALAMAN CEK ZODIAK ===");
                    Console.Write("Masukkan tanggal lahir: ");
                    int tgl = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan bulan lahir (angka 1-12): ");
                    int bln = int.Parse(Console.ReadLine());

                    Zodiak cek = new Zodiak();
                    Console.WriteLine("Zodiak Anda adalah: " + cek.CekZodiak(tgl, bln));
                }
                else if (pilihan == "5")
                {
                    break;
                }

                Console.WriteLine("\nTekan ENTER untuk kembali ke Menu Utama...");
                Console.ReadLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Menu.TampilkanMenu();
        }
    }
}

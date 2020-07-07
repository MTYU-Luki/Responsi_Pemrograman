using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = " Responsi UAS Matakuliah Pemrograman ";

            while (true)
            {
                TampilMenu();

                Console.Write("\n Nomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu

            Console.WriteLine(" Pilih Menu Aplikasi\n ");
            Console.WriteLine(" 1. Tambah Penjualan ");
            Console.WriteLine(" 2. Hapus Penjualan ");
            Console.WriteLine(" 3. Tampilkan Penjualan ");
            Console.WriteLine(" 4. Keluar ");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection

            Penjualan penjualan = new Penjualan();
            Console.WriteLine(" Tambah Data Penjualan \n");

            Console.Write(" Nota : ");
            penjualan.Nota = Console.ReadLine();

            Console.Write(" Tanggal : ");
            penjualan.Date = Console.ReadLine();

            Console.Write(" Customer : ");
            penjualan.Customer = Console.ReadLine();

            Console.Write(" Jenis [T/K] : ");
            penjualan.Jenis = Console.ReadLine();

            Console.Write(" Total Nota : Rp ");
            penjualan.Total = Convert.ToInt32(Console.ReadLine());

            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\n Tekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine(" Hapus Data Customer \n");

            Console.Write(" Kode Customer : ");
            string nota = Console.ReadLine();

            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                if (daftarPenjualan[i].Nota == nota)
                {
                    daftarPenjualan.Remove(daftarPenjualan[i]);
                    Console.WriteLine("\n Data Penjualan berhasil di hapus");
                }
                else
                {
                    Console.WriteLine("\n Nota tidak ditemukan ");
                }
            }

            Console.WriteLine("\n Tekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine(" Data Penjualan \n");

            int noUrut = 1;

            foreach (Penjualan penjualan in daftarPenjualan)
            {
                string jenis ="0";
                if (penjualan.Jenis == "T" || penjualan.Jenis == "t")
                {
                    jenis = " Tunai";

                }
                else if (penjualan.Jenis == "K" || penjualan.Jenis == "k")
                {
                    jenis = " Kredit";
                }
                Console.WriteLine(" {0}. Nota: {1}, Tanggal: {2}, Customer: {3}, Jenis: {4}, Total Nota: Rp {5:n0}", noUrut, penjualan.Nota, penjualan.Date, penjualan.Customer, jenis , penjualan.Total);

                noUrut++;
            }

            Console.WriteLine("\n Tekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t, y, u, nim;
            Console.Write("Masukan NIM: ");
            nim = int.Parse(Console.ReadLine());
            Console.Write("t = ");
            t = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());
            Console.Write("u = ");
            u = int.Parse(Console.ReadLine());

            Penjumlahan jumlah = new Penjumlahan();
            SimpleDatabase<int> database = new SimpleDatabase<int>();

            jumlah.JumlahTigaAngka<int>(t, y, u);

            database.AddNewdata(t);
            database.AddNewdata(y);
            database.AddNewdata(u);
            database.PrintAlldata();

        }
    }
    public class Penjumlahan
    {
        public void JumlahTigaAngka<T>(int a, int b, int c)
        {
            int hasil = a + b + c;
            Console.WriteLine(hasil);
        }
    }
    public class SimpleDatabase<T>
    {
        List<T>? berkastersimpan;
        List<DateTime>? waktu;
        public SimpleDatabase()
        {
            berkastersimpan = new List<T>();
            waktu = new List<DateTime>();
        }
        public void AddNewdata(T berkas)
        {
            berkastersimpan.Add(berkas);
            waktu.Add(DateTime.Now);
        }
        public void PrintAlldata()
        {
            foreach(var berkas in berkastersimpan)
            {
                Console.WriteLine(berkas);
            }
            foreach (var berkas in waktu)
            {
                Console.WriteLine(berkas);
            }

        }
    }
}

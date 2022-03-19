using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302202095
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan<Double> hitung = new Penjumlahan<Double>();
            Double a = 13.0;
            Double b = 02.0;
            Double c = 20.0;
            Double jumlah = a + b + c;
            hitung.JumlahTigaAngka(jumlah);
        }
    }
    public class Penjumlahan<T>
    {
        public void JumlahTigaAngka(T jumlah)
        {
            Console.WriteLine("Jumlah dari 13 + 02 + 20 = " + jumlah);
        }
    }
}
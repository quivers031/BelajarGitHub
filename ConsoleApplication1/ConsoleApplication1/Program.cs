using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prgram Mencari Mean, Median, Range Gaji Karyawan");
            Console.Write("Berapa Karyawan : ");
            int b = Convert.ToInt32(Console.ReadLine());
            string[] nama = new string[b];
            int n = 100;
            string[,] gaji = new string[b, n];
            int[,] gaji2 = new int[b, n];
            int[] baginya = new int[b];
            for (int i = 0; i < b; i++)
            {
                n = 100;
                Console.Write("Nama Karyawan : ");
                nama[i] = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Gaji Bulan ke - " + (j + 1) + " : ");
                    gaji[i, j] = Console.ReadLine();
                    if (gaji[i, j] == "selesai" || gaji[i, j] == "Selesai")
                    {
                        baginya[i] = j;
                        n = j;
                    }
                    else
                    {
                        gaji2[i, j] = Convert.ToInt32(gaji[i, j]);
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("Nama Karyawan : " + nama[i]);
                Console.Write("Gaji Rata-rata selama bekerja : ");
                double rata2 = 0;
                for (int j = 0; j < baginya[i]; j++)
                {
                    rata2 = rata2 + gaji2[i, j];
                }
                rata2 = rata2 / baginya[i];
                Console.WriteLine(rata2);
                Console.Write("Tengah Gaji selama bekerja : ");
                for (int j = 0; j < baginya[i]; j++)
                {
                    int t = j++;
                    if (gaji2[i, j] > gaji2[i, t])
                    {
                        int g = gaji2[i, j];
                        gaji2[i, j] = gaji2[i, t];
                        gaji2[i, t] = g;
                    }
                }
                if (baginya[i] % 2 == 1)
                {
                    int med = baginya[i] / 2;
                    Console.Write(gaji2[i, med]);
                }
                else
                {
                    int med = baginya[i] / 2;
                    int untmed = med + 1;
                    med = gaji2[i, med] + gaji2[i, untmed];
                    med = med / 2;
                    Console.Write(med);
                }
                Console.WriteLine();
            }

        }
    }
}

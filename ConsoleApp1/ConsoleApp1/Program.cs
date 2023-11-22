using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Matrisin kare Boyutunu Giriniz: ");
           int N = Convert.ToInt32(Console.ReadLine());          
            int[,]bir = new int[N, N]; 
            int[,] iki = new int[N, N];  
            int[,] Sonuc = new int[N, N];
            Console.WriteLine("<-- 1. Matris -->");
            for (int i = 0; i < N; i++)
            {
                for (int k = 0; k < N; k++)
                {
                    Console.Write("1.Matrisin " + k + ". Elemanı: ");
                   bir[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("<-- 2. Matris -->");
            for (int i = 0; i < N; i++)
            {
                for (int k = 0; k < N; k++)
                {
                    Console.Write("2.Matrisin " + k + ". Elemanı: ");
                    iki[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            }
           
            for (int i = 0; i < N; i++)
            {
                for (int k = 0; k < N; k++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Sonuc[i, k] +=bir[i, j] * iki[j, k];
                    }
                }
            }
            Console.WriteLine("<---Matrislerin Çarpımlarının Sonucu--->");
            for (int i = 0; i < N; i++)
            {
                for (int k = 0; k < N; k++)
                {

                    Console.Write(Sonuc[i, k]);
                    Console.Write(" ");


                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
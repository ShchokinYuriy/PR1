using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class NumbersOfDiapasone{
        private int[] arr;
        private int n;
        private Random random = new Random();


        public NumbersOfDiapasone(int[] arr, int n)
        {
            this.arr = arr;
            this.n = n;
        }


        public void RandomArr()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }
        }

        public void CheckDiapasone()
        {
            foreach (int value in arr)
            {
                if (value > 0 && value < n)
                {
                    Console.WriteLine(value + "true");
                }
                else
                {
                    Console.WriteLine(value + "False");
                }
            }
        }
    }

    class Tringle{}

    class BigArray{}

    class ArrayFilter{}

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("print");
        }
    }
}

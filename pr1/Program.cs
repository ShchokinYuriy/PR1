using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class NumbersOfDiapasone{}

    class Tringle{
    
    }

    class BigArray{
        private int[] arr;//private array
        private Random random = new Random();

        public BigArray(int[] arr)//class constructor
        {
            this.arr = arr;
        }

        public void GenerateArray()
        {

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, arr.Length);

            }
        }
        public void ShowArray()
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public void ShowMin()
        {
            int min = 100;
            foreach (int i in arr)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine("minimal number = " + min);
        }
        public void ShowMax()
        {
            int max = 0;
            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            Console.WriteLine("maximal number = " + max);
        }




    }

    class ArrayFilter{}

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("print");
        }
    }
}

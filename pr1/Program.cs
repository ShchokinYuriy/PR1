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

<<<<<<< HEAD
    class Tringle
    {
        private int[] arr;//private array

        public Tringle(int[] arr)//class constructor
        {
            this.arr = arr;

        }

        public void CheackTringle()
        {
            if (arr[0] + arr[1] > arr[2] && arr[0] + arr[2] > arr[1] && arr[1] + arr[2] > arr[0])
            {
                Console.WriteLine("Tringle is tringle :)");
            }
            else
            {
                Console.WriteLine("Tringle is not tringle :(");
            }
        }
        public void TringleP()//P tringle
        {
            if (arr[0] + arr[1] > arr[2] && arr[0] + arr[2] > arr[1] && arr[1] + arr[2] > arr[0])
            {
                float P = 0;
                foreach (int i in arr)
                {
                    P += i;
                }
                Console.WriteLine("P=" + P);
            }
            else
            {
                Console.WriteLine("ERROR!!!ERROR!!!ERROR!!!ERROR!!!ERROR!!!ERROR!!!");
            }
        }
        public void TringleS()//S tringle
        {
            if (arr[0] + arr[1] > arr[2] && arr[0] + arr[2] > arr[1] && arr[1] + arr[2] > arr[0])
            {
                float S = 0;
                foreach (int i in arr)
                {
                    S += i;
                }
                S /= 2;
                S = (float)Math.Sqrt(S * (S - arr[0]) * (S - arr[1]) * (S - arr[2]));
                Console.WriteLine("S=" + S);
            }
            else
            {
                Console.WriteLine("ERROR!!!ERROR!!!ERROR!!!ERROR!!!ERROR!!!ERROR!!!");
            }
        }
    }

    class BigArray{
    
=======
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




>>>>>>> class3
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

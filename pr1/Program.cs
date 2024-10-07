using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    interface ITask
    {
        void Execute();
    }

    class NumbersOfDiapasone : ITask
    {
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
                Console.WriteLine(value + (value > 0 && value < n ? " true" : " false"));
            }
        }

        // Реалізація методу Execute з інтерфейсу
        public void Execute()
        {
            RandomArr();
            CheckDiapasone();
        }
    }

    class Tringle : ITask
    {
        private int[] arr;

        public Tringle(int[] arr)
        {
            this.arr = arr;
        }

        public void CheackTringle()
        {
            if (arr[0] + arr[1] > arr[2] && arr[0] + arr[2] > arr[1] && arr[1] + arr[2] > arr[0])
            {
                Console.WriteLine("Tringle is valid :)");
            }
            else
            {
                Console.WriteLine("Tringle is not valid :(");
            }
        }

        public void TringleP()
        {
            if (arr[0] + arr[1] > arr[2] && arr[0] + arr[2] > arr[1] && arr[1] + arr[2] > arr[0])
            {
                float P = arr.Sum();
                Console.WriteLine("P = " + P);
            }
            else
            {
                Console.WriteLine("ERROR!!! ERROR!!!");
            }
        }

        public void TringleS()
        {
            if (arr[0] + arr[1] > arr[2] && arr[0] + arr[2] > arr[1] && arr[1] + arr[2] > arr[0])
            {
                float S = arr.Sum() / 2;
                S = (float)Math.Sqrt(S * (S - arr[0]) * (S - arr[1]) * (S - arr[2]));
                Console.WriteLine("S = " + S);
            }
            else
            {
                Console.WriteLine("ERROR!!! ERROR!!!");
            }
        }

        // Реалізація методу Execute з інтерфейсу
        public void Execute()
        {
            CheackTringle();
            TringleP();
            TringleS();
        }
    }

    class BigArray : ITask
    {
        private int[] arr;
        private Random random = new Random();

        public BigArray(int[] arr)
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
            int min = arr.Min();
            Console.WriteLine("Minimal number = " + min);
        }

        public void ShowMax()
        {
            int max = arr.Max();
            Console.WriteLine("Maximal number = " + max);
        }

        // Реалізація методу Execute з інтерфейсу
        public void Execute()
        {
            GenerateArray();
            ShowArray();
            ShowMin();
            ShowMax();
        }
    }

    class ArrayFilter : ITask
    {
        private int[] array;
        private int M;

        public ArrayFilter(int[] array, int M)
        {
            this.array = array;
            this.M = M;
        }

        public int[] FilterArray()
        {
            return array.Where(x => Math.Abs(x) > M).ToArray();
        }

        public void DisplayResults()
        {
            Console.WriteLine($"Threshold value M: {M}");
            Console.WriteLine("Array X:");
            Console.WriteLine(string.Join(" ", array));

            int[] Y = FilterArray();
            Console.WriteLine("Array Y:");
            Console.WriteLine(string.Join(" ", Y));
        }

        // Реалізація методу Execute з інтерфейсу
        public void Execute()
        {
            DisplayResults();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ініціалізація завдань
            int[] arr1 = new int[46];
            int n = 20;

            var numbersTask = new NumbersOfDiapasone(arr1, n);
            var triangleTask = new Tringle(new int[] { 3, 4, 5 });
            var bigArrayTask = new BigArray(arr1);
            var arrayFilterTask = new ArrayFilter(arr1, 10);

            // Список для зберігання завдань
            List<ITask> tasks = new List<ITask>
            {
                numbersTask,
                triangleTask,
                bigArrayTask,
                arrayFilterTask
            };

            // Виконання всіх завдань
            foreach (var task in tasks)
            {
                task.Execute();
                Console.WriteLine(); 
            }

        }
    }
}
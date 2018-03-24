using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program

    {

        public static int BinarySearch(int[] array, int value)

        {
            if (array.Length == 0)
                return -1;
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var middle = (right + left) / 2;
                if (value <= array[middle])
                    right = middle;
                else left = middle + 1;
            }
            if (array[right] == value)
                return right;
            return -1;

        }



        static void Main(string[] args)

        {

            TestNegativeNumbers();

            TestNonExistentElement();

            TestFindOneElementFromFive();

            TestSomeElement();

            TestEmptyNumbers();

            Test100001Numbers();



            Console.ReadKey();

        }



        private static void TestNegativeNumbers()

        {

            //Тестирование поиска в отрицательных числах

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            if (BinarySearch(negativeNumbers, -3) != 2)

                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");

        }

        private static void TestNonExistentElement()

        {

            //Тестирование поиска отсутствующего элемента

            int[] negativeNumbers = new[] { -5, -4, -3, -2 };

            if (BinarySearch(negativeNumbers, -1) >= 0)

                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");

            else

                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат работает корректно");

        }

        private static void TestFindOneElementFromFive()

        {

            //Тестирование поиска одного элемента в массиве из 5 элементов

            int[] fiveNumbers = new[] { 3, 12, 17, 18, 22 };

            if (BinarySearch(fiveNumbers, 12) != 1)

                Console.WriteLine("! Поиск не нашёл число 12 среди чисел { 3, 12, 17, 18, 22 }");

            else

                Console.WriteLine("Поиск одного элемента в массиве из 5 элементов работает корректно");

        }

        private static void TestSomeElement()

        {

            //Тестирование поиска элемента, повторяющегося несколько раз

            int[] fiveNumbers = new[] { 3, 3, 17, 18, 22 };

            if (BinarySearch(fiveNumbers, 3) !=0)

                Console.WriteLine("! Поиск нашел неправильный индекс повторяющегося числа 3 среди чисел { 3, 3, 17, 18, 22 }");

            else

                Console.WriteLine("Поиск элемента, повторяющегося несколько раз работает корректно");

        }

        private static void TestEmptyNumbers()

        {

            //Тестирование поиска в пустом массиве (содержащем 0 элементов)

            int[] emptyNumbers = new int [0];

            if (BinarySearch(emptyNumbers, 1) != -1)

                Console.WriteLine("! Поиск в пустом массиве (содержащем 0 элементов) работает некорректно");

            else

                Console.WriteLine("Поиск в пустом массиве (содержащем 0 элементов) работает корректно");

        }

        private static void Test100001Numbers()

        {

            //Тестирование поиска в массиве из 100001 элементов

            int[] array = new int[100001];

            Random rnd = new Random();
            for (int i=0;i<array.Length; i++)
            {
                array[i] = rnd.Next();
            }

            Array.Sort(array);

            int searchValue = array.Last();
            var foundIndex = BinarySearch(array, searchValue);
            if (array[foundIndex]!= searchValue)

                Console.WriteLine($"! Поиск не нашел число {searchValue} в большом массиве");

            else

                Console.WriteLine("Поиск в массиве из 100001 элементов работает корректно");

        }
    }
}

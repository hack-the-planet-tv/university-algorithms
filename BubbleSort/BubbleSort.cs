using System;

namespace HackThePlanet.UniversityAlgorithms
{
    public class BubbleSort : ISorter
    {
        // O(n^2)
        //int[] _array = { 9, 8, 7, 6, 5, 4, 3, 1, 2, 0 };
        //8 7 6 5 4 3 1 2 0 9
        //7 6 5 4 3 1 2 0 8 9
        //6 5 4 3 1 2 0 7 8 9
        //5 4 3 1 2 0 6 7 8 9
        //4 3 1 2 0 5 6 7 8 9
        //3 1 2 0 4 5 6 7 8 9
        //1 2 0 3 4 5 6 7 8 9
        //1 0 2 3 4 5 6 7 8 9
        //0 1 2 3 4 5 6 7 8 9

        int[] _array = { 9, 8, 7, 6, 5, 4, 3, 1, 2, 0 };

        public static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(String.Concat(item, " "));
            }
            Console.WriteLine();
        }

        public void Sort()
        {
            var length = _array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (_array[j] > _array[j + 1])
                    { 
                        Swap(ref _array[j], ref _array[j + 1]);
                    }

                }
#if DEBUG
                Print(_array);
#endif
            }

        }

        private void Swap(ref int v1, ref int v2)
        {
            int tmp;
            tmp = v1;
            v1 = v2;
            v2 = tmp;
        }
    }
}

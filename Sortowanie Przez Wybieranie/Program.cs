using System;

namespace SortowaniePrzezWybieranie
{
    class SelectionSort
    {
        private int[] data;
        private static Random generator = new Random();

  
        public SelectionSort(int size)
        {
            data = new int[size];

       
            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(1, 100);
            }
        }


        public void Sort()
        {
            Console.WriteLine("Tablica przed sortowaniem:");
            DisplayArray();

            for (int i = 0; i < data.Length - 1; i++)
            {
                int smallest = i;


                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[smallest])
                    {
                        smallest = index;
                    }
                }

                Swap(i, smallest);
            }

            Console.WriteLine("Tablica po sortowaniu:");
            DisplayArray();
        }

        private void Swap(int first, int second)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        }

   
        private void DisplayArray()
        {
            foreach (var element in data)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj rozmiar tablicy: ");
            int size = Convert.ToInt32(Console.ReadLine());

            SelectionSort selection = new SelectionSort(size);
            selection.Sort();
        }
    }
}

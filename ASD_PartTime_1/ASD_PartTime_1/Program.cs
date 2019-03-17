using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_PartTime_1
{
    class Program
    {

        static void ShellSort(int[] arr, int n)
        {
            int i, j, pos, temp;
            pos = 3;
            while (pos > 0)
            {
                for (i = 0; i < n; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= pos) && (arr[j - pos] > temp))
                    {
                        arr[j] = arr[j - pos];
                        j = j - pos;
                    }
                    arr[j] = temp;
                }
                if (pos / 2 != 0)
                    pos = pos / 2;
                else if (pos == 1)
                    pos = 0;
                else
                    pos = 1;
            }
        }

        static void SelectionSort(int[] arr)
        {
            int i, j, min;
            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                        Swap(ref arr[i], ref arr[min]);
                    }
                }
            }
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void InsertionSort(int[] arr)
        {
            int j, temp;
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }

        // Quick sort
        static void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        static int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }


        // Bubble Sort
        static void BubbleSort(int[] arr)
        {
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
        }

        // Sentences count
        static int SentencesCount(string text)
        {
            var translateArraySourceTexts = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            return translateArraySourceTexts.Length;
        }

        // Words count
        static int WordsCount(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            var count = 0;
            var word = false;

            foreach (char symbol in text)
            {
                Console.WriteLine("Letter: " + symbol);

                if (!char.IsLetter(symbol))
                {
                    Console.WriteLine("not aletter");
                    word = false;
                    continue;
                }

                if (word)
                {
                    Console.WriteLine("word aletter");
                    continue;
                }


                Console.WriteLine("count++");
                count++;
                word = true;
            }

            return count;
        }


        // Longest word in string
        static string LongestWordSplit(string text)
        {
            string[] words = text.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
            return word;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SentencesCount("dfgdfg fdgdfg dfgdf. fdsfsdfsd. fsdfsdfsdfd dsfsdfsdfds."));
        }
    }
}

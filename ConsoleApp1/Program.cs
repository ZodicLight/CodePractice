using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace bubbleSort
{
    class Program
    {
        static void Main()
        {
            int[] unsortedList = { 0, 4, 3, 1, 10, 7 };// Why I keep forget about array?
            int testOG = 0;//how to pass by reference and value 

            foreach (int items in unsortedList)
            {
                Console.WriteLine(items);
            }

            bubbleSort bubble = new bubbleSort();
            bubble.BubbleSort(unsortedList, testOG);//still the same?

            //Console.ReadLine();

            foreach (int items in unsortedList)//reference issues?
            {
                Console.WriteLine(items);
            }

            //Console.WriteLine("testOG: " + testOG);
            //Console.ReadLine();
        }


        //class bubbleSort//Class within a class? How does that work? Why?
        //{
        //    public void BubbleSort(int[] unsortedList)
        //    {
        //        int temp;

        //        for (int i = 0; i < unsortedList.Length - 1; i++)
        //        {
        //            for (int j = 0; j < unsortedList.Length - (1 + i); j++)
        //            {
        //                if (unsortedList[j] > unsortedList[j + 1])
        //                {
        //                    temp = unsortedList[j + 1];
        //                    unsortedList[j + 1] = unsortedList[j];
        //                    unsortedList[j] = temp;

        //                }

        //            }
        //        }
        //    }
        //}


        //public static void BubbleSort(int[] unsortedList)
        //{
        //    int temp;

        //    for (int i = 0; i < unsortedList.Length-1; i++)
        //    {
        //        for (int j = 0; j < unsortedList.Length-(1 + i); j++)
        //        {
        //            if (unsortedList[j] > unsortedList[j+1])
        //            {
        //                temp = unsortedList[j + 1];
        //                unsortedList[j + 1] = unsortedList[j];
        //                unsortedList[j] = temp;

        //            }

        //        }
        //    }
        //}
    }

    class bubbleSort
    {
        //pass by reference? 

        public void BubbleSort(int[] unsortedList, int testOG)
        {
            int temp;

            for (int i = 0; i < unsortedList.Length - 1; i++)// -1 will prevent the program crash but will it skip a loop and return incomplete result?
            {
                Console.WriteLine("i: " + i);

                for (int j = 0; j < unsortedList.Length - (1 + i); j++)
                {
                    Console.WriteLine("i2: " + i);

                    if (unsortedList[j] > unsortedList[j + 1])
                    {
                        temp = unsortedList[j + 1];
                        unsortedList[j + 1] = unsortedList[j];
                        unsortedList[j] = temp;

                    }

                }
            }

            //testOG = testOG + 2;

            //Console.WriteLine("testOG Inside Class BubbleSort: " + testOG);
        }
    }   

}

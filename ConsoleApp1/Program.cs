using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;


namespace bubbleSort
{
    //How to Measure Code Execution Time In C#
    //https://www.youtube.com/watch?v=KfpqlX57kuI

    class Program
    {
        static void Main()
        {
            Stopwatch MyTimer = new Stopwatch();
            
            //int[] unsortedList = { 0, 4, 3, 1, 10, 7 };// Why I keep forget about array?
            //int[] unsortedList = { 10, 4, 3, 1, 7, 0 };// Why I keep forget about array?
            //int[] unsortedList = { 2, 7, 4, 1, 5, 3};
            int[] unsortedList = { 1, 2, 3, 4, 5, 6 };
            int testOG = 0;//how to pass by reference and value 

            MyTimer.Start();

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

            MyTimer.Stop();
            //Console.WriteLine("testOG: " + testOG);
            //Console.ReadLine();
            Console.WriteLine("time taken: " + MyTimer.Elapsed);
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
            int count = 0;

            for (int i = 0; i < unsortedList.Length - 1; i++)// -1 will prevent the program crash but will it skip a loop and return incomplete result?
            {
                //Console.WriteLine();
                //Console.WriteLine("i outside forLoop: " + i);
                //Console.WriteLine("Length: " + unsortedList.Length);

                for (int j = 0; j < unsortedList.Length - (1 + i); j++)//2 + 1 length go 
                {
                    //Console.WriteLine();
                    //int forLoopLen = unsortedList.Length - (1 + i);
                    //int forLoopLen = unsortedList.Length;
                    //Console.WriteLine("i inside forLoop: " + i);
                    //Console.WriteLine("j: " + j);
                    //Console.WriteLine("length: " + forLoopLen);

                    if (unsortedList[j] > unsortedList[j + 1])//compare to the next one
                    {

                        temp = unsortedList[j + 1];
                        unsortedList[j + 1] = unsortedList[j];
                        unsortedList[j] = temp;

                        //Console.WriteLine("temp ifLoop: " + temp);

                        //Console.WriteLine("unsort[1] ifLoop: " + unsortedList[1]);
                        //Console.WriteLine("unsort[2] ifLoop: " + unsortedList[2]);
                        //Console.WriteLine("unsort[3] ifLoop: " + unsortedList[3]);
                        //int[] unsortedList = { 0, 4, 3, 1, 10, 7 }; 0, 1, 3, 4, 7, 10
                        count = count + 1;
                    }

                }
            }

            //testOG = testOG + 2;
            Console.WriteLine("Count: " + count);
            //Console.WriteLine("testOG Inside Class BubbleSort: " + testOG);
        }
    }

}

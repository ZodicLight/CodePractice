﻿using System; //what is system? namespace. Interact with OS include "Console". Kinda like a shortcut 
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//look into what those class do above



public class Program 
{

    public static void Main(string[] args)
    {

        int N = 4;
        int temp = 0;
        int mod = 0;
        
        //int[] step = { 1, 2 };
        //1,1,2
        //2,2 <- find
        //2,1,1
        //1,1,1,1 <- find

        //int[] step = { 2, 3 };
        //2,2
        //remainer 

        //int[] step = { 1, 2, 3 };
        //??

        int[] step = { 1, 2, 3, 4 };//what happen to zero steps?

        Console.WriteLine("N: " + N);

        for (int i = 0; i < step.Length; i++)
        {
            //Console.WriteLine(step[i]);
            //Console.WriteLine("i: " + i);
            
            Console.WriteLine("step[i]: " + step[i]);

            //temp = N / step[i];
            mod =  N%step[i];// find one type of solution 

            //1,1,2 & 2,1,1 solution
            //N-Step[1] 
            //N-Step[2]

            Console.WriteLine("mod: " + mod);
            
            //if mod is not Zero then do find a number in step[] that fit, in this case will be 1, so it will be 3,1 then mirror it 1,3 
            //2,1,1 or 1,1,2 
            //1,2,1 

            //first sort the list 

            //start with 1
            //1+2+3 bigger then N
            //1+2+1 bigger than N then go backward, if it will Mod remain zero, we have a winner
            //mirror it , if is the same then just one answer 
            
            //start with 2
            //2 + 3 is bigger than N, so stop than go backward
            //2 + 1 is smaller than N, so add another 1 
            //2 + 1 + 1 is equal to N and Mod is 0 then mirror it 

            //start with 3
            //3 + 4 is bigger than N, so go backward
            //3 + 2 is bigger than N, so go backward
            //3 + 1 is equal to N and mod is 0, winner 


            if(step[1] + step[1+1] == N)
            {
                Answer[] = step[1] = step[1 + 1];//how to put this into a set?
            }
            else if(step[1] + step[1 + 1) > N)
            {
                //then go backward 
            } 






        }

        //Console.WriteLine(N);


    }

}


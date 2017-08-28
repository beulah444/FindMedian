using System;
using System.Collections.Generic;
using System.Linq;
    class Program
    {
    static void Main()
    {
        List<int> listInt = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Initial list of integers");
        PrintList(listInt);
        Console.WriteLine("Median is {0}", FindMedian(listInt));
        string strUserDecision = string.Empty;
        do
        {
            Console.WriteLine("enter a  number to add");
            bool isNum = int.TryParse(Console.ReadLine(), out int result);
            if (isNum)
            {
                AddNum(listInt, result);
                Console.WriteLine("After adding number {0} the new list of integers",result);
                PrintList(listInt);
                Console.WriteLine("Median is {0}", FindMedian(listInt));
                do
                {
                    Console.WriteLine("Do you want to add new number? YES or NO");
                    strUserDecision = Console.ReadLine().ToUpper();
                } while (strUserDecision != "YES" && strUserDecision != "NO");
            } 
        
        } while (strUserDecision == "YES");
    }
    static void AddNum(List<int> listInt ,int i)
    {
        listInt.Add(i);
    }
    static double FindMedian(List<int> listInt)
    {
        double median;
        //put all the numbers in numeric order by sorting
        listInt.Sort();
        //if total count is odd median is middle number 
        //else median is the average of middle two numbers
        if (listInt.Count % 2 == 0)
            median =(double) (listInt[listInt.Count / 2] + listInt[(listInt.Count / 2) - 1]) / 2;
        else
            median = listInt[listInt.Count / 2];
        return median;
        //int[] arr=  listInt.ToArray();
        //  Array.Sort(arr);
        //if(arr.Length % 2 ==0)
        //{
        //    median =(double) (arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2;
        //}
        //else
        //{
        //    median = arr[arr.Length / 2];

        //}
        //return median;


    }
    static void PrintList(List<int> listInt)
    {
        foreach(int i in listInt)
        {
            Console.WriteLine(i);
        }
    }
    }


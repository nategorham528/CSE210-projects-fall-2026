using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int listNum = 100;
        List<int> numbers = new List<int>();
        int total = 0;
        int largestNum = 0;

        while(listNum != 0){
            
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            listNum = int.Parse(number);
            
            if(listNum != 0){
                numbers.Add(listNum);
            }
        }
        for (int i = 0; i < numbers.Count; i++){
            total = total + numbers[i];
            if(largestNum < numbers[i])
            {
                largestNum = numbers[i];
            }
        }

        Console.WriteLine($"The sum is: {total}");
        float average = (float)total / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
        
    }

}
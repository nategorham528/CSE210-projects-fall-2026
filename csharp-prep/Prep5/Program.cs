using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userYear = PromptUserBirthYear();
        int userNumSquare = SquareNumber(userNumber);
        DisplayResult(userName,userNumSquare,userYear);

    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        string favNum = Console.ReadLine();
        int favInt = int.Parse(favNum);
        return favInt;
    }

    static int PromptUserBirthYear(){
        Console.Write("Please enter your birth year: ");
        string birthYear = Console.ReadLine();
        int intYear = int.Parse(birthYear);
        return intYear;
    }

    static int SquareNumber(int number){
        int squareNum = number * number;
        return squareNum;
    }

    static void DisplayResult(string name, int number, int year){
        Console.WriteLine($"{name}, the square of your number is {number}.");
        Console.WriteLine($"{name}, you will turn {2026 - year} this year.");
    }
}
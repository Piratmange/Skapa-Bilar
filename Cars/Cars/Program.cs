using System;


class Program
{

    public static void Main()
    {
        string bitch = " ";
        Console.WriteLine("What is your girlfriends age?");
        bitch = Console.ReadLine();
        Console.Clear();

        string money = " ";
        Console.WriteLine("What is your monthly salary?");
        money = Console.ReadLine();
        Console.Clear();

        string car = " ";
        Console.WriteLine("What car do you own?");
        car = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Your girlfriend age is " + bitch + " and a " + car + "and you make " + money + " a month");
    }
}


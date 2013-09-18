using System;


class Program
{

    public static void Main()
    {
        

        string bitch = " ";
        int bitchInt;
        Console.WriteLine("What is your girlfriends age?");
        bitch = Console.ReadLine();
        bitchInt = Convert.ToInt32(bitch);
        Console.Clear();

        string money = " ";
        Console.WriteLine("What is your monthly salary?");
        money = Console.ReadLine();
        Console.Clear();

        string car = " ";
        Console.WriteLine("What car do you own?");
        car = Console.ReadLine();
        Console.Clear();

        Console.WriteLine(bitchInt > 25 ? "Lose" : "win"); 

        Console.WriteLine("Your girlfriends age is " + bitch + " and you drive a " + car + "and you make " + money + " a month");
    }
}


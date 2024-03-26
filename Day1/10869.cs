using System;

class MainClass {

    static void Main(string[] args)
    {
        string[] N = Console.ReadLine().Split();

        Console.WriteLine(int.Parse(N[0]) + int.Parse(N[1]));
        Console.WriteLine(int.Parse(N[0]) - int.Parse(N[1]));
        Console.WriteLine(int.Parse(N[0]) * int.Parse(N[1]));
        Console.WriteLine(double.Parse(N[0]) / double.Parse(N[1]));
        Console.WriteLine(double.Parse(N[0]) % double.Parse(N[1]));

    }
   }


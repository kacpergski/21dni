using System;
using System.Collections.Generic;

namespace ChallenegeApp
{
    class Program
    {
        static void Main(string[] args)
        {

        var numbers = new List<double>() {3.5, 23.13, 1.33};
        double result = 0.0;
        string name = "Adam";
        Employee employee = new Employee(name);
        employee.AddGrade(22.2);

        foreach( var number in numbers)
        {
            result += number;

           Console.WriteLine(number);     
        }
        Console.WriteLine($"Sum is: {result}");
        result /= numbers.Count;

        Console.WriteLine($"Average is: {result}");
        // { 
        //     var numbers = new numbers [3];

        //     int a = 10;
        //     int b = 3;
        //     int result = a + b;
        //     var name = "Adam";

        //     if(args.Length > 0)
        //     {
        //     Console.WriteLine($"Hello World!{args[0]}");
        //     }
        //     else
        //     {
        //     Console.WriteLine(args[0]);
        //     Console.WriteLine($"Hello World!{args[0]}");
        //     }
        // }
    }
    }
}

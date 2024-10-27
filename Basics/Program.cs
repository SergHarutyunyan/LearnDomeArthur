using Methods;
using Methods.Animals;
using Methods.Cars;
using System;
using System.Collections.Generic;

namespace Basicsaaaaa;

public class Program
{
    public static void Main(string[] args)
    {
        //Animal a1 = new Dog();
        //Animal a2 = new Cat();

        //var animals = new List<Animal>();

        //animals.Add(new Dog());
        //animals.Add(new Cat());

        //foreach (var animal in animals)
        //{
        //    animal.MakeSound();    
        //}

        string b = "asd";
        b = "GGGG";

        var a = new BMW();
        a.A = 1;

        for (int i = 0; i < 10; i++)
        {

        }

        int[] arr = new int[5];

        List<int> bb = new List<int>();

        Car a1 = new BMW();
        Car a2 = new Toyota();

        a1.MakeMove();
        a2.MakeMove();

        Console.ReadLine();
    }

    public class MyList
    {
        public int[] arr { get; set; }


    }
}
 
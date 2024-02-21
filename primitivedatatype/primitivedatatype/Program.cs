using System;

namespace primitivedatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring a variale
            int a;
            //declaring a multiple varaible at once
            // int c, d, e;
            //assigning a variable
            a = 15;
            int b = 25;
            //overriding and reassigning the value of b
            b = 100;
            double d1 = 10.10;
            double d2 = 12.1213;


            int sum = a + b;
            //printing a variable
            Console.WriteLine("num1: " + a + " num2: " + b + " is " + sum);//+ is used to app text

            //double
            double ddiv = d1 / d2;
            Console.WriteLine("d1/d2" + ddiv);

            //float
            float fdiv = 10.10f;
            float fdivd2 = 12.1213f;
            float fdivi = fdiv / fdivd2;
            Console.WriteLine("fdiv/fdivd2 is " + fdivi);
            Console.Read();

        }
    }
}

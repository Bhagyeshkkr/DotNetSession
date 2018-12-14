using System;

namespace Problem2
{
    class Calculator
    {

        public virtual int calc(int a, int b)
        {
            Console.WriteLine("Base function called");
            return (a + b);
        }
    }

    class Dcalculator : Calculator
    {

        public override int calc(int a, int b)
        {
            Console.WriteLine("Override function called");

            return (a * b);
        }
    }

    class Driver
    {
        static void Main(string[] args)
        {
            Calculator a = new Calculator();
            int result = a.calc(10, 20);
            Console.WriteLine(result);
            
            Calculator d = new Dcalculator();
             result = d.calc(10, 20);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

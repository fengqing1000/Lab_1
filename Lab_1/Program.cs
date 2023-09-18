using System;

namespace Lab_1
{
    internal class Program
    {
        static void Main()
        {
            var lines = new string[] { "Введите число a: ", "И число b: " };
            var elements = new decimal[2];

            for (int i = 0; i < lines.Length; i++) 
            {
                Console.Write(lines[i]);
                elements[i] = decimal.Parse(Console.ReadLine());
            }

            var Example = new A(elements[0], elements[1]);

            Console.WriteLine(Example.C);
        }  
    }

    public class A
    {
        private decimal a;
        private decimal b;

        public decimal C { get { return a += -b; } }

        public A() {}

        public A(decimal a, decimal b)
        {
            this.a = a;
            this.b = b;
        }
    }
}

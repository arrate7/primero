using System;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca número");
            int num1,num2;
            num1 =  Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Introduzca otro número");
            num2 = Int32.Parse(Console.ReadLine());
           // double resultado = num1 / num2;
            Console.WriteLine("La división " + num1 + " entre " + num2 + " es: " + num1/num2);
            Console.ReadLine();

        }
    }
}

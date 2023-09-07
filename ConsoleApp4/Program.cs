using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int d;
            Console.WriteLine("введи a");

            string t = Console.ReadLine();
            Console.WriteLine("ввести d");
            string g = Console.ReadLine();
            a = int.Parse(t);
            d = int.Parse(g);
            if (a < d) {
                Console.WriteLine($" число d {d} больше");
            } else if (d < a) {
                Console.WriteLine($" число a {a}  больше");
            } else Console.WriteLine("числа равны"); 


            //int a;

            //string tmp = Console.ReadLine();
            //a = int.Parse(tmp);
            //if( a > 0) {
            //    a = a + 1;
            //    Console.WriteLine($"Число a {a} положительное");
            //} else if( a == 0 ) {
            //    Console.WriteLine("a равно нулю");
            //} else { //все остальные случаи
            //    Console.WriteLine("a отрицательное");
            //}




            //int a;
            //int b;
            //int S;
            //int P;

            //Console.WriteLine("Привет, считаем S прямоугольника, введите значение сторон");
            //string tmpA = Console.ReadLine();
            //string tmpB = Console.ReadLine();
            //a = int.Parse(tmpA);
            //b = int.Parse(tmpB);
            //Console.WriteLine($"S={a*b}, P={2*(a+b)}");

            //Console.WriteLine("S= " +a*b + " ,P= " + 2*(a+b));
          


            //Console.WriteLine("введите сторону квадрата");
            //int a;
            //string t = Console.ReadLine();
            //a = int.Parse(t);

            //Console.WriteLine("P="+a*4);



            //int age;
            //string name;

            //Console.WriteLine("Привет, как тебя зовут!");
            //name = Console.ReadLine();

            //Console.WriteLine("Сколько тебе лет");
            //string tmp = Console.ReadLine();
            //age = int.Parse(tmp);

            //Console.WriteLine("Привет " + name + " тебе " + age + " лет");
            Console.ReadKey();
        }
    }
}

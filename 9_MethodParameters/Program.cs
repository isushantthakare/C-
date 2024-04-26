using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_MethodParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //PrintA(a);
            //Console.WriteLine(a);

            int b = 10;
            PrintB(ref b);
            Console.WriteLine(b);

           int c ;
            PrintC(out c);
            Console.WriteLine(c);

            int a = 40, bc = 20, add, sub, mul, div;
            PrintD( a,bc,out add,out sub,out mul,out div);  
            Console.WriteLine($"addition ={add}");
            Console.WriteLine($"Substraction ={sub}");
            Console.WriteLine($"Multiplication ={mul}");
            Console.WriteLine($"Division ={div}");
            Console.ReadLine();
        }

        //public static void PrintA(int a)
        //{
        //    a = 100;
        //}
        public static void PrintB(ref int b)
        {
         b= 100;
        }
        public static void PrintC(out int c)
        {
          c= 100;
        }


        public static void PrintD( int a,int b,out int add,out int sub,out int multi,out int div)
        {
            add = a + b;    
            sub = a - b;    
            multi = a * b;    
            div = a / b;    
        }

    }
}

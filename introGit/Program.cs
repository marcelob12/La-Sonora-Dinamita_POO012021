using System;

namespace introGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0 , b=0 ;

            Console.Write("Ingrese un valor para a:");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Ingrese un valor para b:");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"La multiplicacion de {a} * {b} es igual a : {multiplyNum(a,b)}");
        }

        public static int multiplyNum(int a , int b){
                return a*b;
        }
    }
}

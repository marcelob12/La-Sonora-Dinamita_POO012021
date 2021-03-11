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

            Console.WriteLine($"La resta de {a} - {b} es igual a : {subtractNum(a,b)}");
        }

        public static int subtractNum(int a , int b){
                return a-b;
        }
    }
}

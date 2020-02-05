using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "esta é uma frase!";
            string frase2 = "esta é uma frase!";

            string posicao = frase.Substring(3,10);
            Console.WriteLine(posicao);


            Console.WriteLine(frase2);
        }
    }
}

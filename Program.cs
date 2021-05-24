using System;

namespace RetPreenchido
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura, altura;  

            Console.WriteLine("Tamanho do retângulo (digite apenas números de 1 a 10):");

            Console.Write("Largura: ");
            largura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altura: ");
            altura = Convert.ToInt32(Console.ReadLine());

           if (largura > 10 || altura > 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Por favor, recomeçe e digite números de 1 a 10. ");
                Console.ResetColor();
                Environment.Exit(-1);
            }
        
            int linha = 1; 
            while(linha <= altura)
            {
                int coluna = 1;
                while (coluna <= largura)
                {
                    Console.Write("* ");
                    coluna++; 
                }
                Console.WriteLine();
                linha++; 
            }
        }
    }
}

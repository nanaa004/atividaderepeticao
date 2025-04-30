
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int limite = int.Parse(Console.ReadLine());

        int contador = 2;
        while (contador <= limite)
        {
            Console.WriteLine(contador);
            contador += 3;
        }
    }
}

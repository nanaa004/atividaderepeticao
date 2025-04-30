using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int N = int.Parse(Console.ReadLine());

        int contador = 2;
        while (contador <= N)
        {
            Console.WriteLine(contador);
            contador += 2;  
        }
    }
}

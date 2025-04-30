using System;

class Program
{
    static void Main()
    {
        int contador = -1;
        while (contador >= -10)
        {
            Console.WriteLine(contador);
            contador -= 1;  // Decrementa 1 para contar até -10
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        
        int contador = 10;
        while (contador > 0)
        {
            Console.WriteLine(contador);
            contador -= 1;  
        }

        
        contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador += 1;  
        }
    }
}
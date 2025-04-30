using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        int contador = 1; // Usaremos um contador para fazer a multiplicação por 10
        int resultado = numero;

        while (contador < 10)  // Multiplicamos por 10, então 9 iterações são suficientes
        {
            resultado += numero;  // Somamos o número à variável resultado
            contador += 1;
        }

        Console.WriteLine($"O resultado de {numero} multiplicado por 10 é: {resultado}");
    }
}
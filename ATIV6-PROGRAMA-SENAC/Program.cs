using System;

class Program
{
    static void Main()
    {
        double peso, altura;
        string nome;

        Console.WriteLine("Qual seu nome completo?");
        nome = (Console.ReadLine());

        Console.WriteLine("Qual seu peso?");
        peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual sua altura?");
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine($"{nome} seu IMC é {(peso / altura) * altura}");
    }
}


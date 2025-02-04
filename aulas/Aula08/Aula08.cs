using System;

class Aula08
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;

        Console.Write("Digite um número: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite outro número: ");
        v2 = int.Parse(Console.ReadLine());

        soma = v1 + v2;
        Console.Write("A some de: {0} + {1} = {2}",v1,v2,soma);
    }
}

/*
using System;

class Aula08
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Nome digitado: {0}",nome);
    }
}
*/
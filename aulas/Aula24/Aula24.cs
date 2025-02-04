using System;

class Aula24
{
    static void Main()
    {
        int v1, v2, res;

        Console.Write("Digite um número...: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite outro número: ");
        v2 = int.Parse(Console.ReadLine());

        res = soma(v1, v2);

        Console.WriteLine($"A soma de {v1} e {v2} é igual a {res}");
    }

    static int soma(int n1, int n2)
    {
        int res = n1 + n2;
        return res;
    }
}
using System;

class Aula05
{
    static void Main()
    {
        // && = AND / E
        // || = OR / OU

        bool res = (10 > 2) && (5 > 2); // True
        // bool res = (10 > 2) && (5 < 2); // False

        // bool res = (10 > 2) && (5 > 2); // True
        // bool res = (10 > 2) && (5 < 2); // True

        Console.WriteLine("Resultado: " + res);
    }
}
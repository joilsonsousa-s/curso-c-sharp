using System;

class Aula26
{
    static void Main()
    {
        int divD, divS, quoc, rest;
        divD = 10;
        divS = 5;
        quoc = divide(divD, divS, out rest);

        Console.WriteLine($"{divD} / {divS} = {quoc} e resto {rest}");
    }

   static int divide(int dividendo, int divisor, out int resto)
   {
        int quociente;

        quociente = dividendo / divisor;
        resto = dividendo % divisor;

        return quociente;
   }
}
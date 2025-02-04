using System;

class Aula10
{
    enum diaSemanas {Segunda,Terça,Quarta,Quinta,Sexta,Sabado,Domingo}
    static void Main()
    {
        int ds = (int) diaSemanas.Sexta;
        // diaSemanas ds = (diaSemanas)1;
        // diaSemanas ds = diaSemanas.Segunda;

        Console.WriteLine(ds);
    }
}
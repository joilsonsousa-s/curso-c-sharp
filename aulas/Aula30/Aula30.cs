using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }

    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e)
    {
        energia = e;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e, bool v)
    {
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info()
    {
        Console.WriteLine("Nome do jogador...: {0}",nome);
        Console.WriteLine("Energia do jogador: {0}",energia);
        Console.WriteLine("Estado do jogador.: {0}",vivo);
        Console.WriteLine("-----------------------");
    }

    public void info(string n)
    {
        Console.WriteLine("Nome do jogador...: {0}",nome);
        Console.WriteLine("Energia do jogador: {0}",energia);
        Console.WriteLine("Estado do jogador.: {0}",vivo);
        Console.WriteLine(n);
        Console.WriteLine("-----------------------");
    }
}

class Aula30
{
    static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Joilson");
        Jogador j3 = new Jogador("Joelson",100);
        Jogador j4 = new Jogador("Paula",50,true);
        Jogador j5 = new Jogador("Lara",70,true);

        j1.info();
        j1.info("Fim de Jogo!");
        j2.info();
        j3.info();
        j4.info();
        j5.info();
    }
}
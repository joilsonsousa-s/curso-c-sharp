using System;

static public class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void iniciar(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }

    static public void info()
    {
        Console.WriteLine("Nome do jogador...: {0}",nome);
        Console.WriteLine("Energia do jogador: {0}",energia);
        Console.WriteLine("Estado do jogador.: {0}",vivo);
        Console.WriteLine("-----------------------");
    }
}

class Inimigo
{
    static public bool alerta;
    public string nome;

    public Inimigo(string n)
    {
        alerta = false;
        nome = n;
    }

    public void info()
    {
        Console.WriteLine("Nome do inimigo: {0} - Estado aletra: {1}", nome, alerta);
        Console.WriteLine("-----------------------");
    }
}

class Aula31
{
    static void Main()
    {
        Jogador.iniciar("Joilson");
        Jogador.info();

        Inimigo i1 = new Inimigo("Zecas");
        Inimigo i2 = new Inimigo("Crauz");
        Inimigo i3 = new Inimigo("Trovão");

        Inimigo.alerta = true;

        i1.info();
        i2.info();
        i3.info();
    }
}
﻿using System;

class Aula16
{
    static void Main()
    {
        int tempo = 0;
        char escolha;

        inicio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.Write("Escolha o transporte: [a]=Avião | [c]=Carro | [o]=ônibus ");
        escolha = char.Parse(Console.ReadLine());
        
        switch(escolha) {
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
                
            default:
                tempo = -1;
                break;
        }

        if(tempo < 0) {
            Console.WriteLine("Transporte indisponível.");
        } else {
            Console.WriteLine("Tempo para o transporte escolhido é: {0}", tempo);
        }

        Console.Write("\nCalcular outro transporte? [s/n] ");
        escolha = char.Parse(Console.ReadLine());

        if(escolha == 's' || escolha == 'S') {
            goto inicio;
        } else {
            Console.Clear();
            Console.Write("Fim do programa.");
        }
    }
}
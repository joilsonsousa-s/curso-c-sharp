﻿using System;

class Aula19
{
    static void Main()
    {
        int[] num = new int[10];

        for(int i = 0; i < num.Length; i++) {
            num[i] = 0;
        }

        for(int i = 0; i < 10; i++) {
            num[i] = 0;
            Console.WriteLine("Valor de num na posição: {0}: {1}",i,num[i]);
        }
    }
}
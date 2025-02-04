using System;

class Aula18
{
    static void Main()
    {
        int[,] n = new int[2,2]{{10,20},{30,40}};

        Console.WriteLine(n[0,0]);
        Console.WriteLine(n[1,1]);


        /*
            10 20 30 40 50
            15 25 35 45 55
            20 30 40 50 60
        */

        /*
        int[,] n = new int[3,5];

        n[0,0] = 10; n[0,1] = 20; n[0,2] = 30; n[0,3] = 40; n[0,4] = 50; 
        n[1,0] = 15; n[1,1] = 25; n[1,2] = 35; n[1,3] = 45; n[1,4] = 55;
        n[2,0] = 20; n[2,1] = 25; n[2,2] = 40; n[2,3] = 50; n[2,4] = 60;

        Console.WriteLine(n[0,0]);
        Console.WriteLine(n[1,4]);
        Console.WriteLine(n[2,3]);
        */
    }
}
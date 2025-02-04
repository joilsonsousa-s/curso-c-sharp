using System;

class Aula20
{
    static void Main()
    {
        int[] num = new int[10];

        int i = num.Length-1; // 10
        while (i > 0) {
            num[i] = i;
            Console.WriteLine(i);
            i--;
        }
    }
}
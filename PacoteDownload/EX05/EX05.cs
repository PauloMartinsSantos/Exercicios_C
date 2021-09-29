using System;
class EX05{
    static void Main(){

        int cont,n1,res;

        Console.WriteLine("Qual tabuada quer ver: ");
        n1 = int.Parse(Console.ReadLine());

        cont = 1;

        Console.WriteLine("------TABUADA DO {0}------",n1);

        while (cont < 11)
        {
             res = (cont * n1);
             Console.WriteLine("{0} x {1} = {2}",n1,cont,res);
             cont++;
        }
    }
}
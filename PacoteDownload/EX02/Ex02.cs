using System;
class Ex02{
    static void Main(){
        double pao;
        double broa;
        double reserva;

        Console.WriteLine("-------------------------------------------------"); 
        Console.WriteLine("                 PADARIA HOT PÃO                 ");
        Console.WriteLine("-------------------------------------------------");

        Console.WriteLine("Quantidade de Pães vendidos: ");
        pao = double.Parse(Console.ReadLine());

        Console.WriteLine("Quantidade de Broas vendidas: ");
        broa = double.Parse(Console.ReadLine());

        pao = pao * 0.12;
        broa = broa * 1.50;

        reserva = (pao + broa) * 10/100;

        Console.WriteLine("Total arrecadado pão R$ {0}",pao);
        Console.WriteLine("Total arrecadado broa R$ {0}",broa);
        Console.WriteLine("Valor a ser guardado na poupança R$ {0}",reserva);

        Console.WriteLine("-------------------------------------------------" );

    }
}
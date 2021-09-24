using System;
class Ex01{
    static void Main(){
        //Faça um algoritmo para calcular quantas ferraduras são necessárias para equipar todos os
        //cavalos comprados para um haras.

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("          HARAS HEARTLAND                ");
        Console.WriteLine("-----------------------------------------");
        int qtd,ferraduras;

        Console.WriteLine("Qual a quantidade de Cavalos do Haras? : ");
        qtd = int.Parse(Console.ReadLine());

        ferraduras = qtd * 4 ;

        Console.WriteLine("São necessárias {0} ferraduras.",ferraduras);      


    }
}
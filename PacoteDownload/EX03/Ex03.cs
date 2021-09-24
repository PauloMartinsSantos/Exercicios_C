using System;
class Ex03{
    static void Main(){
        int idade;
        string nome;
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        idade = idade * 365;

        Console.WriteLine("{0}, Você ja viveu {1} dias.",nome,idade);
    }
}
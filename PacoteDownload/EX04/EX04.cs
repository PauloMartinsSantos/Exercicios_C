using System;
class EX04{
    static void Main(){
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("     Calculo qtd Litros de gasolina        ");
        Console.WriteLine("-------------------------------------------");

        double preco,valor,total;

        Console.WriteLine("Digite o preço da Gasolina: ");
        preco = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o Valor que deseja abastecer: ");
        valor = Convert.ToDouble(Console.ReadLine());

        total = valor / preco;
        
        Console.WriteLine("Quantidade Abastecida: {0} Lts",total.ToString("F"));

        // CRIADO BRANCH CONTEUDO

        //TESTANDO ....
        

    }
}
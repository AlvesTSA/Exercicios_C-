/*31. O Sr. Manoel Joaquim expandiu seus negócios para além dos negócios de 1,99 e agora possui uma loja de conveniências. Faça um programa que implemente uma caixa registradora rudimentar. O programa deverá receber um número desconhecido de valores referentes aos preços das mercadorias. Um valor zero deve ser informado pelo operador para indicar o final da compra. O programa deve então mostrar o total da compra e perguntar o valor em dinheiro que o cliente forneceu, para então calcular e mostrar o valor do troco. Após esta operação, o programa deverá voltar ao ponto inicial, para registrar a próxima compra. A saída deve ser conforme o exemplo abaixo:

Lojas Tabajara 

Produto 1: R$ 2.20 

Produto 2: R$ 5.80

Produto 3: R$ 0

Total: R$ 9.00

Dinheiro: R$ 20.00

Troco: R$ 11.00

...*/

using System;

class exercicio_031{

    static void Main(){

        float produto = 0;
        float total = 0;
        float dinheiro = 0;
        float troco = 0;
        int i = 0;

        Console.Write("Informe os preços dos produtos e selecione 0 para finalizar a compra.\n");

        do{
            i ++;
            Console.Write("Produto " + i + ": ");
            produto = float.Parse(Console.ReadLine());
            total += produto;

        } while (produto != 0);

        Console.Write("Total: R$ " + total);
        Console.Write("\nDinheiro: R$ ");
        dinheiro = float.Parse(Console.ReadLine());
        troco = dinheiro - total;
        Console.Write("Troco: R$ " + troco);

    }
}
/*30. O Sr. Manoel Joaquim acaba de adquirir uma panificadora e pretende implantar a metodologia da tabelinha, que já é um sucesso na sua loja de 1,99. Você foi contratado para desenvolver o programa que monta a tabela de preços de pães, de 1 até 50 pães, a partir do preço do pão informado pelo usuário, conforme o exemplo abaixo:

Preço do pão: R$ 0.18 

Panificadora Pão de Ontem - Tabela de preços 

1 - R$ 0.18

2 - R$ 0.36

...

50 - R$ 9.00

*/

using System;

class exercicio_030{

    static void Main(){

        float soma = 0;
        float valor = 0;

        Console.WriteLine("Informe o valor da unidade de pao: ");
        valor = float.Parse(Console.ReadLine());

        Console.WriteLine("Panificadora Pão de Ontem -Tabela de preços.");

        for (int i = 1; i <= 50; i++){
            
            soma += valor;
            Console.WriteLine(i + "- R$ "+ $"{soma:0.00}"); 
        }
    }
}
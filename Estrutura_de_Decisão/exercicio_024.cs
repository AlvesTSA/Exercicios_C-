/*Faça um Programa para um caixa eletrônico. O programa deverá perguntar ao usuário a valor do saque e depois informar quantas notas de cada valor serão fornecidas. As notas disponíveis serão as de 1, 5, 10, 50 e 100 reais. O valor mínimo é de 10 reais e o máximo de 600 reais. O programa não deve se preocupar com a quantidade de notas existentes na máquina.

Exemplo 1: Para sacar a quantia de 256 reais, o programa fornece duas notas de 100, uma nota de 50, uma nota de 5 e uma nota de 1;
 
Exemplo 2: Para sacar a quantia de 399 reais, o programa fornece três notas de 100, uma nota de 50, quatro notas de 10, uma nota de 5 e quatro notas de 1.
*/

using System;

class exercicio_024{

    static void Main(){

        int nota100 = 0;
        int nota50 = 0;
        int nota10 = 0;
        int nota5 = 0;
        int nota1 = 0;
        int valor = 0;

        Console.WriteLine("Informe o valor que deseja sacar ate 600 reais");
        valor = int.Parse(Console.ReadLine());

        if(valor > 0 && valor <= 600){

            nota100 = valor / 100;
            valor %= 100;
            nota50 = valor / 50;
            valor %= 50;
            nota10 = valor / 10;
            valor %= 10;
            nota5 = valor / 5;
            valor %= 5;
            nota1 = valor;

        }
        else{

            Console.WriteLine("Informe um valor valido.");

            Environment.Exit(0);

        }

        Console.WriteLine("Nota de 100: " + nota100 + "\nNota de 50: " + nota50 + "\nNota de 10: " + nota10 + "\nNota de 5: " + nota5 + "\nNota de 1: " + nota1); 
    }

}
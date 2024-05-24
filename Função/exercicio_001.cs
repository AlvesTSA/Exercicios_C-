/*1. Faça um programa, com uma função que necessite de um argumento. A função retorna o valor de caractere ‘P’, se seu argumento for positivo, e ‘N’, se seu argumento for zero ou negativo.*/
using System;
class exercicio_001{

    static void Main(){

        Console.Write("Informe um número inteiro:");
        int num = int.Parse(Console.ReadLine());

        char result = PositivoNegativo(num);

        Console.Write("O numero informado: " + result);

        static char PositivoNegativo(int num)
        {
            if(num >= 0)
            {
                return 'P';
            }
            else
            {
                return 'N';
            }
        }

    }
}

/* Faça um Programa que peça um número inteiro e determine se ele e par ou ímpar.*/

using System;

class exercicio_017{

    static void Main(){

        int num = 0;

        Console.WriteLine("Informe um número inteiro: ");
        num = int.Parse(Console.ReadLine());

        if (num % 2 == 0){

            Console.WriteLine("Número par");
        }
        else{

           Console.WriteLine("Número impar");
        }
    }
}
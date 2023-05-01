/*1. Faça um Programa que peça dois números e imprima o maior deles.*/

using System;

class exercicio_001{

    static void Main(){

        int num1 = 0;
        int num2 = 0;

        Console.WriteLine("Informe dois números: ");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());

        if (num1 > num2){

            Console.WriteLine("O maior número digitado: " + num1);

        }
        else{

            Console.WriteLine("O maior número digitado: " + num2);

        }

    }
}
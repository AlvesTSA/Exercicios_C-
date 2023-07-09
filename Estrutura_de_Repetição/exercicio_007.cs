/*Faça um programa que leia 5 números e informe o maior número.*/

using System;

class exercicio_007{

    static void Main(){

        int maior = 0;
        int num1 = 0;
        int i = 0;

        Console.Write("Informe o 1° número: ");
        maior = int.Parse(Console.ReadLine());

        for (i = 1; i < 5; i++){
            
            Console.Write("Informe o " + (i + 1) + "° número: ");
            num1 = int.Parse(Console.ReadLine());

            if(num1 > maior){

                maior = num1;
            }
        }

        Console.WriteLine("Maior: " + maior);
         
    }
}
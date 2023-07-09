/*Faça um programa que leia 5 números e informe a soma e a média dos números.*/

using System;

class exercicio_008{

    static void Main(){

        int num = 0;
        int i = 0;
        int soma = 0;
        double media = 0;

        for (i = 0; i < 5; i++){
            
            Console.Write("Informe o " + (i + 1) + "° número: ");
            num = int.Parse(Console.ReadLine());

            soma += num; 
        }

        media = soma/i;

        Console.Write("Soma: " + soma + "\nMedia: " + media);
    }
}
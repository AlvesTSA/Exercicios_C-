/*7. Faça um Programa que leia um vetor de 5 números inteiros, mostre a soma, a multiplicação e os números.*/

using System;

class exercicio_007{

    static void Main(){

        int[] num = new int[5];
        int soma = 0;
        int mult = 1;

        Console.WriteLine("Informe 5 numeros inteiros:");

        for (int i = 0; i < 5; i++){
            
            num[i] = int.Parse(Console.ReadLine());

            soma += num[i]; 
            mult *= num[i];
        }

        Console.WriteLine("Soma: " + soma + "\nMultiplicacao: " + mult);
        Console.Write("Numeros: ");

        for (int i = 0; i < 5; i++){
            
            Console.Write(num[i] + " ");
        }
    }
}
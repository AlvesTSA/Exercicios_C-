/*9. Faça um Programa que leia um vetor A com 10 números inteiros, calcule e mostre a soma dos quadrados dos elementos do vetor.*/

using System;

class exercicio_009{

    static void Main(){

        int[] A = new int[10];
        int soma = 0;

        Console.WriteLine("Informe 10 numeros inteiros: ");

        for (int i = 0; i < 10; i++){
            
            A[i] = int.Parse(Console.ReadLine());
            soma += (A[i] * A[i]);
        }

        Console.WriteLine("Soma dos quadrados: " + soma);
    }
}
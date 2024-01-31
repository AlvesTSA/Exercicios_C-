/*1. Faça um Programa que leia um vetor de 5 números inteiros e mostre-os.*/

using System;

class exercicio_001{

    static void Main(){

        int [] vetor = new int [5];

        Console.WriteLine("Informe s numeros inteiros:");

        for (int i = 0; i < 5; i++){
            
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Valores lidos: ");

        for (int i = 0; i < 5; i++){
            
            Console.Write(vetor[i] + " ");
        }
    }
}
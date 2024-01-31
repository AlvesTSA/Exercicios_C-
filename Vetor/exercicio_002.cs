/*2. Faça um Programa que leia um vetor de 10 números reais e mostre-os na ordem inversa.*/

using System;

class exercicio_002{

    static void Main(){

        int[] vetor = new int[10];

        Console.WriteLine("Informe 10 numeros:");

        for (int i = 0; i < 10; i++){
            
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Valores lidos na ordem inversa:");

        for (int i = 9; i >= 0; i--){
            
            Console.Write(vetor[i] + " ");
        }
    }
}
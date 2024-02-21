/*24. Leia um vetor de 5 posições contendo os caracteres de um numero. Em seguida escreva esse numero por extenso.*/

using System;

class exercicio_024{
    
    static void Main(){

        int[] vetor = new int[5];

        for (int i = 0; i < 5; i++){
            
            Console.Write("Informe o carctere " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());

        } 

        Console.Write("Numero: ");

        for (int i = 0; i < 5; i++){
            
            Console.Write(vetor[i]);
        }
    }
}
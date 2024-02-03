/*6. Leia um vetor de 40 posições e atribua valor 0 para todos os elementos que possuírem valores negativos.*/

using System;

class exercicio_006{

    static void Main(){

        int[] vetor = new int[40];

        Console.WriteLine("Informe 40 numeros inteiros:");

        for (int i = 0; i < 40; i++){
            
            vetor[i] = int.Parse(Console.ReadLine());

            if (vetor[i] < 0){
                
                vetor[i] = 0;
            }
        }

        Console.WriteLine("Valores lidos e corrigidos com zero:");

        for (int i = 0; i < 40; i++){
            
            Console.Write(vetor[i] + " ");
        }
        
    }
}
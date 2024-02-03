/*4. Faça um Programa que leia um vetor de 10 caracteres, e diga quantas consoantes foram lidas. Imprima as consoantes.*/

using System;

class exercicio_004{

    static void Main(){

        char[] vetor = new char[10];
        int consoante = 0;

        Console.WriteLine("Informe 10 letras:");

        for (int i = 0; i < 10; i++){
            
            vetor[i] = char.Parse(Console.ReadLine());

            if (vetor[i] != 'a' && vetor[i] != 'e' && vetor[i] != 'i' && vetor[i] != 'o' && vetor[i] != 'u' && vetor[i] != 'A' && vetor[i] != 'E' && vetor[i] != 'I' && vetor[i] != 'O' && vetor[i] != 'U'){

                consoante++;
            }
        }

        Console.WriteLine("Consoantes identificadas: " + consoante);
        
        for (int i = 0; i < 10; i++){
            
            if (vetor[i] != 'a' && vetor[i] != 'e' && vetor[i] != 'i' && vetor[i] != 'o' && vetor[i] != 'u' && vetor[i] != 'A' && vetor[i] != 'E' && vetor[i] != 'I' && vetor[i] != 'O' && vetor[i] != 'U'){

                Console.Write(vetor[i] + " ");
            }
        }
    }
}
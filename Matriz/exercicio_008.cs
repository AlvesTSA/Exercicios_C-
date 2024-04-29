/*8. Leia uma matriz 8x 8 e escreva o maior elemento da diagonal principal e a soma dos elementos da diagonal secundaria.*/

using System;

public class exercicio_008{

    static void Main(){

        Random random = new Random();
        const int size = 8;
        const int max = 100;
        const int min = 0;
        int[,] matriz = new int[size,size];
        int maior = 0;

        Console.WriteLine("Informe uma matriz " + size +" x " + size + ": ");

        for (int i = 0; i < size; i++){
            
            for (int y = 0; y < size; y++){
                
                matriz[i,y] = random.Next(min,max);
            }
        }

        //maior valor da diagonal principal
        maior = matriz[0,0];

        for (int i = 0; i < size; i++){
            
            if (matriz[i,i] > maior){
                
                maior = matriz[i,i];
            }
        }
        
        //soma da diagonal secundária
        int soma = 0;
        int j = size - 1;

        for (int i = 0; i < size; i++){
            
            soma += matriz[i,j];
            j--;
        }
        
        Console.Write("\nMatriz lida:\n");

        for (int i = 0; i < size; i++){
            
            for (int y = 0; y < size; y++){
                
                Console.Write(matriz[i,y] + " ");
            
            }
            Console.WriteLine();
        }

        Console.Write("Diagonal principal: ");

        for (int i = 0; i < size; i++){
            
            Console.Write(matriz[i,i] + " ");
        }

        Console.Write("\nMaior valor da diagonal principal: " + maior);
        Console.Write("\nDiagonal secundaria: ");
        j = size - 1;

        for (int i = 0; i < size; i++){
            
            Console.Write(matriz[i,j] + " ");
            j--;
        }

        Console.Write("\nSoma da diagonal secundaria: " + soma);
    }
}
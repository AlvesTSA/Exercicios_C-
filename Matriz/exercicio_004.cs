/*4. Leia uma matriz 4 x 4 e troque os valores da 1ª.linha pelos da 4ª.coluna, vice-e-versa. Escrever ao final a matriz obtida*/

using System;

public class exercicio_004{

    static void Main(){

        Random random = new Random();
        const int size = 4;
        const int max = 9;
        const int min = 1;
        int[,] matriz = new int[size,size];
        int temp = 0;

        for (int i = 0; i < size; i++){
        
            for (int j = 0; j < size; j++){
            
                matriz[i,j] = random.Next(min,max);
            }
        }
        
        Console.WriteLine("Matriz lida: ");

        for (int i = 0; i < size; i++){
        
            for (int j = 0; j < size; j++){
                
                Console.Write(matriz[i,j] + " ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < size; i++){
        
            temp = matriz[0,i];
            matriz[0,i] = matriz[i,3];
            matriz[i,3] = temp;
        }

        Console.WriteLine("Matriz invertida: ");
    
        for (int i = 0; i < size; i++){
        
            for (int j = 0; j < size; j++){
            
                Console.Write(matriz[i,j] + " ");
            }
            Console.WriteLine();
        }

    }
}
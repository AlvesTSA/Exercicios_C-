/*18. Leia uma matriz 5 x 5 e faça uma troca entre as diagonais superior e inferior. Escreva-a ao final.*/

using System;

public class exercicio_018{

    static void Main(){

        Random random = new Random();
        const int size = 5;
        const int max = 10;
        const int min = 0;
        int[,] matriz = new int[size,size];
        
        for (int i = 0; i < size; i++){
        
            for (int j = 0; j < size; j++){
                
                matriz[i,j] = random.Next(min,max);
            }
        }

        Console.WriteLine("Matriz original:");
        for (int i = 0; i < size; i++){
            
            for (int j = 0; j < size; j++){
                
                Console.Write(matriz[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        int temp = 0;
        
        for (int i = 0; i < size; i++){
            
            for (int j = i + 1; j < size; j++){
                
                temp = matriz[i,j];
                matriz[i,j] = matriz[j,i];
                matriz[j,i] = temp;
            }
        }

        Console.WriteLine("Matriz invertida:");
        for (int i = 0; i < size; i++){
            
            for (int j = 0; j < size; j++){
                
                Console.Write(matriz[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}
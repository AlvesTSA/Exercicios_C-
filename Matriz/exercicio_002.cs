/*2. Leia uma matriz 6 x 6, conte e escreva quantos valores maiores que 10 ela possui.*/

using System;

public class exercicio_002{

    static void Main(){

        Random random = new Random();
        const int size = 6;
        const int min = 1;
        const int max = 30;
        int count = 0;
        int[,] matriz = new int[size,size];

        Console.WriteLine("Informe uma matriz: ");

        for (int i = 0; i < size; i++){
            
            for (int j = 0; j < size; j++){
                
                matriz[i,j] = random.Next(min,max);

                if (matriz[i,j] > 10){
                    
                    count++;
                } 
            }
        }

        Console.WriteLine("Matriz lida: ");
        
        for (int i = 0; i < size; i++){
            
            for (int j = 0; j < size; j++){
                
                Console.Write(matriz[i,j] + " ");
                
            } 
            Console.WriteLine();
        }

        Console.WriteLine("Existem " + count + " valores maiores que 10"); 
    }
}
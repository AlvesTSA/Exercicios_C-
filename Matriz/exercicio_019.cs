/*19. Leia duas matrizes 10 x 10 e faça uma substituição entre a diagonal inferior da primeira coma diagonal superior da segunda.*/

using System;

public class exercicio_019{

    static void Main(){

        Random random = new Random();
        const int size = 10;
        const int max = 10;
        const int min = 0;
        int[,] matrizA = new int[size,size];
        int[,] matrizB = new int[size,size];
        
        for (int i = 0; i < size; i++){
        
            for (int j = 0; j < size; j++){
                
                matrizA[i,j] = random.Next(min,max);
                matrizB[i,j] = random.Next(min,max);
            }
        }

        Console.WriteLine("Matrizes originais:");
        for (int i = 0; i < size; i++){
            
            for (int j = 0; j < size; j++){
                
                Console.Write(matrizA[i,j]+" ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < size; i++){
            
            for (int j = 0; j < size; j++){
                
                Console.Write(matrizB[i,j]+" ");
            }
            Console.WriteLine();
        }

        int temp = 0;
        
        for (int i = 0; i < size; i++){
            
            for (int j = i + 1; j < size; j++){
                
                temp = matrizA[j,i];
                matrizA[j,i] = matrizB[i,j];
                matrizB[i,j] = temp;
            }
        }

        Console.WriteLine("Matrizes invertidas:");
        for (int i = 0; i < size; i++){
            
            for (int j = 0; j < size; j++){
                
                Console.Write(matrizA[i,j]+" ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < size; i++){
            
            for (int j = 0; j < size; j++){
                
                Console.Write(matrizB[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}
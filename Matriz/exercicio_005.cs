/*5. Leia duas matrizes 20 x 20 e escreva os valores da primeira que ocorrem em qualquer posição da segunda.*/

using System;

public class exercicio_005{

    static void Main(){

        Random random = new Random();
        const int size = 20;
        const int intervalo_max = 1000;
        const int intervalo_min = 1;
        int[,] matrizA = new int[size,size];
        int[,] matrizB = new int[size,size];

        for (int i = 0; i < size; i++){
    
            for (int j = 0; j < size; j++){
            
                matrizA[i,j] = random.Next(intervalo_min,intervalo_max);
                matrizB[i,j] = random.Next(intervalo_min,intervalo_max);
            } 
        }
        
        Console.WriteLine("Todos os valores da matriz A que estao na matriz B\n");
        
        for (int i = 0; i < size; i++){
        
            for (int j = 0; j < size; j++){
            
                for (int w = 0; w < size; w++){
        
                    for (int z = 0; z < size; z++){
                    
                        if (matrizA[i,j] == matrizB[w,z]){
                                
                            Console.Write(matrizA[i,j] + " ");
                        }
                        
                    } 
                }
            } 
        }
        
    }
}
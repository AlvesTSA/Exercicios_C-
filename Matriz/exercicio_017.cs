/*17. Leia uma matriz 8 x 8 e a transforme numa matriz triangular inferior , atribuindo zero a todos os elementos acima da diagonal principal, escrevendo-a ao final.*/

using System;

public class exercicio_015{

    static void Main(){

        Random random = new Random();
        const int size = 8;
        const int max = 10;
        const int min = 0;
        int[,] matriz = new int[size,size];

        for (int w = 0; w < size; w++){
        
            for (int z = 0; z < size; z++){
                
                matriz[w,z] = random.Next(min,max);
            }
        }

        int i,j = 0;

        for (i = 0; i < size; i++){
            
            for (j = 0; j < size; j++){
                
                if (j > i){
                    
                    matriz[i,j] = 0;
                }
                
                Console.Write(matriz[i,j]+" ");
            }
            Console.WriteLine();
        }     
    }
}
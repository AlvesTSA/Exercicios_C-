/*9. Leia uma matriz 6 x 6 e atribuir o valor 0 para os valores negativos encontrados fora das diagonais principal e secundaria.*/

using System;

public class exercicio_009{

    static void Main(){

        Random random = new Random();
        const int size = 6;
        const int max = 10;
        const int min = 0;
        int[,] matriz = new int[size,size];

        Console.WriteLine("Informe uma matriz "+ size + " x " + size + ": ");

        for (int i = 0; i < size; i++){
            
            for (int j = 0; j < size; j++){
                
                int num = random.Next(min,max);
                matriz[i,j] = num * -1;
            }  
        }

        for (int i = 0; i < size; i++){
            
            for (int j = 0; j < size; j++){
                
                if (i != j && j != size - i - 1 && matriz[i,j] < 0){
                    
                    matriz[i,j] = 0;
                }  
            }  
        }

        for (int i = 0; i < size; i++){
            
            for (int j = 0; j < size; j++){
                
                Console.Write(matriz[i,j] + " ");
            } 
            Console.WriteLine();
        }
    }
}
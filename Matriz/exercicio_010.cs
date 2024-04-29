/*10. Leia uma matriz 50 x 2, onde cada coluna corresponde a um lado de um triangulo retângulo. Declare um vetor que contenha a área dos respectivos triângulos e o escreva.*/

using System;

public class exercicio_010{

    static void Main(){

        Random random = new Random();
        const int size_l = 50;
        const int size_c  = 2;
        const int max = 10;
        const int min = 1;
        int[,] matriz = new int[size_l,size_c];
        float[] vetor = new float[size_l];
        const float C = 0.5;

        Console.WriteLine("Informe uma matriz " + size_l  + " x " + size_c  + ": ");
        Console.WriteLine();

        for (int i = 0; i < size_l; i++){
            
            for (int j = 0; j < size_c; j++){
                
                matriz[i,j] = random.Next(min,max);
            }
        }

        Console.Write("Matriz lida: \n");
        
        for (int i = 0; i < size_l; i++){
            
            for (int j = 0; j < size_c; j++){
                
                Console.Write(matriz[i,j] + " ");
            }
            Console.WriteLine();
        }

        Console.Write("Areas dos triangulos: \n");

        for (int i = 0; i < size_l; i++){
            
            vetor[i] = (float)matriz[i,0] * (float)matriz[i,1] * C;
            Console.Write(vetor[i] + " ");
        }

    }
}
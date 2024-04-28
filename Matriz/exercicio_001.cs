/*1. Leia uma matriz 3 x 3 e escreva a localização (linha e a coluna) do maior valor.*/
using System;

public class exercicio_001{

    static void Main(){

        const int size = 3;
        int maior = 0;
        int[,] matriz = new int[size, size];
        int linha = 0;
        int coluna = 0;

        Console.WriteLine("Informe uma matriz " + size + " x " + size + ": ");

        for(int i = 0; i < size; i++){
            
            for(int j = 0; j < size; j++){
                
                matriz[i, j] = int.Parse(Console.ReadLine());

                if(matriz[i, j] > maior){
                    
                    maior = matriz[i, j];
                    linha = i;
                    coluna = j;
                }
            }
        }

        Console.WriteLine("Maior valor: " + maior);
        Console.WriteLine("Linha: " + linha + "\n" + "Coluna: " + coluna);
    }
}


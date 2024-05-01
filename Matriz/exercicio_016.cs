/* 16- Criando um tabuleiro de Jogo da Velha
Crie um tabuleiro de jogo da velha, usando uma matrizes de caracteres (char) 3×3, onde o usuário pede o número da linha (1 até 3) e o da coluna (1 até 3). A cada vez que o usuário entrar com esses dados, colocar um ‘X’ ou ‘O’ no local selecionado.*/

using System;

public class exercicio_016{

    static void Main(string[] args){

        const int size = 3;
        char[,] matriz = new char[size,size];
        int i,j = 0;

        for (int z = 0; z < size*size; z++){
        
            do{
                Console.Write("Informe a linha: ");
                i = int.Parse(Console.ReadLine());
                Console.Write("Informe a coluna: ");
                j = int.Parse(Console.ReadLine());

                if ((i < 1 || i > size) || (j < 1 || j > size)){
                    
                    Console.WriteLine("ERRO: Valor invalido, informe de 1 a " + size);
                }
                if (matriz[i-1,j-1] == 'X' || matriz[i-1,j-1] == 'O'){
                    
                    Console.WriteLine("ERRO: Esse espaco ja foi preenchido.");
                }
            
            } while ((i < 1 || i > size) || (j < 1 || j > size) || matriz[i-1,j-1] == 'X' || matriz[i-1,j-1] == 'O');

            if (z % 2 == 0){

                matriz[i-1,j-1] = 'X';
            }
            else{

                matriz[i-1,j-1] = 'O';
            }
        }

        Console.WriteLine("Resultado do jogo:");
        for (i = 0; i < size; i++){
            
            for (j = 0; j < size; j++){
                
                Console.Write(matriz[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
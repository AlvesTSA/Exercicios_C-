/*3. Leia uma matriz 20 x 20. Leia também um valor X. O programa deverá fazer uma busca desse valor na matriz e, ao final escrever a localização (linha e coluna) ou uma mensagem de “não encontrado”.*/

using System;

public class exercicio_003{

    static void Main(){

        Random random = new Random();
        const int size = 20;
        const int intervalo_max = 1000;
        const int intervalo_min = 0;
        int[,] matriz = new int[size,size];
        int x = 0;
        int i,j = 0;
        int[] loc = new int[2];
        int count = 0;

        Console.Write("Informe um valor inteiro de 0 a 100: ");
        x = int.Parse(Console.ReadLine());
    
        for (i = 0; i < size; i++){
            
            for (j = 0; j < size; j++){
                
                matriz[i,j] = random.Next(intervalo_min,intervalo_max); 
            }
        }

        for (i = 0; i < size; i++){
            
            for (j = 0; j < size; j++){
            
                if (matriz[i,j] == x){
                    
                    loc[0] = i;
                    loc[1] = j;

                    Console.WriteLine("Valor encontrado\nlinha: " + loc[0] + "\nColuna: " + loc[1]);
                    count++;
                } 
            }
        }

        if (count == 0){
            
            Console.WriteLine("Valor nao encontrado");
        }
    }
}
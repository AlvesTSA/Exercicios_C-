/*12. Leia uma matriz 4 x 4 e verifique se é palíndromo, isto é, sua leitura a partir de qualquer direção sempre apresentara a mesma seqüência.
   EX.                  SATOR
                        AREPO
                        TENET
                        OPERA
                        ROTAS
                        */

using System;

public class exercicio_012{

    static void Main(){

        const int size = 4;
        char[,] matriz = new char[size,size];
        bool polindromo = false;

        Console.WriteLine("Informe uma matriz tipo char " + size + " x " + size + ": ");

        for (int i = 0; i < size; i++){
      
            for (int j = 0; j < size; j++){
            
                matriz[i,j] = char.Parse(Console.ReadLine());

            }
        }

        for (int i = 0; i < size; i++){
      
            for (int j = 0; j < size; j++){
            
                if (matriz[i,j] != matriz[(size-1) - i,(size - 1) - j]){
                    
                    polindromo = false;

                    break;
                }
            }
        }

        if (polindromo){
      
            Console.Write("Matriz:\n");

            for (int i = 0; i < size; i++){
        
                for (int j = 0; j < size; j++){
                    
                    Console.Write(matriz[i,j] + " ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("A matriz e um polindromo");
        }
        else{

            Console.WriteLine("Matriz:");

            for (int i = 0; i < size; i++){
        
                for (int j = 0; j < size; j++){
                
                    Console.Write(matriz[i,j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("A matriz nao e polidromo");
        }

    }
}
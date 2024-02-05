/*10. Faça um Programa que leia dois vetores com 10 elementos cada. Gere um terceiro vetor de 20 elementos, cujos valores deverão ser compostos pelos elementos intercalados dos dois outros vetores.*/

using System;

class exercicio_010{
    
    static void Main(){

        int[] a = new int[10];
        int[] b = new int[10];
        int[] c = new int[20];

        Console.WriteLine("Informe o vetor a:");

        for (int i = 0; i < 10; i++){
            
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Informe o vetor b:");

        for (int i = 0; i < 10; i++){
            
            b[i] = int.Parse(Console.ReadLine());
        }

        int y = 0;

        for (int i = 0; i < 20; i += 2){
            
            c[i] = a[y];
            y++;
        }

        int z = 0;

        for (int i = 1; i < 20; i += 2){
            
            c[i] = b[z];
            z++;
        }

        Console.Write("Valores de a e b intercalados: ");

        for (int i = 0; i < 20; i++){
            
            Console.Write(c[i] + " ");
        }
        
    }
}
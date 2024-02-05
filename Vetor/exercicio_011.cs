/*11. Altere o programa anterior, intercalando 3 vetores de 10 elementos cada.*/

using System;

class exercicio_010{
    
    static void Main(){

        int[] a = new int[10];
        int[] b = new int[10];
        int[] c = new int[10];
        int[] d = new int[30];

        Console.WriteLine("Informe o vetor a:");

        for (int i = 0; i < 10; i++){
            
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Informe o vetor b:");

        for (int i = 0; i < 10; i++){
            
            b[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Informe o vetor c:");

        for (int i = 0; i < 10; i++){
            
            c[i] = int.Parse(Console.ReadLine());
        }

        int y = 0;

        for (int i = 0; i < 30; i += 3){
            
            d[i] = a[y];
            y++;
        }

        int z = 0;

        for (int i = 1; i < 30; i += 3){
            
            d[i] = b[z];
            z++;
        }

        int w = 0;

        for (int i = 2; i < 30; i += 3){
            
            d[i] = c[w];
            w++;
        }

        Console.Write("Valores de a, b e c intercalados: ");

        for (int i = 0; i < 30; i++){
            
            Console.Write(d[i] + " ");
        }
        
    }
}
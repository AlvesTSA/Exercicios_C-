/*8. Faça um Programa que peça a idade e a altura de 5 pessoas, armazene cada informação no seu respectivo vetor. Imprima a idade e a altura na ordem inversa a ordem lida.*/

using System;

class exercicio_008{

    static void Main(){

        int[] idade = new int[5];
        float[] altura = new float[5];

        for (int i = 0; i < 5; i++){
            
            Console.Write("Informe a idade da pessoa " + (i + 1) + ": ");
            idade[i] = int.Parse(Console.ReadLine());
            Console.Write("Informe a altura da pessoa " + (i + 1) + ": ");
            altura[i] = float.Parse(Console.ReadLine());
        }

        for (int i = 4; i >= 0; i--){
            
            Console.WriteLine("Idade da pessoa " + (i + 1) + ": " + idade[i] + " anos");
            Console.WriteLine("Altura da pessoa " + (i + 1) + ": " + altura[i] + " m");
            Console.Write("\n\n");
        
        }
    }
}
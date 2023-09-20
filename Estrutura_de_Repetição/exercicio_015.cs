/*15. A série de Fibonacci é formada pela seqüência 1,1,2,3,5,8,13,21,34,55,... Faça um programa capaz de gerar a série até o n−ésimo termo.*/

using System;

class exercicio_015{

    static void Main(){

        int num1 = 0;
        int num2 = 1;
        int num3 = 0;
        int n = 0;

        Console.Write("Informe quantos termos deseja calcular: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++){
            
            num3 = num1 + num2;
            num1 = num2;
            num2 = num3;

            Console.Write(num1 + " ");
        }

    }
}
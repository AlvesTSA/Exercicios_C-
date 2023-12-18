/*21. Faça um programa que peça um número inteiro e determine se ele é ou não um número primo. Um número primo é aquele que é divisível somente por ele mesmo e por 1.*/

using System;

public class exercicio_021{
    static void Main(){

        int num = 0;
        int resto = 0;
        int divisivel = 0;

        Console.WriteLine("Informe um número inteiro: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++){
            
            resto = num % i;

            if (resto == 0){
                
                divisivel++;
            }
        }

        if (divisivel > 2){
            
            Console.WriteLine("primo: não");
        }
        else{

            Console.WriteLine("primo: sim");
        }
    }
}
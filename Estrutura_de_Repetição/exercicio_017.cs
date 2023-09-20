/*17. Faça um programa que calcule o fatorial de um número inteiro fornecido pelo usuário. Ex.: 5!=5.4.3.2.1=120 */

using System;

class exercicio_017{

    static void Main(){

        int num = 0;
        int fatorial = 0;
        int n = 0;
        
        Console.Write("Informe um número inteiro: ");
        num = int.Parse(Console.ReadLine());
        fatorial = num;
        n = num;
        Console.Write(num + "! = " + num);

        for (int i = n; i > 1; i--){
            
            num--;
            fatorial *= num;

            Console.Write(" X " + num);

        }

        Console.Write(" = " + fatorial);
    }
}
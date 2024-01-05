/*32. Faça um programa que calcule o fatorial de um número inteiro fornecido pelo usuário. Ex.: 5!=5.4.3.2.1=120. A saída deve ser conforme o exemplo abaixo:

Fatorial de: 5 

5! =  5 . 4 . 3 . 2 . 1 = 120 
*/

using System;

class exercicio_031{

    static void Main(){

        int num = 0;

        Console.Write("Informe um número ao qual deseja calcular o fatorial: ");
        num = int.Parse(Console.ReadLine());
        Console.Write(num + "! = " + num);

        for (int i = num -1; i > 0; i--){
            
            num = num * i;

            Console.Write(" . " + i);
        }

        Console.Write(" = " + num);

    }
}
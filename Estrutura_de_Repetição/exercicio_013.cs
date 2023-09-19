/*13. Faça um programa que peça dois números, base e expoente, calcule e mostre o primeiro número elevado ao segundo número. Não utilize a função de potência da linguagem.*/

using System;

class exercicio_013{

    static void Main(){

        int base_num = 0;
        int expoente = 0;
        int resultado = 0;
        int i = 0;

        Console.WriteLine("Informe a base: ");
        base_num = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o expoente: ");
        expoente = int.Parse(Console.ReadLine());

        resultado = base_num;

        for (i = 1; i < expoente; i++){
            
            resultado *= base_num;
        }

        Console.WriteLine("Resultado = " + resultado);
    }
}
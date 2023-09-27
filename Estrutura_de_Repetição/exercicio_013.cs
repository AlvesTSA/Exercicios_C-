/*13. Faça um programa que peça dois números, base e expoente, calcule e mostre o primeiro número elevado ao segundo número. Não utilize a função de potência da linguagem.*/

using System;

class exercicio_013{

    static void Main(){

        double base_num = 0;
        int expoente = 0;
        double resultado = 0;
        int i = 0;

        Console.WriteLine("Informe a base: ");
        base_num = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o expoente: ");
        expoente = int.Parse(Console.ReadLine());

        resultado = base_num;
        Console.Write(base_num + " elevado " + expoente + " = ");

        if (expoente > 0){

            i = 1;

            while (i != expoente){
                
                i++;
                resultado *= base_num;
            }
            
        }
        else if (expoente < 0){

            i = 1;
            expoente *= -1;

            while (i != expoente){
                
                i++;
                resultado *= base_num;
            }
            
            resultado = 1/resultado;
        }
        else{

            resultado = 1;
        }

        Console.WriteLine(resultado);
    }
}
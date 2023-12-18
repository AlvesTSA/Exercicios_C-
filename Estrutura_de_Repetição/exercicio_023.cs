/*23. Faça um programa que mostre todos os primos entre 1 e N sendo N um número inteiro fornecido pelo usuário. O programa deverá mostrar também o número de divisões que ele executou para encontrar os números primos. Serão avaliados o funcionamento, o estilo e o número de testes (divisões) executados.*/

using System;

public class exercicio_023{

    static void Main(){

        int n = 0;
        int resto = 0;
        int divisivel = 0;
        int divisoes = 0;

        Console.WriteLine("Informe um numero para determinar um intervalo de numeros primos: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++){
            
            divisivel = 0;

            for (int y = 1; y <= i; y++){
            
                resto = i % y;
                divisoes++;

                if (resto == 0){
                    
                    divisivel++;
                }
            }

            if (divisivel < 3){
                
                Console.WriteLine(i + " ");
            }
           

        }

        Console.WriteLine("Numeros total de divisoes: " + divisoes);
    }
}
/*20. Altere o programa de cálculo do fatorial, permitindo ao usuário calcular o fatorial várias vezes e limitando o fatorial a números inteiros positivos e menores que 16.*/

using System;

class exercicio_020{

    static void Main(){

        int num = 0;
        int fatorial = 0;
        int n = 0;
        int x = 0;

        do{
            
            do{

                Console.Write("Informe um número inteiro: ");
                num = int.Parse(Console.ReadLine());

                if (num <= 0 || num >= 16){
                    
                    Console.WriteLine("Erro: o numero deve ser positivo e menor que 16.");
                }

            } while (num <= 0 || num >= 16);
        
            fatorial = num;
            n = num;
            Console.Write(num + "! = " + num);

            for (int i = n; i > 1; i--){
                
                num--;
                fatorial *= num;

                Console.Write(" X " + num);

            }
    
            Console.WriteLine(" = " + fatorial);
            Console.WriteLine("Digite 1 para continuar ou 0 para sair.");
            x = int.Parse(Console.ReadLine());

        } while (x == 1);

    }
}
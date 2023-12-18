/*22. Altere o programa de cálculo dos números primos, informando, caso o número não seja primo, por quais número ele é divisível.*/

using System;

public class exercicio_022{
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

            for (int i = 1; i <= num; i++){
            
                resto = num % i;

                if (resto == 0){
                    
                    Console.WriteLine("Divisivel por: "+ i);
                }
            }
        }
        else{

            Console.WriteLine("primo: sim");
        }
    }
}
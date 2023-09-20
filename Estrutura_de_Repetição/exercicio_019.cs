/*19. . Altere o programa anterior para que ele aceite apenas números entre 0 e 1000.*/

using System;

class exercicio_019{

    static void Main(){

        int n = 0;
        int maior = 0;
        int menor = 0;
        int soma = 0;
        int num = 0;

        Console.Write("Informe quantos números deseja incluir: ");
        n = int.Parse(Console.ReadLine());

        do{

            num = int.Parse(Console.ReadLine());

            if (num < 0 || num > 1000){
                
                Console.WriteLine("Error: os numeros devem ser de 0 a 1000.");
            }
        } while (num < 0 || num > 1000);
        
        menor = num;
        maior = num;
        soma += num;

        for (int i = 1; i < n; i++){
            
            do{

            num = int.Parse(Console.ReadLine());

            if (num < 0 || num > 1000){
                
                Console.WriteLine("Error: os numeros devem ser de 0 a 1000.");
            }
        } while (num < 0 || num > 1000);

            soma += num;

            if (num < menor){
                
                menor = num;
            }
            else if(num > maior){

                maior = num;
            }

        }

        Console.Write("Maior = " + maior + "\nMenor = " + menor + "\nSoma = " + soma);
    }
}
/*15. Faça um programa que leia um número indeterminado de valores, correspondentes a notas, encerrando a entrada de dados quando for informado um valor igual a -1 (que não deve ser armazenado). Após esta entrada de dados, faça:

 a. Mostre a quantidade de valores que foram lidos; 

 b. Exiba todos os valores na ordem em que foram informados, um ao lado do outro; 

 c. Exiba todos os valores na ordem inversa à que foram informados, um abaixo do outro;

 d. Calcule e mostre a soma dos valores;
 
 e. Calcule e mostre a média dos valores;

 f. Calcule e mostre a quantidade de valores acima da média calculada;

 g. Calcule e mostre a quantidade de valores abaixo de sete;

 h. Encerre o programa com uma mensagem;

*/

using System;

class exercicio_015{

    static void Main(){

        float[] notas = new float[100];
        int contador = 0;

        Console.WriteLine("Informe as notas e digite -1 para finalizar:");

        while (true){
            
            notas[contador] = float.Parse(Console.ReadLine());

            if (notas[contador] == -1){
                
                break;
            }

            contador++;
        }

        //a. Mostre a quantidade de valores que foram lidos;
        Console.WriteLine("Quantidade de notas: " + contador);

        //b. Exiba todos os valores na ordem em que foram informados, um ao lado do outro;
        Console.WriteLine("Notas informadas:");
        for (int i = 0; i < contador; i++){
            
            Console.Write(notas[i] + " ");
        }

        //c. Exiba todos os valores na ordem inversa à que foram informados, um abaixo do outro;
        Console.WriteLine("\nNotas informadas na ordem inversa:");
        for (int i = contador - 1; i >= 0 ; i--){
            
            Console.WriteLine(notas[i]);
        }

        ///d. Calcule e mostre a soma dos valores;
        float soma = 0;
        Console.Write("\nSoma dos valores: ");
        for (int i = 0; i < contador; i++){
            
            soma += notas[i];
        }
        Console.Write(soma);

        //e. Calcule e mostre a média dos valores;
        float media = 0;
        media = soma/contador;
        Console.WriteLine("\nMedia dos valores: " + media);

        // f. Calcule e mostre a quantidade de valores acima da média calculada;
        int quant_acima = 0;
        for (int i = 0; i < contador; i++){
            
            if (notas[i] > media){
                
                quant_acima++;
            }
        }
        Console.WriteLine("Quantidade de notas acima da media: " + quant_acima);

        //g. Calcule e mostre a quantidade de valores abaixo de sete;
        int quant_abaixo7 = 0;
        for (int i = 0; i < contador; i++){
            
            if (notas[i] < 7){
                
                quant_abaixo7++;
            }
        }
        Console.WriteLine("Quantidade de notas abaixo de 7: " + quant_abaixo7);

        //h. Encerre o programa com uma mensagem;
        Console.WriteLine("\nMuito obrigado pela participacao");
    }
}
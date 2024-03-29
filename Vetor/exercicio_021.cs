/*21. Sua organização acaba de contratar um estagiário para trabalhar no Suporte de Informática, com a intenção de fazer um levantamento nas sucatas encontradas nesta área. A primeira tarefa dele é testar todos os cerca de 200 mouses que se encontram lá, testando e anotando o estado de cada um deles, para verificar o que se pode aproveitar deles. Foi requisitado que você desenvolva um programa para registrar este levantamento. O programa deverá receber um número indeterminado de entradas, cada uma contendo: um número de identificação do mouse o tipo de defeito: necessita da esfera; necessita de limpeza; a.necessita troca do cabo ou conector; a.quebrado ou inutilizado Uma identificação igual a zero encerra o programa. Ao final o programa deverá emitir o seguinte relatório:

Relatório de Mouses
 
    Situação	                          Quantidade	Percentual
    
1- Necessita da esfera	                    40	        40%
2- Necessita de limpeza	                    30	        30%
3- Necessita troca do cabo ou conector	    15	        15%
4- Quebrado ou inutilizado	                15	        15%
*/

using System;

class exercicio_021{
    
    static void Main(){

        int[] contador = new int[4];
        int[] percentual = new int[4];
        int total = 0;
        int op = 0;

        for (int i = 0; i < 200; i++){
            
            do{
                
                Console.WriteLine("Informe a situacao do mouse " + (i + 1));
                Console.WriteLine("1- Necessita da esfera\n2- Necessita de limpeza\n3- Necessita troca do cabo ou conecto\n4- Quebrado ou inutilizado");
                op = int.Parse(Console.ReadLine());

                if (op > 4 || op < 0){
                    
                    Console.WriteLine("ERRO: valor invalido\n");
                }

            } while (op > 4 || op < 0);
            
            if (op == 0){
                break;
            }

            contador[op - 1]++;
        }

        for (int i = 0; i < 4; i++){
            
            total += contador[i];
        }

        for (int i = 0; i < 4; i++){
        
            percentual[i] = (contador[i] * 100) / total;
        }

        Console.WriteLine("Relatorio de mouses\n");
        Console.WriteLine("    Situacao	                          Quantidade	Percentual\n");
        Console.WriteLine("1- Necessita da esfera	                 " + contador[0] +	"	             " + percentual[0]  + "%");
        Console.WriteLine("2- Necessita de limpeza	                 " + contador[1] +	"	             " + percentual[1]  + "%");
        Console.WriteLine("3- Necessita troca do cabo ou conector    " + contador[2] +	"	             " + percentual[2]  + "%");
        Console.WriteLine("4- Quebrado ou inutilizado	             " + contador[3] +	"	             " + percentual[3]  + "%");

    }
}
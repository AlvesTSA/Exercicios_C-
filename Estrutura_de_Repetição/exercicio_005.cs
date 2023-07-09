/*Altere o programa anterior permitindo ao usuário informar as populações e as taxas de crescimento iniciais. Valide a entrada e permita repetir a operação.
*/

using System;

class excercicio_005{

    static void Main(){

        double habitante_A = 0;
        double habitante_B = 0;
        double taxa_A = 0;
        double taxa_B = 0;
        int ano = 0;

        do{
            Console.WriteLine("Informe a população da cidade A: ");
            habitante_A = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a população da cidade B: ");
            habitante_B = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a taxa de crescimento da cidade A: ");
            taxa_A = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a taxa de crescimento da cidade B: ");
            taxa_B = double.Parse(Console.ReadLine());

            if(habitante_A >= habitante_B || taxa_A <= 0 || taxa_B <= 0){

                Console.WriteLine("ERRO: a população de A deve ser menor que a de B ou a taxa de crescimento deve ser maior que zero.");
            }

        } while (habitante_A >= habitante_B || taxa_A <= 0 || taxa_B <= 0);

        taxa_A = taxa_A/100;
        taxa_B = taxa_B/100;

        while(habitante_A < habitante_B){

            habitante_A = habitante_A*Math.Pow(1 + taxa_A, ano++);
            habitante_B = habitante_B*Math.Pow(1 + taxa_B, ano++);
        }

        Console.WriteLine("Anos necessários: " + ano);
    }
}
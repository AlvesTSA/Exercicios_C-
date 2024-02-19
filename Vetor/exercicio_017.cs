/*17. Em uma competição de salto em distância cada atleta tem direito a cinco saltos. O resultado do atleta será determinado pela média dos cinco valores restantes. Você deve fazer um programa que receba o nome e as cinco distâncias alcançadas pelo atleta em seus saltos e depois informe o nome, os saltos e a média dos saltos. O programa deve ser encerrado quando não for informado o nome do atleta. A saída do programa deve ser conforme o exemplo abaixo:

Atleta: Rodrigo Curvêllo
Primeiro Salto: 6.5 m
Segundo Salto: 6.1 m
Terceiro Salto: 6.2 m
Quarto Salto: 5.4 m
Quinto Salto: 5.3 m


Resultado final:
Atleta: Rodrigo Curvêllo
Saltos: 6.5 - 6.1 - 6.2 - 5.4 - 5.3
Média dos saltos: 5.9 m*/

using System;

class exercicio_017{

    static void Main(){

        float[] saltos = new float[5];
        float media = 0;
        string nome = " ";

        Console.WriteLine("Informe os dados e digite sair para finalizar\n");

        for (int i = 0; i < 100; i++){
            
            Console.Write("Atleta: ");
            nome = Console.ReadLine();

            if (nome == "sair"){
                break;
            }

            Console.Write("Primeiro salto: ");
            saltos[0] = float.Parse(Console.ReadLine());
            Console.Write("Segundo salto: ");
            saltos[1] = float.Parse(Console.ReadLine());
            Console.Write("Terceiro salto: ");
            saltos[2] = float.Parse(Console.ReadLine());
            Console.Write("Quarto salto: ");
            saltos[3] = float.Parse(Console.ReadLine());
            Console.Write("Quinto salto: ");
            saltos[4] = float.Parse(Console.ReadLine());

            media = 0;

            for (int y = 0; y < 5; y++){
                
                media += saltos[y];
            }

            media /= 5;

            Console.WriteLine("\n\nResultado final\n");
            Console.WriteLine("Atleta: " + nome);
            Console.WriteLine("Saltos: " + saltos[0] + " " + saltos[1] + " " + saltos[2] + " " + saltos[3] + " " + saltos[4]);
            Console.WriteLine("Media dos saltos: " + media + "\n\n"); 

        }
    }
}

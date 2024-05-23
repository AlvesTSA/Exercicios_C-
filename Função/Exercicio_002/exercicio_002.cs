/*2. Faça um programa com uma função chamada somaImposto. A função possui dois parâmetros formais: taxaImposto, que é a quantia de imposto sobre vendas expressa em porcentagem e custo, que é o custo de um item antes do imposto. A função “altera” o valor de custo para incluir o imposto sobre vendas.*/

class exercicio_002
{
    static void Main()
    {
        Console.Write("Informe o a taxa de imposto: ");
        float taxaImposto = float.Parse(Console.ReadLine());
        Console.Write("Informe o custo do preoduto: ");
        float custo = float.Parse(Console.ReadLine());

        float custo_final = SomaImposto(taxaImposto,custo);

        Console.WriteLine("Valor do produto com imposto: " + custo_final);

    }
    static float SomaImposto(float taxaImposto,float custo)
    {

        float custo_final = custo + (custo*(taxaImposto / 100));

        return custo_final;
    }
}


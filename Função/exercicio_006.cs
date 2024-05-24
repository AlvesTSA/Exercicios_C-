/*6. Faça uma função que recebe a idade de uma pessoa em anos, meses e dias e retorna essa idade expressa em dias.*/
using System;
class exercicio_006
{
    static void Main()
    {
        int a,m,d = 0;

        Console.Write("Informe os anos de sua idade: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Informe os meses de sua idade: ");
        m = int.Parse(Console.ReadLine());
        Console.Write("Informe os dias de sua idade: ");
        d = int.Parse(Console.ReadLine());

        d = TransformaIdade(a,m,d);

        Console.WriteLine("Voce tem {0} dias de idade.",d);
    }

    static int TransformaIdade(int anos,int meses,int dias){

        dias += anos * 365 + meses * 30;

        return dias;
    }
}


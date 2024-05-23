/*5. Faça uma função que recebe por parâmetro o tempo de duração de uma fábrica expressa em segundos e retorna também por parâmetro esse tempo em horas, minutos e segundos.*/

class exercicio_005
{
    static void Main()
    {
        int tEmSeg, h, m, s;

        Console.Write("Informe o tempo em segundos: ");
        tEmSeg = int.Parse(Console.ReadLine());

        ConverteTempo(tEmSeg, out h, out m, out s);

        Console.WriteLine("Horas: {0}", h);
        Console.WriteLine("Minutos: {0}", m);
        Console.WriteLine("Segundos: {0}", s);
    }
    static void ConverteTempo(int tempoEmSegundos, out int horas, out int minutos, out int segundos)
    {
        horas = tempoEmSegundos / 3600;  // Calcula o número de horas
        minutos = (tempoEmSegundos % 3600) / 60;  // Calcula o número de minutos
        segundos = tempoEmSegundos % 60;  // Calcula os segundos restantes
    }
}


/*4. Faça uma função que recebe por parâmetro o raio de uma esfera e calcula o seu volume (v = 4/3.P .R3).*/

class exercicio_004
{
    static void Main(){

        double r,v = 0;

        Console.Write("Informe o raio da esfera: ");
        r = double.Parse(Console.ReadLine());

        v = Calc_vol(r);
        string v_f = v.ToString("F2");
        Console.WriteLine("Volume da esfera: "+v_f);
    }

    static double Calc_vol(double r){
        
        double pi = 3.14159265358979323846;
        double v = (4.0/3.0)*pi*r*r*r;

        return v;
    }
}


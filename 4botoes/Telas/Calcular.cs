using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;


class Calcular
{
    /*
    public static void TamanhoTexto(Label tbx_Resultado)
    {
        int comprimentoTexto = tbx_Resultado.Text.Length;
        int tamanhoFonte = Math.Max(14, 45 - comprimentoTexto);
        tbx_Resultado.FontSize = new Font("Microsoft Sans Serif", tamanhoFonte);

        
    }*/

    public static double Adiçao(double N1, double N2)
    {

        return N1 + N2;

    }

    public static double Subtraçao(double N1, double N2)
    {

        return N1 - N2;

    }
    public static double Multiplicaçao(double N1, double N2)
    {


        return N1 * N2;

    }
    public static double Potencia(double N1)
    {
        double N2 = 2;
        return Math.Pow(N1, N2);

    }
    public static double PotenciaAoCubo(double N1)
    {
        double N2 = 3;
        return Math.Pow(N1, N2);

    }
    public static double Potenciacientifica(double N1, double N2)
    {
        return Math.Pow(N1, N2);
    }
    public static double Divisão(double N1, double N2)
    {

        return N1 / N2;

    }

    public static double Raiz(double N1)
    {
        return Math.Sqrt(N1);
    }

    public static double RaizCubica(double numero)
    {
        return Math.Pow(numero, 1.0 / 3.0);
    }

    public static double Porcentagem(double N1, double N2)
    {
        return (N2 / 100) * N1;
    }

    public static double LOG(double N1)
    {

        return Math.Log(N1);

    }

    public static double fatorial(double N1)
    {

        double resul = 1;

        for (int i = 2; i <= N1; i++)
        {
            resul *= i;
        }

        N1 = resul;

        return N1;

    }


    public static double Modulo(double N1, double N2)
    {
        return Math.IEEERemainder(N1, N2);

    }

}



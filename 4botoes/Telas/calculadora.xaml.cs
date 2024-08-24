namespace _4botoes.Telas;

public partial class calculadora : ContentPage
{
	public calculadora()
	{
		InitializeComponent();
	}

    double N1, N2, N3; string op;

    private void btn_0_Clicked(object sender, EventArgs e)
    {

        tbx_Resultado.Text = Convert.ToString(tbx_Resultado.Text + 0);
    }
    private void btn_1_Clicked(object sender, EventArgs e)
    {
        tbx_Resultado.Text = Convert.ToString(tbx_Resultado.Text + 1);
    }
    private void btn_2_Clicked(object sender, EventArgs e)
    {
        tbx_Resultado.Text = Convert.ToString(tbx_Resultado.Text + 2);
    }

    private void btn_3_Clicked(object sender, EventArgs e)
    {
        tbx_Resultado.Text = Convert.ToString(tbx_Resultado.Text + 3);
    }

    private void btn_4_Clicked(object sender, EventArgs e)
    {
        tbx_Resultado.Text = Convert.ToString(tbx_Resultado.Text + 4);
    }

    private void btn_5_Clicked(object sender, EventArgs e)
    {
        tbx_Resultado.Text = Convert.ToString(tbx_Resultado.Text + 5);
    }

    private void btn_6_Clicked(object sender, EventArgs e)
    {
        tbx_Resultado.Text = Convert.ToString(tbx_Resultado.Text + 6);
    }



    private void btn_7_Clicked(object sender, EventArgs e)
    {
        tbx_Resultado.Text = Convert.ToString(tbx_Resultado.Text + 7);
    }
    private void btn_8_Clicked(object sender, EventArgs e)
    {
        tbx_Resultado.Text = Convert.ToString(tbx_Resultado.Text + 8);
    }

    private void btn_9_Clicked(object sender, EventArgs e)
    {
        tbx_Resultado.Text = Convert.ToString(tbx_Resultado.Text + 9);
    }


    private void btn_vilgula_Clicked(object sender, EventArgs e)
    {
        if (!tbx_Resultado.Text.Contains("."))
        {
            tbx_Resultado.Text = Convert.ToString(tbx_Resultado.Text + ".");
        }
    }


    private void btn_inverter_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbx_Resultado.Text))
        {

            double valorAtual = Convert.ToDouble(tbx_Resultado.Text);
            valorAtual = -valorAtual;
            tbx_Resultado.Text = Convert.ToString(valorAtual);
        }
    }

    private void btn_Mais_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbx_2.Text) && !string.IsNullOrEmpty(tbx_Resultado.Text))
        {

            switch (op)
            {

                case "-":
                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Subtraçao(N1, N2));
                        N2 = 0;
                    }

                    break;
                case "/":

                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Divisão(N1, N2));
                        N2 = 0;

                    }
                    break;
                case "X":
                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = N2 + Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Multiplicaçao(N1, N2));
                        N2 = 0;
                    }
                    break;
            }


        }

        if (op == null)
        {
            op = "+";
        }


        if (!string.IsNullOrEmpty(tbx_2.Text) && string.IsNullOrEmpty(tbx_Resultado.Text))
        {

            tbx_2.Text = tbx_2.Text.Substring(0, tbx_2.Text.Length - 1);
            tbx_2.Text = tbx_2.Text + "+";
            op = "+";

        }

        if (!string.IsNullOrEmpty(tbx_Resultado.Text) && op == "+")
        {
            N1 = N1 + Convert.ToDouble(tbx_Resultado.Text);
            tbx_2.Text = Convert.ToString(tbx_Resultado.Text + " +");
            tbx_Resultado.Text = "";
        }

        if (!string.IsNullOrEmpty(tbx_Resultado.Text))
        {
            op = "+";
            N1 = Convert.ToDouble(tbx_Resultado.Text);
            tbx_2.Text = Convert.ToString(tbx_Resultado.Text + " +");
            tbx_Resultado.Text = "";
        }
    }

    private void btm_Menos_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbx_2.Text) && !string.IsNullOrEmpty(tbx_Resultado.Text))
        {

            switch (op)
            {

                case "+":

                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Adiçao(N1, N2));
                        N2 = 0;
                    }

                    break;

                case "/":

                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Divisão(N1, N2));
                        N2 = 0;

                    }
                    break;
                case "X":
                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Multiplicaçao(N1, N2));
                        N2 = 0;
                    }
                    break;
            }


        }

        if (op == null)
        {
            op = "-";
        }



        if (!string.IsNullOrEmpty(tbx_2.Text))
        {
            tbx_2.Text = tbx_2.Text.Substring(0, tbx_2.Text.Length - 1);
            tbx_2.Text = tbx_2.Text + "-";
            op = "-";
        }

        if (!string.IsNullOrEmpty(tbx_Resultado.Text) && op == "-")
        {
            N1 = +Convert.ToDouble(tbx_Resultado.Text);
            tbx_2.Text = Convert.ToString(tbx_Resultado.Text + " -");
            tbx_Resultado.Text = "";
        }

        if (!string.IsNullOrEmpty(tbx_Resultado.Text))
        {
            op = "-";
            N1 = Convert.ToDouble(tbx_Resultado.Text);
            tbx_2.Text = Convert.ToString(tbx_Resultado.Text + " -");
            tbx_Resultado.Text = "";
        }
    }

    private void btn_mult_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbx_2.Text) && !string.IsNullOrEmpty(tbx_Resultado.Text))
        {

            switch (op)
            {

                case "+":

                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Adiçao(N1, N2));
                        N2 = 0;
                    }

                    break;

                case "/":

                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Divisão(N1, N2));
                        N2 = 0;

                    }
                    break;
                case "-":
                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Subtraçao(N1, N2));
                        N2 = 0;
                    }
                    break;
            }


        }

        if (op == null)
        {
            op = "X";
        }


        if (!string.IsNullOrEmpty(tbx_2.Text) && string.IsNullOrEmpty(tbx_Resultado.Text))
        {
            tbx_2.Text = tbx_2.Text.Substring(0, tbx_2.Text.Length - 1);
            tbx_2.Text = tbx_2.Text + "X";
            op = "X";

        }

        if (!string.IsNullOrEmpty(tbx_Resultado.Text) && op == "X" && string.IsNullOrEmpty(tbx_2.Text))
        {
            N1 = Convert.ToDouble(tbx_Resultado.Text);
            tbx_2.Text = Convert.ToString(tbx_Resultado.Text + " X");
            tbx_Resultado.Text = "";
        }

        if (!string.IsNullOrEmpty(tbx_Resultado.Text) && op == "X")
        {
            if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
            {
                N2 = Convert.ToDouble(tbx_Resultado.Text);
                tbx_Resultado.Text = Convert.ToString(Calcular.Multiplicaçao(N1, N2));
                N2 = 0;

            }
        }

        if (!string.IsNullOrEmpty(tbx_Resultado.Text))
        {
            op = "X";
            N1 = Convert.ToDouble(tbx_Resultado.Text);
            tbx_2.Text = Convert.ToString(tbx_Resultado.Text + " X");
            tbx_Resultado.Text = "";
        }
    }

    private void btn_divisao_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbx_2.Text) && !string.IsNullOrEmpty(tbx_Resultado.Text))
        {

            switch (op)
            {

                case "+":

                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Adiçao(N1, N2));
                        N2 = 0;
                    }

                    break;

                case "-":
                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Subtraçao(N1, N2));
                        N2 = 0;
                    }

                    break;
                case "X":
                    if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                    {
                        N2 = Convert.ToDouble(tbx_Resultado.Text);
                        tbx_Resultado.Text = Convert.ToString(Calcular.Multiplicaçao(N1, N2));
                        N2 = 0;

                    }
                    break;
            }


        }

        if (op == null)
        {
            op = "/";
        }


        op = "/";
        if (!string.IsNullOrEmpty(tbx_2.Text))
        {
            tbx_2.Text = tbx_2.Text.Substring(0, tbx_2.Text.Length - 1);
            tbx_2.Text = tbx_2.Text + "/";
        }

        if (!string.IsNullOrEmpty(tbx_Resultado.Text) && op == "/" && string.IsNullOrEmpty(tbx_2.Text))
        {
            N1 = Convert.ToDouble(tbx_Resultado.Text);
            tbx_2.Text = Convert.ToString(tbx_Resultado.Text + " /");
            tbx_Resultado.Text = "";
        }

        if (!string.IsNullOrEmpty(tbx_Resultado.Text) && op == "/")
        {
            if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
            {
                N2 = Convert.ToDouble(tbx_Resultado.Text);
                tbx_Resultado.Text = Convert.ToString(Calcular.Divisão(N1, N2));
                N2 = 0;

            }
        }

        if (!string.IsNullOrEmpty(tbx_Resultado.Text))
        {
            op = "/";
            N1 = Convert.ToDouble(tbx_Resultado.Text);
            tbx_2.Text = Convert.ToString(tbx_Resultado.Text + " /");
            tbx_Resultado.Text = "";
        }
    }

    private void btn_potenciacao_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(tbx_Resultado.Text))
        {
            N1 = Convert.ToDouble(tbx_Resultado.Text);
            op = "potencia";
            tbx_2.Text = Convert.ToString(tbx_Resultado.Text + " ^ 2");
            tbx_Resultado.Text = "";
            tbx_Resultado.Text = Convert.ToString(Calcular.Potencia(N1));
            N2 = 0;
        }
    }

    private void btn_Apagar_Tudo_Clicked(object sender, EventArgs e)
    {
        tbx_Resultado.Text = Convert.ToString("");
        tbx_2.Text = Convert.ToString("");
        N1 = 0;
        N2 = 0;
    }

    private void btn_Apagar_Clicked(object sender, EventArgs e)
    {
        string quantcaracter = tbx_Resultado.Text;

        if (quantcaracter.Length > 0)
        {

            quantcaracter = quantcaracter.Substring(0, quantcaracter.Length - 1);
            tbx_Resultado.Text = quantcaracter;

        }
    }
    private void btn_resultado_Clicked(object sender, EventArgs e)
    {

        switch (op)
        {

            case "+":

                if (string.IsNullOrEmpty(tbx_2.Text))
                {

                    N2 = N3;
                    N1 = Convert.ToDouble(tbx_Resultado.Text);
                    tbx_Resultado.Text = Convert.ToString(Calcular.Adiçao(N1, N2));
                }

                if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                {
                    N2 = Convert.ToDouble(tbx_Resultado.Text);
                    N3 = N2;
                    tbx_2.Text = "";
                    tbx_Resultado.Text = Convert.ToString(Calcular.Adiçao(N1, N2));
                    N2 = 0;
                    N1 = 0;
                }

                break;
            case "-":
                if (string.IsNullOrEmpty(tbx_2.Text))
                {
                    N2 = N3;
                    N1 = Convert.ToDouble(tbx_Resultado.Text);
                    tbx_Resultado.Text = Convert.ToString(Calcular.Subtraçao(N1, N2));
                }
                if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                {
                    N2 = Convert.ToDouble(tbx_Resultado.Text);
                    N3 = N2;
                    tbx_2.Text = "";
                    tbx_Resultado.Text = Convert.ToString(Calcular.Subtraçao(N1, N2));
                    N2 = 0;
                    N1 = 0;
                }
                break;
            case "/":
                if (string.IsNullOrEmpty(tbx_2.Text))
                {
                    N2 = N3;
                    N1 = Convert.ToDouble(tbx_Resultado.Text);
                    tbx_Resultado.Text = Convert.ToString(Calcular.Divisão(N1, N2));
                }
                if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                {
                    N2 = Convert.ToDouble(tbx_Resultado.Text);
                    N3 = N2;
                    tbx_2.Text = "";
                    tbx_Resultado.Text = Convert.ToString(Calcular.Divisão(N1, N2));
                    N2 = 0;
                    N1 = 0;
                }
                break;
            case "X":
                if (string.IsNullOrEmpty(tbx_2.Text))
                {
                    N2 = N3;
                    N1 = Convert.ToDouble(tbx_Resultado.Text);
                    tbx_Resultado.Text = Convert.ToString(Calcular.Multiplicaçao(N1, N2));
                }
                if (!string.IsNullOrEmpty(tbx_Resultado.Text) && !string.IsNullOrEmpty(tbx_2.Text))
                {
                    N2 = N2 + Convert.ToDouble(tbx_Resultado.Text);
                    N3 = N2;
                    tbx_2.Text = "";
                    tbx_Resultado.Text = Convert.ToString(Calcular.Multiplicaçao(N1, N2));
                    N2 = 0;
                    N1 = 0;
                }
                break;
            case "porcentagem":
                if (!string.IsNullOrEmpty(tbx_Resultado.Text))
                {
                    N2 = N2 + Convert.ToDouble(tbx_Resultado.Text);
                    tbx_2.Text = "";
                    tbx_Resultado.Text = Convert.ToString(Calcular.Porcentagem(N1, N2));
                    N1 = 0;
                    N2 = 0;
                }
                break;


        }
    }

}

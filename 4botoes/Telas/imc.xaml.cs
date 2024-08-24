namespace _4botoes.Telas;

public partial class imc : ContentPage
{
	public imc()
	{
		InitializeComponent();

	}

    double altura, peso, resultado;
    private void Button_Clicked(object sender, EventArgs e)
    {
        altura = Convert.ToDouble(valor1.Text);
        peso = Convert.ToDouble(valor2.Text);
        resultado =  peso / (altura * altura);

        if (resultado < 18.5)
        {
            tbx_resultado.Text = "vc é muito magro";
            tbx_resultado2.Text = Convert.ToString(resultado);
        }

        if (resultado > 18.55 && resultado < 24.9)
        { 
            tbx_resultado.Text = "seu peso está adequado";
            tbx_resultado2.Text = Convert.ToString(resultado);

        }

        if(resultado > 25 && resultado < 29.9)
        {
            tbx_resultado.Text = "você está com sobrepeso";
            tbx_resultado2.Text = Convert.ToString(resultado);
        }

        if (resultado > 30 && resultado < 39.9)
        {
            tbx_resultado.Text = "você está com obesidade";
            tbx_resultado2.Text = Convert.ToString(resultado);
        }

        if (resultado > 40)
        {
            tbx_resultado.Text = "você está com obesidade grave";
            tbx_resultado2.Text = Convert.ToString(resultado);
        }
    }
}
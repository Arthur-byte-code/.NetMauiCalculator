namespace _4botoes.Telas;

public partial class soma : ContentPage
{
	public soma()
	{
		InitializeComponent();
	}
    double v1, v2;

    private void Button_Clicked(object sender, EventArgs e)
    {
        v1 = Convert.ToDouble(valor1.Text);
        v2 = Convert.ToDouble(valor2.Text);
        tbx_resultado.Text = Convert.ToString(v1 + v2);
    }
}
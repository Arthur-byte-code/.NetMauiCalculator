namespace _4botoes.Telas;

public partial class media : ContentPage
{
	public media()
	{
		InitializeComponent();
	}
    double v1, v2, v3, v4;

    private void Button_Clicked(object sender, EventArgs e)
    {
        v1 = Convert.ToDouble(valor1.Text);
        v2 = Convert.ToDouble(valor2.Text);
        v3 = Convert.ToDouble(valor3.Text);
        v4 = Convert.ToDouble(valor4.Text);
        tbx_resultado.Text = Convert.ToString((v1 + v2 + v3 + v4) / 4);
    }
}
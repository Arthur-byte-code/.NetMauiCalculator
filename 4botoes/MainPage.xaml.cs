using _4botoes.Telas;

namespace _4botoes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSoma_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new soma());
        }

        private void BtnImc_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new imc());
        }

        private void BtnMedia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new media());
        }

        private void BtnCalculadora_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new calculadora());
        }

        private void BtnImagem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new imagem());
        }
    }

}

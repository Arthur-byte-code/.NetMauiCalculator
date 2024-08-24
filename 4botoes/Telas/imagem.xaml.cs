namespace _4botoes.Telas;

public partial class imagem : ContentPage
{
	public imagem()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {

            
     
		webView.Source = new UrlWebViewSource { Url = "https://www.youtube.com/watch?v=BHACKCNDMW8" };
        webView.IsVisible = true;


    }
}
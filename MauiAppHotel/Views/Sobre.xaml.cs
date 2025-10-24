namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private async void Button_voltarSobre(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.ContratacaoHospedagem());
    }
}
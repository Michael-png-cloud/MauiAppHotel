namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    void OnButtonClicked(object sender, EventArgs e)
    {
        // Ação ao clicar no botão
        ((Button)sender).Text = "Clicado!";
    }
}
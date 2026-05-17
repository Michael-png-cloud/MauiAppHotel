namespace MauiAppHotel.Views;

public partial class FaleConosco : ContentPage
{
	public FaleConosco()
	{
        InitializeComponent();
	}


    private void Button_Clicked_1 (object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

}
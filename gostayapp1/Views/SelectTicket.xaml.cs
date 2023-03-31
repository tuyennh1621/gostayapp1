namespace gostayapp1.Views;

public partial class SelectTicket : ContentPage
{
	public SelectTicket()
	{
        InitializeComponent();
    }
    private async void OnCounterClicked5(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainAirPlane());
    }
}




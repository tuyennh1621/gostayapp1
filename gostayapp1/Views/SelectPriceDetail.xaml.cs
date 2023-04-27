namespace gostayapp1.Views;

public partial class SelectPriceDetail : ContentPage
{
	public SelectPriceDetail()
	{
		InitializeComponent();
	}
    private async void FlightBooking(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlightBooking());
    }

}
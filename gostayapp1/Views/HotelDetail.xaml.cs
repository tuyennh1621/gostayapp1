namespace gostayapp1.Views;

public partial class HotelDetail : ContentPage
{
	public HotelDetail()
	{
		InitializeComponent();
	}
    private async void SelectRoom(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SelectRoom());
    }
    private async void Rating(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Rating());
    }
    private async void HotelBooking(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HotelBooking());
    }

}
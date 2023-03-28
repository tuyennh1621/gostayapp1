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
}
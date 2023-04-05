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
    private bool _collapsed = false;
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        listView.IsVisible = !_collapsed;
        xemthem.Text = (listView.IsVisible = !_collapsed) ? "Thu gọn" : "Xem thêm";
        _collapsed = !_collapsed;
    }

}
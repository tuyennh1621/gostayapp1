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

    private bool _collapsed1 = false;
    void Button_Clicked1(System.Object sender, System.EventArgs e)
    {
        listView1.IsVisible = !_collapsed1;
        xemthem1.Text = (listView1.IsVisible = !_collapsed1) ? "Thu gọn" : "Xem thêm";
        _collapsed1 = !_collapsed1;
    }

    private bool _collapsed2 = false;
    void Button_Clicked2(System.Object sender, System.EventArgs e)
    {
        listView2.IsVisible = !_collapsed2;
        xemthem2.Text = (listView2.IsVisible = !_collapsed2) ? "Thu gọn" : "Xem thêm";
        _collapsed2 = !_collapsed2;
    }

}
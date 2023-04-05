namespace gostayapp1.Views;

public partial class TourDetails : ContentPage
{
    public TourDetails()
    {
        InitializeComponent();
    }
    private async void SelectGuest(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SelectGuest());
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

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        icon.RotateTo(_collapsed1 ? 180 : 0);
        items.IsVisible = !_collapsed1;
        _collapsed1 = !_collapsed1;
    }

    private bool _collapsed2 = false;

    private void TapGestureRecognizer_Tapped1(object sender, TappedEventArgs e)
    {
        icon1.RotateTo(_collapsed2 ? 180 : 0);
        items1.IsVisible = !_collapsed2;
        _collapsed2 = !_collapsed2;
    }

}
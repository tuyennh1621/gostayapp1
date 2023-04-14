namespace gostayapp1.Views;

public partial class TourBookingPayment : ContentPage
{
    public TourBookingPayment()
    {
        InitializeComponent();
    }

    private async void Confirmed_Payment(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TourBookingSuccess());
    }

    private bool _collapsed = false;
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        items.IsVisible = !_collapsed;
        _collapsed = !_collapsed;
    }
}
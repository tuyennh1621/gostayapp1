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
}
namespace gostayapp1.Views;

public partial class FlightBooking : ContentPage
{
	public FlightBooking()
	{
		InitializeComponent();
	}
    private void CheckBox_Focused(object sender, FocusEventArgs e)
    {

    }
    private async void Button_Clicked3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TourBookingPayment());
    }

    private async void TabFlight(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new TabFlight());
    }

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Picker picker = new Picker { Title = "Select a monkey" };
        picker.SetBinding(Picker.ItemsSourceProperty, "Monkeys");
        picker.ItemDisplayBinding = new Binding("Name");
    }
    private async void SelectPriceDetail(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SelectPriceDetail());
    }
    private async void TicketInformation(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TicketInformation());
    }

    private bool _collapsed = false;
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        items.IsVisible = !_collapsed;
        _collapsed = !_collapsed;
    }
}
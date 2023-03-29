namespace gostayapp1.Views;

public partial class HotelBooking : ContentPage
{
	public HotelBooking()
	{
		InitializeComponent();
	}
    private void CheckBox_Focused(object sender, FocusEventArgs e)
    {

    }
    private async void Button_Clicked3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HotelBookingPayment());
    }

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Picker picker = new Picker { Title = "Select a monkey" };
        picker.SetBinding(Picker.ItemsSourceProperty, "Monkeys");
        picker.ItemDisplayBinding = new Binding("Name");
    }

    private bool collapsed = false;
    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await icon.RotateTo(!collapsed ? 180 : 0);
        items.IsVisible = !collapsed;
        collapsed = !collapsed;
    }

    private async void TapGestureRecognizer_Tapped1(object sender, TappedEventArgs e)
    {
        await icon1.RotateTo(!collapsed ? 180 : 0);
        items1.IsVisible = !collapsed;
        collapsed = !collapsed;
    }
}
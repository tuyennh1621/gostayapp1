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
    //private async void Button_Clicked3(object sender, EventArgs e)
    //{
    //    await Navigation.PushAsync(new HotelBookingPayment());
    //}

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Picker picker = new Picker { Title = "Select a monkey" };
        picker.SetBinding(Picker.ItemsSourceProperty, "Monkeys");
        picker.ItemDisplayBinding = new Binding("Name");
    }
}
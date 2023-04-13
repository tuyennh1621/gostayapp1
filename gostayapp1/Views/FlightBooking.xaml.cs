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

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        Picker picker = new Picker { Title = "Select a monkey" };
        picker.SetBinding(Picker.ItemsSourceProperty, "Monkeys");
        picker.ItemDisplayBinding = new Binding("Name");
    }
    void OnStepper(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        _displayLabel.Text = string.Format("{0}", value);
    }
    void OnStepper1(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        _displayLabel1.Text = string.Format("{0}", value);
    }
    void OnStepper2(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        _displayLabel2.Text = string.Format("{0}", value);
    }
    void OnStepper3(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        _displayLabel3.Text = string.Format("{0}", value);
    }
}
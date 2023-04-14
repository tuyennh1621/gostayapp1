using System.Globalization;

namespace gostayapp1.Views;

public partial class Filters : ContentPage
{
	public Filters()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lbPrice.Text = "Khoảng giá: 0 - " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", 100000 * Math.Round(e.NewValue, 0)) + " vnđ";
    }

    private async void SelectDeparture(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TabFlight());
    }
}
namespace gostayapp1.Views;

public partial class TabPlanePrice : ContentPage
{
	public TabPlanePrice()
	{
		InitializeComponent();
	}

    private bool _collapsed = false;
    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        bool v = await icon.RotateTo(!_collapsed ? 180 : 0);
        items.IsVisible = !_collapsed;
        _collapsed = !_collapsed;
    }
}
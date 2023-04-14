using gostayapp1.Models;
namespace gostayapp1.Views;

public partial class TabFlight : ContentPage
{
	public TabFlight()
	{
		InitializeComponent();
	}

    private bool _collapsed = false;

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        listView.IsVisible = !_collapsed;
        xemthem.Text = (listView.IsVisible = !_collapsed) ? "Thu gọn" : "Xem thêm";
        _collapsed = !_collapsed;
    }

    private void PlaneListing(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PlaneArrivals());
    }
}
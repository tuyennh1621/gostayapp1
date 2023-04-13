using gostayapp1.Models;
namespace gostayapp1.Views;

public partial class Departure : ContentPage
{
	public Departure()
	{
		InitializeComponent();
	}
    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string catName = (e.CurrentSelection.FirstOrDefault() as Plane).Name;
        await Shell.Current.GoToAsync($"catdetails?name={catName}");
    }
    private bool _collapsed = false;

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        listView.IsVisible = !_collapsed;
        xemthem.Text = (listView.IsVisible = !_collapsed) ? "Thu gọn" : "Xem thêm";
        _collapsed = !_collapsed;
    }
}
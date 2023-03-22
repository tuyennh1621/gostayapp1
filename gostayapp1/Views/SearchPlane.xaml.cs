using gostayapp1.Models;
namespace gostayapp1.Views;

public partial class SearchPlane : ContentPage
{
	public SearchPlane()
	{
		InitializeComponent();
	}
    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string catName = (e.CurrentSelection.FirstOrDefault() as Plane).Name;
        await Shell.Current.GoToAsync($"catdetails?name={catName}");
    }
}
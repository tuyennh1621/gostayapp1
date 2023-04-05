using gostayapp1.Models;
namespace gostayapp1.Views;

public partial class SearchTours : ContentPage
{
	public SearchTours()
	{
		InitializeComponent();
	}
    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string catName = (e.CurrentSelection.FirstOrDefault() as TourDt).Name;
        await Shell.Current.GoToAsync($"tourdetails?name={catName}");
    }
}
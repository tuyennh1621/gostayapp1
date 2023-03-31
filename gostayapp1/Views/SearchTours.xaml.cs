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
        // The following route works because route names are unique in this application.
        await Shell.Current.GoToAsync($"tourdetails?name={catName}");
        // The full route is shown below.
        // await Shell.Current.GoToAsync($"//animals/domestic/cats/catdetails?name={catName}");
    }
}
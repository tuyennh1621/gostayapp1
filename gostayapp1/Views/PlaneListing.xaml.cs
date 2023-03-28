using gostayapp1.Models;
namespace gostayapp1.Views;

public partial class PlaneListing : ContentPage
{
	public PlaneListing()
	{
		InitializeComponent();
	}

    private async void Filters(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Filters());
    }
    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string catName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;
        await Shell.Current.GoToAsync($"catdetails?name={catName}");
    }
}

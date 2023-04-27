using gostayapp1.Models;
namespace gostayapp1.Views;

public partial class SelectNationality : ContentPage
{
	public SelectNationality()
	{
		InitializeComponent();
	}

    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string catName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;
        await Shell.Current.GoToAsync($"PersonInfo?name={catName}");
    }
}
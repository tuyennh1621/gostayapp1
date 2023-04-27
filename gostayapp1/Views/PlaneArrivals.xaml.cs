using gostayapp1.Models;
using Microsoft.Maui.Controls;

namespace gostayapp1.Views;

public partial class PlaneArrivals : ContentPage
{
    public PlaneArrivals()
    {
        InitializeComponent();
    }

    private async void Filters(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Filters());
    }

    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string catName = (e.CurrentSelection.FirstOrDefault() as Plane).Name;
        await Shell.Current.GoToAsync($"TabFlightArrivals?name={catName}");
    }

    private void PlaneListing(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PlaneDeparture());
    }

}

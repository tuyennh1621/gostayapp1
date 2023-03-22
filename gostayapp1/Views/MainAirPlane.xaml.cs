using gostayapp1.Models;

namespace gostayapp1.Views;

public partial class MainAirPlane : ContentPage
{

    public MainAirPlane()
    {
        InitializeComponent();
        DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(2018, 1, 1),
            MaximumDate = new DateTime(2018, 12, 31),
            Date = new DateTime(2018, 6, 21)
        };
    }
    private void SelectGuest(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SelectGuest());
    }
    private void ItemDetail(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new Welcome()); ;
    }
    private async void SearchPlane(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SearchPlane());
    }
    private async void PlaneListing(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PlaneListing());
    }

    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string catName = (e.CurrentSelection.FirstOrDefault() as Plane).Name;
        await Shell.Current.GoToAsync($"catdetails?name={catName}");
    }
}
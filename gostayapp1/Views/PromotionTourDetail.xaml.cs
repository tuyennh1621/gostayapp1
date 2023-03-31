using gostayapp1.Models;
namespace gostayapp1.Views;

public partial class PromotionTourDetail : ContentPage
{
	public PromotionTourDetail()
	{
		InitializeComponent();
	}
    //private void AirPlane(object sender, TappedEventArgs e)
    //{
    //    Navigation.PushAsync(new AirPlane()); ;
    //}
    //private void HotelDetail(object sender, TappedEventArgs e)
    //{
    //    Navigation.PushAsync(new HotelDetail()); ;
    //}
    async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string catName = (e.CurrentSelection.FirstOrDefault() as Plane).Name;
        await Shell.Current.GoToAsync($"catdetails?name={catName}");
    }
}
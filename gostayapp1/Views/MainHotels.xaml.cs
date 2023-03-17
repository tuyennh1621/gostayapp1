namespace gostayapp1.Views;

public partial class MainHotels : ContentPage
{
    public MainHotels()
    {
        InitializeComponent();
        DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(2018, 1, 1),
            MaximumDate = new DateTime(2018, 12, 31),
            Date = new DateTime(2018, 6, 21)
        };
    }
    private async void SearchCollapse(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SearchCollapse());
    }

    private async void SelectRoom(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SelectRoom());
    }

}
namespace gostayapp1.Views;

public partial class PersonInfo : ContentPage
{
    public PersonInfo()
    {
        InitializeComponent();
        DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(1900, 1, 1),
            MaximumDate = new DateTime(2023, 12, 31),
            Date = new DateTime(2023, 6, 21)
        };
    }
    private async void TicketInfo(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TicketInformation());
    }
    private async void SelectNationality(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SelectNationality());
    }
}

namespace gostayapp1.Views;

public partial class TicketInformation : ContentPage
{
	public TicketInformation()
	{
		InitializeComponent();
	}
    private async void ContactInformation(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ContactInformation());
    }
    private async void PersonInfo(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new PersonInfo());
    }
}
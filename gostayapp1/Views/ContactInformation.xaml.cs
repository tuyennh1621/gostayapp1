namespace gostayapp1.Views;

public partial class ContactInformation : ContentPage
{
	public ContactInformation()
	{
		InitializeComponent();
	}
    private async void TicketInfo(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TicketInformation());
    }
}
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
}

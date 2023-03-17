using gostayapp1.ViewModels;

namespace gostayapp1.Views
{
    public partial class EmptyViewLoadSimulationPage : ContentPage
    {
        public EmptyViewLoadSimulationPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(2000);
            carouselView.ItemsSource = (BindingContext as MonkeysViewModel).Monkeys;
        }
    }
}

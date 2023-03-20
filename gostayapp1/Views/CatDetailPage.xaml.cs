using gostayapp1.Data;
using gostayapp1.Models;

namespace gostayapp1.Views
{
    [QueryProperty(nameof(Name), "name")]
    public partial class CatDetailPage : ContentPage
    {
        public string Name
        {
            set
            {
                LoadAnimal(value);
            }
        }

        public CatDetailPage()
        {
            InitializeComponent();
        }

        void LoadAnimal(string name)
        {
            try
            {
                Animal animal = HotelData.Hotels.FirstOrDefault(a => a.Name == name);
                BindingContext = animal;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load animal.");
            }
        }
    }
}

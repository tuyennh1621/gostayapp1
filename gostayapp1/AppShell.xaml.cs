using System.Windows.Input;
using gostayapp1.Views;

namespace gostayapp1;

public partial class AppShell : Shell
{
    public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    public AppShell()
    {
        InitializeComponent();
        RegisterRoutes();
        BindingContext = this;
    }

    void RegisterRoutes()
    {
        Routes.Add("catdetails", typeof(HotelDetail));
        Routes.Add("tourdetails", typeof(TourDetails));
        Routes.Add("promotionList", typeof(PromotionList));
        Routes.Add("discovery", typeof(Discovery));
        Routes.Add("orderlist", typeof(OrderList));

        foreach (var item in Routes)
        {
            Routing.RegisterRoute(item.Key, item.Value);
        }
    }

}

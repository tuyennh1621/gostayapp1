
//using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;

namespace gostayapp1.Views;

public partial class Discovery : ContentPage
{
    public Discovery()
    {
        //InitializeComponent();
        Map map = new Map();
        Content = map;
    }
}


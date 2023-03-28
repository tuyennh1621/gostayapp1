using gostayapp1.ViewModels;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using gostayapp1.Models;
using gostayapp1.Data;


namespace gostayapp1.Views;


public partial class HotelListing : ContentPage
{
    public HotelListing()
    {
        InitializeComponent();
        DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(2018, 1, 1),
            MaximumDate = new DateTime(2018, 12, 31),
            Date = new DateTime(2018, 6, 21)
        };

     //   BindingContext = new HotelList();
      

    }

   

    private async void SearchCollapse(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SearchCollapse());
    }


    //public Common.ResponseBase<PagingList<HotelDto>> GetHotelList(RequestGetListHotel request)
    //{
    //    var response = Post<RequestGetListHotel, PagingList<HotelDto>>("hotel/list", request);
    //    return response;
    //}

    private async void SelectRoom(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SelectRoom());
    }

    //private void AirPlane(object sender, TappedEventArgs e)
    //{
    //    Navigation.PushAsync(new SelectAirplane());
    //}

    //private void SelectSeat(object sender, TappedEventArgs e)
    //{
    //    Navigation.PushAsync(new SelectSeatPlane());
    //}

    //private void SelectTour(object sender, TappedEventArgs e)
    //{
    //    Navigation.PushAsync(new TourDetail());
    //}

    //private async void HotelDetail(object sender, TappedEventArgs e)
    //{
    //    await Navigation.PushAsync(new HotelDetail()); ;
    //}

    //private async void HotelDetail(object sender, EventArgs e)
    //{
    //    await Navigation.PushAsync(new HotelDetail()); ;
    //}

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Welcome());
    }

    //private async void PromotionDetail(object sender, TappedEventArgs e)
    //{
    //    await Navigation.PushAsync(new PromotionDetail()); ;
    //}

    private async void FiltersHotel(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FiltersHotel());
    }
}



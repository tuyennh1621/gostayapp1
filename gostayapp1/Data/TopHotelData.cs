using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gostayapp1.Models;

namespace gostayapp1.Data
{
    public static class HotelTopData
    {
        public static IList<Animal> Hotels { get; private set; }

        static HotelTopData()
        {
            Hotels = new List<Animal>();

            Hotels.Add(new Animal
            {
                Name = "Khách sạn Anya Premier Quy Nhơn",
                Rating = "\uf005;\uf005;\uf005;",
                Location = "TP Quy Nhơn - Bình Định",
                ActualPrice = "1.286.000đ",
                OriginalPrice = "1.006.000đ",
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=800,height=600,quality=80/https://cdn.realtech.com.vn/uploads/hotel/1956/16202320314AM001.png",

                Name1 = "Khách Sạn Maximilan Đà Nẵng",
                Rating1 = "\uf005;\uf005;\uf005;\uf005;",
                Location1 = "Quận Sơn Trà - Đà Nẵng",
                ActualPrice1 = "1.086.000đ",
                OriginalPrice1 = "986.000đ",
                ImageUrl1 = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/1516/129202231616AM000.jpg",
            });

            Hotels.Add(new Animal
            {
                Name = "Khách sạn Diamond Bay Nha Trang",
                Rating = "\uf005;\uf005;\uf005;\uf005;\uf005;",
                Location = "TP Nha Trang - Khánh Hòa, Việt Nam",
                ActualPrice = "1.286.000đ",
                OriginalPrice = "1.006.000đ",
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/1428/125202241029AM000.jpg",

                Name1 = "Khách Sạn Wink Đà Nẵng Centre2",
                Rating1 = "\uf005;\uf005;\uf005;\uf005;",
                Location1 = "Quận Sơn Trà - Đà Nẵng",
                OriginalPrice1 = "986.000đ",
                ActualPrice1 = "1.086.000đ",
                ImageUrl1 = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=550,height=550,quality=80//uploads/hotel/1477/127202223702AM000.jpeg",
            });
        }
    }
    public static class HotelNearYourData
    {
        public static IList<NearYour> Hotels { get; private set; }

        static HotelNearYourData()
        {
            Hotels = new List<NearYour>();

            Hotels.Add(new NearYour
            {
                Location = "Gần tôi",
                ImageUrl = "icon/location1.png",
            });
            Hotels.Add(new NearYour
            {
                Location = "Đà Nẵng",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/da-nang.jpg",
            });
            Hotels.Add(new NearYour
            {
                Location = "Nha Trang",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/nha-trang.jpg",
            });
            Hotels.Add(new NearYour
            {
                Location = "Huế",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/hue.jpg",
            });
            Hotels.Add(new NearYour
            {
                Location = "Đà Nẵng",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/da-nang.jpg",
            });
            Hotels.Add(new NearYour
            {
                Location = "Nha Trang",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/nha-trang.jpg",
            });
            Hotels.Add(new NearYour
            {
                Location = "Huế",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/hue.jpg",
            });

        }
    }

}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gostayapp1.Models;

namespace gostayapp1.Data
{
    public static class HotelImageData2
    {
        public static IList<Animal> Hotels { get; private set; }

        static HotelImageData2()
        {
            Hotels = new List<Animal>();

            Hotels.Add(new Animal
            {
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=800,height=600,quality=80/https://cdn.realtech.com.vn/uploads/hotel/1956/16202320314AM001.png",
            });
            Hotels.Add(new Animal
            {
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=800,height=600,quality=80/https://cdn.realtech.com.vn/uploads/hotel/1956/16202320314AM002.png",
            });
            Hotels.Add(new Animal
            {
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=800,height=600,quality=80/https://cdn.realtech.com.vn/uploads/hotel/1956/16202320314AM003.png",
            });

        }
    }

    public static class HotelInfoData
    {
        public static IList<Animal> Hotels { get; private set; }

        static HotelInfoData()
        {
            Hotels = new List<Animal>();

            Hotels.Add(new Animal
            {
                Name = "Coco Palm Beach Phú Quốc Resort & Spa",
                Rating = "\uf005;\uf005;\uf005;",
                Location = "Ấp Ông Lang, Cửa Dương, Phú Quốc, Kiên Giang",
            });
        }
    }

    public static class HotelRoomData
    {
        public static IList<Rooms> sourceRooms { get; private set; }

        static HotelRoomData()
        {
            sourceRooms = new List<Rooms>();

            sourceRooms.Add(new Rooms()
            {
                Title = "Superior Room With Garden View",
                People = "Tối đa 2 người lớn",
                Square = "30m2",
                ActualPrice = "1.361.455 VND",
                RoomDerection = "Hướng thành phố",
                OriginalPrice = "1.293.382 VND",
                TotalPrice = "1.293.382 VND",
                ImageUrl = "https://cdn.realtech.com.vn/uploads/room/4539/16202320356AM004.png",
            });
            sourceRooms.Add(new Rooms()
            {
                Title = "Superior Room With Garden View",
                People = "Tối đa 2 người lớn",
                Square = "30m2",
                ActualPrice = "1.361.455 VND",
                RoomDerection = "Hướng thành phố",
                OriginalPrice = "1.293.382 VND",
                TotalPrice = "1.293.382 VND",
                ImageUrl = "https://cdn.realtech.com.vn/uploads/room/4539/16202320356AM004.png",
            });
        }
    }
}

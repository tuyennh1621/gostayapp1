using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gostayapp1.Models;
namespace gostayapp1.Data
{

    public static class TourData
    {
        public static IList<TourDt> Tour { get; private set; }

        static TourData()
        {
            Tour = new List<TourDt>();

            Tour.Add(new TourDt
            {
                Location = "Đà Nẵng",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/da-nang.jpg",
                Details= "16 Tours",
            });
            Tour.Add(new TourDt
            {
                Location = "Nha Trang",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/nha-trang.jpg",
                Details = "16 Tours",
            });
            Tour.Add(new TourDt
            {
                Location = "Huế",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/hue.jpg",
                Details = "16 Tours",
            });
            Tour.Add(new TourDt
            {
                Location = "Đà Nẵng",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/da-nang.jpg",
                Details = "16 Tours",
            });
            Tour.Add(new TourDt
            {
                Location = "Nha Trang",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/nha-trang.jpg",
                Details = "16 Tours",
            });
            Tour.Add(new TourDt
            {
                Location = "Huế",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/hue.jpg",
                Details = "16 Tours",
            });
            Tour.Add(new TourDt
            {
                Location = "Đà Nẵng",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/da-nang.jpg",
                Details = "16 Tours",
            });
            Tour.Add(new TourDt
            {
                Location = "Nha Trang",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/nha-trang.jpg",
                Details = "16 Tours",
            });
            Tour.Add(new TourDt
            {
                Location = "Huế",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/hue.jpg",
                Details = "16 Tours",
            });

        }
    }
    public static class TourListData
    {
        public static IList<TourDt> Tour { get; private set; }

        static TourListData()
        {
            Tour = new List<TourDt>();

            Tour.Add(new TourDt
            {   Name = "Tour Du Lịch Hà Nội - Bản Cát Cát - Swing Sapa - Moana - Fansipan",
                Location = "Khởi hành từ: Hà Nội",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/da-nang.jpg",
                Date = "22/09/2022 - 6N5Đ",
                ActualPrice = "1.056.279đ",
                OriginalPrice = "1.003.465đ",
                Discount = "-30%",
            });
            Tour.Add(new TourDt
            {
                Name = "Tour Du Lịch Hà Nội - Bản Cát Cát - Swing Sapa - Moana - Fansipan",
                Location = "Khởi hành từ: Hà Nội",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/nha-trang.jpg",
                Date = "22/09/2022 - 6N5Đ",
                ActualPrice = "1.056.279đ",
                OriginalPrice = "1.003.465đ",
                Discount = "-25%",
            });
            Tour.Add(new TourDt
            {
                Name = "Tour Du Lịch Hà Nội - Bản Cát Cát - Swing Sapa - Moana - Fansipan",
                Location = "Khởi hành từ: Hà Nội",
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/hue.jpg",
                Date = "22/09/2022 - 6N5Đ",
                ActualPrice = "1.056.279đ",
                OriginalPrice = "1.003.465đ",
                Discount = "-30%",
            });
       }
    }
    public static class TourQuocTeData
    {
        public static IList<TourDt> Tour { get; private set; }

        static TourQuocTeData()
        {
            Tour = new List<TourDt>();

            Tour.Add(new TourDt
            {
                Name = "Đức - Hà Lan - Bỉ - Pháp - Luxembourg",
                Location = "Khởi hành từ: Hà Nội",
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=888,height=678,quality=80//uploads/tour/112/215202324704AM000.jpg",
                Date = "22/09/2022 - 6N5Đ",
                ActualPrice = "1.056.279đ",
                OriginalPrice = "1.003.465đ",
                Discount = "-30%",
            });
            Tour.Add(new TourDt
            {
                Name = "Pháp - Thụy Sĩ - Ý - Vatican",
                Location = "Khởi hành từ: Hồ Chí Minh",
                ImageUrl = "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=888,height=678,quality=80//uploads/tour/114/216202385356AM000.jpg",
                Date = "22/09/2022 - 6N5Đ",
                ActualPrice = "1.056.279đ",
                OriginalPrice = "1.003.465đ",
                Discount = "-25%",
            });
           
        }
    }


}

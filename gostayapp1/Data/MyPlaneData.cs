using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gostayapp1.Models;

namespace gostayapp1.Data
{
    class MyPlaneData
    {

        public static IList<Plane> Planes { get; private set; }


        static MyPlaneData()
        {
            Planes = new List<Plane>();

            Planes.Add(new Plane
            {
                Name = "Bamboo Airway",
                Arrivals = "(DAD) Đà Nẵng",
                Departure = "(HAN) Nội Bài",
                PlaneDate = "25/04/2023",
                ActualPrice = "1.056.279đ",
                OriginalPrice = "1.003.468đ",
                PriceAfterTax = "Giá sau thuế: 1.280.000đ",
                ImageUrl = "flight/bamboo.jpg",
                HourDeparture = "05:45",
                HourArrivals = "07:45",
                CodePlaneDeparture = "HAN",
                CodePlaneArrivals = "DAD",
                FlightTime = "1h20 phút, bay thẳng",
            });
            Planes.Add(new Plane
            {
                Name = "Viet JetAir",
                Arrivals = "(HUI) Huế",
                Departure = "(HAN) Nội Bài",
                PlaneDate = "25/04/2023",
                ActualPrice = "1.056.279đ",
                OriginalPrice = "1.003.468đ",
                PriceAfterTax = "Giá sau thuế: 1.280.000đ",
                ImageUrl = "flight/vietjet.jpg",
                HourDeparture = "05:45",
                HourArrivals = "07:45",
                CodePlaneDeparture = "HAN",
                CodePlaneArrivals = "DAD",
                FlightTime = "1h20 phút, bay thẳng",
            });
            Planes.Add(new Plane
            {
                Name = "VietnamAirlines",
                Arrivals = "(TSN) Tân Sơn Nhất",
                Departure = "(HAN) Nội Bài",
                PlaneDate = "25/04/2023",
                ActualPrice = "1.056.279đ",
                OriginalPrice = "1.003.468đ",
                PriceAfterTax = "Giá sau thuế: 1.280.000đ",
                ImageUrl = "flight/vna.jpg",
                HourDeparture = "05:45",
                HourArrivals = "07:45",
                CodePlaneDeparture = "HAN",
                CodePlaneArrivals = "DAD",
                FlightTime = "1h20 phút, bay thẳng",
            });
            Planes.Add(new Plane
            {
                Name = "Jetstar Pacifics",
                Arrivals = "(QUI) Quy Nhơn",
                Departure = "(HAN) Nội Bài",
                PlaneDate = "25/04/2023",
                ActualPrice = "1.056.279đ",
                OriginalPrice = "1.003.468đ",
                PriceAfterTax = "Giá sau thuế: 1.280.000đ",
                ImageUrl = "flight/jestar.jpg",
                HourDeparture = "05:45",
                HourArrivals = "07:45",
                CodePlaneDeparture = "HAN",
                CodePlaneArrivals = "DAD",
                FlightTime = "1h20 phút, bay thẳng",
            });
            Planes.Add(new Plane
            {
                Name = "VietnamAirlines",
                Arrivals = "(PCX) Phú Quốc",
                Departure = "(HAN) Nội Bài",
                PlaneDate = "25/04/2023",
                ActualPrice = "1.056.279đ",
                OriginalPrice = "1.003.468đ",
                PriceAfterTax = "Giá sau thuế: 1.280.000đ",
                ImageUrl = "flight/bamboo.jpg",
                HourDeparture = "05:45",
                HourArrivals = "07:45",
                CodePlaneDeparture = "HAN",
                CodePlaneArrivals = "DAD",
                FlightTime = "1h20 phút, bay thẳng",
            });


        }


    }

    class DaylyTimeData
    {
        public static IList<CarouselDaylyTime> Planes { get; private set; }
        static DaylyTimeData()
        {
            Planes = new List<CarouselDaylyTime>();

            Planes.Add(new CarouselDaylyTime
            {
                DaylyTime ="Chủ Nhật",
                Day = "16.04.2023",
                Price ="Từ 576.000 VNĐ",

                DaylyTime1 = "Thứ Hai",
                Day1 = "17.04.2023",
                Price1 = "Từ 693.000 VNĐ",

                DaylyTime2 = "Thứ Ba",
                Day2 = "18.04.2023",
                Price2 = "Từ 333.000 VNĐ",
            });

        }
    } 

}

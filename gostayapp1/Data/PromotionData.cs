using gostayapp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gostayapp1.Data
{
    class PromotionData
    {
        public static IList<Animal> Promotions { get; private set; }

        static PromotionData()
        {
            Promotions = new List<Animal>();

            Promotions.Add(new Animal
            {
                Protitle = "Nhập mã",
                Procode = "HOTEL50",
                Prodes = "Khách sạn giảm giá đến 300k",
                Prodate= "Hạn sử dụng: 10/03/2023",
            });
        }
    }

    class PromotionTourData
    {
        public static IList<Animal> Promotions { get; private set; }

        static PromotionTourData()
        {
            Promotions = new List<Animal>();

            Promotions.Add(new Animal
            {
                Protitle = "Nhập mã",
                Procode = "DANANG50",
                Prodes = "Tour Đà Nẵng giảm giá đến 500k",
                Prodate = "Hạn sử dụng: 10/03/2023",
            });
        }
    }

    class PromotionListData
    {
        public static IList<Promotion> Promotions { get; private set; }

        static PromotionListData()
        {
            Promotions = new List<Promotion>();

            Promotions.Add(new Promotion
            {
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/promotion/bamboo-airway.jpg",
                Name = "Rộn ràng Du lịch mùa lễ hội - Khách sạn giảm đến 200K",
                DateTime = "22/09/2022",
            });
            Promotions.Add(new Promotion
            {
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/promotion/banner-vietjet.jpg",
                Name = "Rộn ràng Du lịch mùa lễ hội - Khách sạn giảm đến 200K",
                DateTime = "22/09/2022",
            });
            Promotions.Add(new Promotion
            {
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/promotion/vietnamairline.jpg",
                Name = "Rộn ràng Du lịch mùa lễ hội - Khách sạn giảm đến 200K",
                DateTime = "22/09/2022",
            });
        }
    }

    class DiscountData
    {
        public static IList<Promotion> Promotions { get; private set; }

        static DiscountData()
        {
            Promotions = new List<Promotion>();

            Promotions.Add(new Promotion
            {
                ImageUrl = "https://i.pinimg.com/originals/46/87/ec/4687ecccef953e56503adf3f31be2326.jpg",
                Discount = "20%",
                DateTime = "22/09/2022",
                Code = "Hotel10",
            });
            Promotions.Add(new Promotion
            {
                ImageUrl = "https://i.pinimg.com/originals/46/87/ec/4687ecccef953e56503adf3f31be2326.jpg",
                Discount = "30%",
                DateTime = "22/09/2022",
                Code = "Tour30",
            });
        }
    }

    class ProDetailtour
    {
        public static IList<Promotion> Promotions { get; private set; }

        static ProDetailtour()
        {
            Promotions = new List<Promotion>();

            Promotions.Add(new Promotion
            {
                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/moc-chau.jpg",
                Discount = "Giá chỉ từ 825k / 1 đêm",
                Name = "Mộc Châu",

                ImageUrl1 = "https://gostay.realtech.com.vn/assets/images/location/da-lat.jpg",
                Discount1 = "Giá chỉ từ 625k / 1 đêm",
                Name1 = "Đà Lạt",

            });
            Promotions.Add(new Promotion
            {   
                ImageUrl1 = "https://gostay.realtech.com.vn/assets/images/location/da-lat.jpg",
                Discount1 = "Giá chỉ từ 625k / 1 đêm",
                Name1 = "Đà Lạt",

                ImageUrl = "https://gostay.realtech.com.vn/assets/images/location/moc-chau.jpg",
                Discount = "Giá chỉ từ 825k / 1 đêm",
                Name = "Mộc Châu",
            });
        }
    }
}

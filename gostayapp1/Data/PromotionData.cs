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
        }
    }
}

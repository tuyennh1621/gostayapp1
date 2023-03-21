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
}

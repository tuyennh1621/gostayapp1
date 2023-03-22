using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gostayapp1.Models;

namespace gostayapp1.Data
{
    class SearchPlaneData
    {
        public static IList<Plane> Planes { get; private set; }

        static SearchPlaneData()
        {
            Planes = new List<Plane>();

            Planes.Add(new Plane
            {
                Name = "TP Hồ Chí Minh (SGN)",
                Location = "Sân bay quốc tế Tân Sơn Nhất",
            });

            Planes.Add(new Plane
            {
                Name = "Hà Nội (HAN)",
                Location = "Sân bay quốc tế Nội Bài"
            });

            Planes.Add(new Plane
            {
                Name = "Đà Nẵng (DAD)",
                Location = "Sân bay quốc tế Đà Nẵng"
            });

            Planes.Add(new Plane
            {
                Name = "Huế (HUI)",
                Location = "Sân bay Phú Bài"
            });

            Planes.Add(new Plane
            {
                Name = "Phú Quốc (PQC)",
                Location = "Sân bay quốc tế Phú Quốc",
            });
        }
    }

}        
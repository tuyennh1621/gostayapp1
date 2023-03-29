namespace gostayapp1.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Discount { get; set; }
        public string Rating { get; set; }
        public string ActualPrice { get; set; }
        public string OriginalPrice { get; set; }
        public string ImageUrl { get; set; }


        public string Name1 { get; set; }
        public string Location1 { get; set; }
        public string Details1 { get; set; }
        public string Discount1 { get; set; }
        public string Rating1 { get; set; }
        public string ActualPrice1 { get; set; }
        public string OriginalPrice1 { get; set; }
        public string ImageUrl1 { get; set; }

        public string Protitle { get; set; }

        public string Procode { get; set; }
        public string Prodes { get; set; }
        public string Prodate { get; set; }



        public override string ToString()
        {
            return Name;
        }
    }

    public class Plane
    {
        public string Name { get; set; }
        public string Departure { get; set; }
        public string Arrivals { get; set; }
        public string PlaneDate { get; set; }
        public string ActualPrice { get; set; }
        public string OriginalPrice { get; set; }
        public string PriceAfterTax { get; set; }
        public string ImageUrl { get; set; }
        public string HourDeparture { get; set; }
        public string HourArrivals { get; set; }
        public string CodePlaneDeparture { get; set; }
        public string CodePlaneArrivals { get; set; }
        public string FlightTime { get; set; }
        public string Location { get; set; }

      public override string ToString()
        {
            return Name;
        }
    }

    public class Listtour
    {
        public string Title { get; set; }
        public string image { get; set; }
    }

    public class Images
    {
        public string ImageUrl { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }



    }

    public class Rooms
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string People { get; set; }
        public string Square { get; set; }
        public string RoomDerection { get; set; }
        public string ActualPrice { get; set; }
        public string OriginalPrice { get; set; }
        public string TotalPrice { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

        public class Room
    {
        public string Name { get; set; }
        public string People { get; set; }
        public string Square { get; set; }
        public string RoomDerection { get; set; }
        public string ActualPrice { get; set; }
        public string OriginalPrice { get; set; }
        public string TotalPrice { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    public class RoomImage
    {
        public string ImageUrl { get; set; }


    }

    public class NearYour
    {
        public string ImageUrl { get; set; }
        public string Location { get; set; }
    }



    public class Comment
    {
        public string Name { get; set; }
        public string DateTime { get; set; }
        public string Guest { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public string CommentD { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

}

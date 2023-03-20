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


        public string Procode { get; set; }
        public string Prodes { get; set; }
        public string Prodate { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

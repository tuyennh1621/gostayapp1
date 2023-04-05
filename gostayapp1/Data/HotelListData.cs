using gostayapp1.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace gostayapp1.Data
{
    public class ResponseBase<T>
    {
        public ResponseBase()
        {
            Message = "";//ErrorCodeMessage.Success.Value;
            Code = 1;// ErrorCodeMessage.Success.Key;
        }

        public int Code { get; set; }
        public string Message { get; set; }
        public int Count { get; set; }
        public bool IsSuccessful => Code == 1;

        public T Data { get; set; }

    }

    public class ResponseBase : ResponseBase<object>
    {
    }

    public class PagingList<T>
    {
        public PagingList()
        {
            Items = new List<T>();
        }

        /// <summary>
        /// Cái này để web hiển thị có tổng số bao nhiêu bản ghi, tổng số page là bao nhiêu, hiện tại đang ở số page số mấy

        /// </summary>
        public Metadata MetaData { get; set; }

        /// <summary>
        /// List của page hiện tại
        /// </summary>
        public List<T> Items { get; set; }
    }
    public class Metadata
    {
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int Count { get; set; }
        public int TotalCount { get; set; }
    }
    public class HotelHomePageDto
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string TinhThanh { get; set; }
        public string QuanHuyen { get; set; }
        public int? Rating { get; set; }
        public decimal? AvgNight { get; set; }
        public double Review_score { get; set; }
        public double? Lat_map { get; set; }
        public double? Lon_map { get; set; }
        public double? Discount { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal ActualPrice { get; set; }
        public int? NumberReviewers { get; set; }
        public int? PalletbedRoom { get; set; }
        public long? IntDate { get; set; }
        public int Total { get; set; }
        public int TotalPicture { get; set; }
        private string Urls
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    Pictures = new List<string>();
                else
                {
                    Pictures = value.Split(';').ToList();
                }
            }
        }
        public List<string> Pictures { get; set; } = new List<string>();

        public string ImageUrl
        {
            get
            {
                if (Pictures != null && Pictures.Count > 0)
                    return "https://cdn.realtech.com.vn/cdn-cgi/image/fit=cover,width=400,height=400,quality=100" + Pictures.FirstOrDefault();
                else
                {
                    return "";
                }
            }
        }
    }

    public class HotelSearchRequest
    {
        public decimal? PriceMin { get; set; }
        public decimal? PriceMax { get; set; }
        public List<int?>? Ratings { get; set; }
        public List<int>? IdQuans { get; set; }
        public List<int>? IdPhuong { get; set; }
        public List<int>? Types { get; set; }
        public double? ReviewScore { get; set; }
        public List<int>? Services { get; set; }
        public int? Palletbed { get; set; }
        public int? NumMature { get; set; }
        public int? NumChild { get; set; }
        public DateTime? CheckinDate { get; set; }
        public DateTime? CheckoutDate { get; set; }

        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }
        public int? IdTinhThanh { get; set; }

    }

    public class HotelList
    {

        public static IList<HotelHomePageDto> source;

       // public ObservableCollection<HotelHomePageDto> Hotels { get; private set; }

        public static ResponseBase<Tout> Post<Tin, Tout>(string url, Tin body, params string[] args)
        {
            try
            {
                string Serialized = JsonConvert.SerializeObject(body);
                var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpContent content = new StringContent(Serialized, Encoding.Unicode, "application/json");
                var response = client.PostAsync("https://api.realtech.com.vn/Hotels/hotel-search", content).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var str = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<ResponseBase<Tout>>(str)!;
                    if (result != null)
                    {
                        return result;
                    }
                }
                else
                {
                    return new ResponseBase<Tout>
                    {
                        Code = (int)response.StatusCode,
                        Message = ""// response.StatusCode.GetEnumDescription()
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseBase<Tout>
                {
                    Code = 99,
                    Message = $"Service base exception :{ex.Message}"
                };
                // Log error
            }

            return default(ResponseBase<Tout>);
        }


        static HotelList()
        {
            source = new List<HotelHomePageDto>();

            HotelSearchRequest request = new HotelSearchRequest();
            request.PageSize = 10;
            request.PageIndex = 1;
            request.IdTinhThanh = 5;

            var response = Post<HotelSearchRequest, List<HotelHomePageDto>>("Hotels/hotel-search", request);

            foreach (var dal in response.Data)
            {
                source.Add(new HotelHomePageDto
                {
                    Rating = dal.Rating,
                    HotelName = dal.HotelName,
                    QuanHuyen = dal.QuanHuyen,
                    ActualPrice = dal.ActualPrice,
                    OriginalPrice = dal.OriginalPrice,
                    Pictures = dal.Pictures
                });

            }
        }       
    }
}

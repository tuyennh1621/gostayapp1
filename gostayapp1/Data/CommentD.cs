using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gostayapp1.Models;

namespace gostayapp1.Data;
public static class CommentD
{
    public static IList<Comment> Rate { get; private set; }

    static CommentD()
    {
        Rate = new List<Comment>();

        Rate.Add(new Comment
        {
            Name = "Nguyễn Thành An",
            DateTime = "13/04/2022",
            Guest = "Cặp đôi",
            Details = "Phù hợp đi chơi gia đình có trẻ nhỏ và các gia đình muốn cùng nhau ở chung căn hộ để có không gian chung.",
            ImageUrl = "https://cdn-icons-png.flaticon.com/512/3033/3033143.png",
            CommentD = "9.6",

        });


        Rate.Add(new Comment
        {
            Name = "Nguyễn Thành An 2",
            DateTime = "13/04/2022",
            Guest = "Cặp đôi",
            Details = "Phù hợp đi chơi gia đình có trẻ nhỏ và các gia đình muốn cùng nhau ở chung căn hộ để có không gian chung.",
            ImageUrl = "https://cdn-icons-png.flaticon.com/512/3033/3033143.png",
            CommentD = "9.6",

        });
    }
}
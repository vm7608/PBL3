﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.ViewDTO
{
    public class PostDTGViewDTO
    {
        //Class hiển thị thông tin quản lý post cho Admin
        public int PostID { get; set; } //Cột này được ẩn
        public int? UserID { get; set; } //Cột này được ẩn
        public string Username { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public double AvgRating { get; set; }
        public int NumberOfComment { get; set; } //số bình luận có trong bài
        public bool Posted { get; set; }
        public bool Rented { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}

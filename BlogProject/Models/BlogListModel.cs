using System;

namespace UdemyBlogFront.Models{
    public class BlogListModel{
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public DateTime PostedTime { get; set; }
    }
}
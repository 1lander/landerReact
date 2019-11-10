using System;
using System.ComponentModel.DataAnnotations;

namespace landerReact.Models
{
    public class TextPost
    {
        public int id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Content { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm}")]
        public DateTime DatePosted { get; set; } = DateTime.Now;
        public int Likes { get; set; }
        public string User { get; set; }
    }
}

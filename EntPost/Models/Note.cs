using System;
using System.ComponentModel.DataAnnotations;
//using Microsoft.AspNetCore.Http;

namespace EntPost.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        //public string Version { get; set; }
        //public IFormFile File { get; set; }


        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}

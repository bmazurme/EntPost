using System;
using System.Collections.Generic;

namespace EntPost.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Note> Note { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}

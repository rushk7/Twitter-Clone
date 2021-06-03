using System;
using System.Collections.Generic;
using System.Text;

namespace Glitter.Shared.DTO
{
    public class TweetDTO
    {
        public int id { get; set; }
        public string email { get; set; }
        public string content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }

    }
}

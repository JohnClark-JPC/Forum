using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public int TopicID { get; set; }
        public int ForumID { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
        public DateTime PostTime { get; set; }
    }
}

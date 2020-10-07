using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Topic
    {
        public int TopicID { get; set; }
        public int ForumnID { get; set; }
        public string Name { get; set; }
    }
}

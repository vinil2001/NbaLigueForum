using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaLigueForum.Models
{
    public class ForumTopicModel
    {
        public ForumViewModel Forum { get; set; }
        public IEnumerable<PostViewModel> Posts { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaLigueForum.Models
{
    public class PostIndexViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthtorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public int AuthorRating { get; set; }
        public DateTime Created { get; set; }
        public string PostContent { get; set; }
        public IEnumerable<PostReplyModel> PostReplies { get; set; }
    }
}

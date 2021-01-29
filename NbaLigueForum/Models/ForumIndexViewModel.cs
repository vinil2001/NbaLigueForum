using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaLigueForum.Models
{
    public class ForumIndexViewModel
    {
        public IEnumerable<ForumViewModel> ForumList { get; set; }
    }
}

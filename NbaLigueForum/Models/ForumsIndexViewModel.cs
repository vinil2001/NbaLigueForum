using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaLigueForum.Models
{
    public class ForumsIndexViewModel
    {
        public IEnumerable<ForumViewModel> ForumList { get; set; }
    }
}

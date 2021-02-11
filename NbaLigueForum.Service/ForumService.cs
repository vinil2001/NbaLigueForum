using Microsoft.EntityFrameworkCore;
using NbaLigueForum.Data;
using NbaLigueForum.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbaLigueForum.Service
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;
        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetAll()
        {
            return _context.Forums.Include(forum => forum.Posts);
        }

        public IEnumerable<ApplicationUser> GetAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        public Forum GetById(int id)
        {
            //var forum = _context.Forums
            //    .Where(f => f.Id == id)
            //    .Include(f => f.Posts)
            //    .ThenInclude(f => f.User)
            //    .Include(f => f.Posts)
            //    .ThenInclude(f => f.PostReplies)
            //    .ThenInclude(f => f.User)
            //    .Include(f => f.Posts)
            //    .ThenInclude(f => f.Forum)
            //    .FirstOrDefault();
            var forum = _context.Forums.Find(id);
            if (forum.Posts == null)
                forum.Posts = new List<Post>();
            return forum;
        }

        public Task UpdateForumDescription(int forumId, string newForumDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newForumTitle)
        {
            throw new NotImplementedException();
        }
    }
}

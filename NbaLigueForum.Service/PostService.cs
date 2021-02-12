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
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _context;

        PostService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Add(Post post)
        {
            throw new NotImplementedException();
        }

        public Task Delite(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            return _context.Posts.Where(post => post.Id == id)
                .Include(post => post.User)
                .Include(post => post.PostReplies).ThenInclude(reply=>reply.User)
                .Include(post => post.Forum)
                .First();
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            IEnumerable<Post> posts = _context.Forums.Where(forum => forum.Id == id).First().Posts;

            return posts;
        }
    }
}

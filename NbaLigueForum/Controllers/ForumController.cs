using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NbaLigueForum.Data;
using NbaLigueForum.Data.Models;
using NbaLigueForum.Models;
using NbaLigueForum.Service;

namespace NbaLigueForum.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;

        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }

        // GET: ForumController
        public ActionResult Index()
        {
            IEnumerable<ForumViewModel> allForums = _forumService.GetAll().Select(forum => new ForumViewModel
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description
            });

            ForumsIndexViewModel model = new ForumsIndexViewModel
            {
                ForumList = allForums
            };

            return View(model);
        }

        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);

            var posts = forum.Posts;

            IEnumerable<PostViewModel> postsViewModel = posts.Select(post => new PostViewModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Ratting,
                Title = post.Title,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.PostReplies.Count(),
                Forum = BuildForumListString(post)
            });

            var Model = new ForumTopicModel
            {
                Posts = postsViewModel,
                Forum = BuildForumListString(forum)
            };

            return View(Model);
        }

        private ForumViewModel BuildForumListString(Post post)
        {
            Forum forum = post.Forum;

            return BuildForumListString(forum);
        }

        private ForumViewModel BuildForumListString(Forum forum)
        {
            return new ForumViewModel
            {
                Id = forum.Id,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl,
                Name = forum.Title
            };
        }

        // GET: ForumController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ForumController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ForumController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ForumController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ForumController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ForumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ForumController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

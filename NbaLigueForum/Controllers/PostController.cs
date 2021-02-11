using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NbaLigueForum.Data;
using NbaLigueForum.Models;

namespace NbaLigueForum.Controllers
{
    public class PostController : Controller
    {
        readonly private IPost _postService;

        public PostController(IPost postService)
        {
            _postService = postService;
        }
        // GET: PostController
        public ActionResult Index(int id)
        {
            var post = _postService.GetById(id);

            var replies = BuildPostReplies(post.PostReplies);

            var model = new PostIndexViewModel
            {
                AuthorImageUrl = post.User.ProfileImgUrl,
                AuthorName = post.User.UserName,
                AuthorRating = post.User.Ratting,
                AuthtorId = post.User.Id,
                Created = post.Created,
                PostContent = post.Content,
                PostReplies = replies,
                Title = post.Title
            };
            return View(model);
        }

        private IEnumerable<PostReplyModel> BuildPostReplies(IEnumerable<Data.Models.PostReply> postReplies)
        {
            return postReplies.Select(reply => new PostReplyModel
            {
                AuthorImageUrl = reply.User.ProfileImgUrl,
                AuthorName = reply.User.UserName,
                AuthorRating = reply.User.Ratting,
                AuthtorId = reply.User.Id,
                Created = reply.Created,
                PostId = reply.Post.Id,
                ReplyContent = reply.Content
            });
        }

        // GET: PostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostController/Create
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

        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostController/Edit/5
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

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostController/Delete/5
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

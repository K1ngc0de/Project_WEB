using eUseControl.BusinessLogic.Service;
using eUseControl.Controllers;
using eUseControl.Domain.Entities;
using eUseControl.Filters;
using eUseControl.Web.Extensions;
using eUseControl.Web.Models;
using System.Web.Mvc;

namespace eUseControl.Web.Controllers
{
	public class ForumController : BaseController
	{
		Forum Posts = new Forum();
		public ActionResult Details(int id)
		{
			var postResp = Posts.Get(id);
            if (!postResp.Success)
                return HttpNoPermission();

			var post = postResp.Entry;
			if (post == null)
				return HttpNotFound();

			Posts.LoadReference(post, "Author");
            return View(post);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		[RequireLogin]
		public ActionResult PostComment(CommentForm form)
		{
			var commentService = new CommentService();
            IHasComments target = null;
			switch(form.Type)
			{
				case "Comment":
                    var comResp = commentService.Get(form.TargetId);
                    if (!comResp.Success)
                        return HttpNoPermission();

                    target = comResp.Entry;
					commentService.LoadCollection(comResp.Entry, "Comments");
                    break;

                case "Post":
					using (var postService = new Forum())
					{
						var postResp = postService.Get(form.TargetId);
						if (!postResp.Success)
							return HttpNoPermission();

						target = postResp.Entry;
                        postService.LoadCollection(postResp.Entry, "Comments");
                    }
					break;
            }

			if (target == null)
				return HttpNoPermission();

            var comment = new Comment { Author = Session.GetUser(), Message = form.Message };
			target.Comments.Add(comment);
			commentService.Add(comment);
			return Redirect(form.GoBackUrl);
		}
	}
}
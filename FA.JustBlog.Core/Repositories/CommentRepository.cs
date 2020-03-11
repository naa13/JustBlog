using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public int AddComment(int postId, string commentName, string commentEmail, string commentTitle, string commentBody)
        {
            var post = Context.Posts.Find(postId);
            Comment comment = new Comment();
            comment.Name = commentName;
            comment.Email = commentEmail;
            comment.CommentHeader = commentTitle;
            comment.CommentText = commentBody;
            comment.Post = post;
            comment.CommentTime = DateTime.Now;
            _dbSet.Add(comment);
            return Context.SaveChanges();
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return Context.Comments.ToList();
        }

        public IEnumerable<Comment> GetCommentsForPost(int postId)
        {
            return Context.Comments.Where(x => x.Post.PostId == postId).ToList();
        }
    }
}

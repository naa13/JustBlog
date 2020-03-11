using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Repositories
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        int AddComment(int postId, string commentName, string commentEmail, string commentTitle, string commentBody);
        IEnumerable<Comment> GetAllComments();
        IEnumerable<Comment> GetCommentsForPost(int postId);
    }
}

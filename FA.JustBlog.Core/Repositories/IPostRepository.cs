using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Repositories
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        Post GetPostByDateTime(int year, int month, string urlSlug);
        IEnumerable<Post> GetAllPosts();
        IEnumerable<Post> GetPublisherPosts();
        IEnumerable<Post> GetUnpublisherPosts();
        IEnumerable<Post> GetLatestPost(int size);
        IEnumerable<Post> GetPostsByMonth(DateTime monthYear);
        int CountPostsForCategory(string category);
        int CountPostsForTag(string tag);
        IEnumerable<Post> GetPostsByCategory(string category);
        IEnumerable<Post> GetPostsByTag(string tag);
        IEnumerable<Post> GetHighestPosts(int size);
        IEnumerable<Post> GetMostViewedPost(int size);

    }
}

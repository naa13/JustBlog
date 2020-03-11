using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FA.JustBlog.Core.Models;

namespace FA.JustBlog.Core.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public int CountPostsForCategory(string category)
        {
            return Context.Posts.Count(x => x.Category.CategoryName == category);
        }

        public int CountPostsForTag(string tag)
        {
            return Context.Posts.Count(x => x.Tags.Any(t => t.TagName == tag));
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return Context.Posts.ToList();
        }

        public IEnumerable<Post> GetLatestPost(int size)
        {
            return Context.Posts.OrderByDescending(x => x.PostedOn).Take(size).ToList();
        }

        public Post GetPostByDateTime(int year, int month, string urlSlug)
        {
            return Context.Posts.Include("Category").SingleOrDefault<Post>(p => p.Published && p.PostedOn.Year == year && p.PostedOn.Month == month && p.UrlSlug == urlSlug);
        }

        public IEnumerable<Post> GetPostsByCategory(string category)
        {
            return Context.Posts.Where(x => x.Category.CategoryName == category).ToList();
        }

        public IEnumerable<Post> GetPostsByMonth(DateTime monthYear)
        {
            return Context.Posts.Where(x => x.PostedOn.Month == monthYear.Month && x.PostedOn.Year == monthYear.Year).ToList();
        }

        public IEnumerable<Post> GetPostsByTag(string tag)
        {
            return Context.Posts.Where(x => x.Tags.Any(t => t.TagName == tag)).ToList();
        }

        public IEnumerable<Post> GetPublisherPosts()
        {
            return Context.Posts.Where(p => p.Published).OrderByDescending(p => p.PostedOn).ToList();
        }

        public IEnumerable<Post> GetUnpublisherPosts()
        {
            return Context.Posts.Where(p => p.Published).OrderByDescending(p => p.Modified).ToList();
        }
        public IEnumerable<Post> GetHighestPosts(int size)
        {
            return Context.Posts.OrderByDescending(p => p.Rate).Take(size).ToList();
        }

        public IEnumerable<Post> GetMostViewedPost(int size)
        {
            return Context.Posts.OrderByDescending(p => p.ViewCount).Take(size).ToList();
        }

    }
}

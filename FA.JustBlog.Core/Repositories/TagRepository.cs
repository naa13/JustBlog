using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Repositories
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public IEnumerable<Tag> GetTagByUrlSlug(string urlSlug)
        {
            return Context.Tags.Where(x => x.UrlSlug.Contains(urlSlug)).ToList();
        }
    }
}

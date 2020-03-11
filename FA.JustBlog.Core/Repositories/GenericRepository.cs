using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    protected readonly JustBlogContext Context;
    protected readonly DbSet<TEntity> _dbSet;
    protected GenericRepository()
    {
        Context = new JustBlogContext();
        _dbSet = Context.Set<TEntity>();
    }
    public virtual int Add(TEntity entity)
    {
        _dbSet.Add(entity);
        return Context.SaveChanges();
    }

    public virtual bool Delete(TEntity entity)
    {
        _dbSet.Remove(entity);
        return Context.SaveChanges() > 0;
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
        return _dbSet.ToList();
    }

    public virtual TEntity GetById(object id)
    {
        return _dbSet.Find(id);
    }

    public virtual bool Update(TEntity entity)
    {
        _dbSet.AddOrUpdate(entity);
        return Context.SaveChanges() > 0;
    }
}
namespace FA.JustBlog.Core.Repositories
{
    class GenericRepository
    {
    }
}

using LibraryMVC.Domain.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace LibraryMVC.Repository.Infrastructure.EntityFrameWorkAccess;

public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext :DbContext, new()
{
    public void Add(TEntity entity)
    {
        using var context = new TContext();
        context.Add(entity);    
        context.SaveChanges();  
    }

    public void Delete(TEntity entity)
    {
        using var context = new TContext();
        context.Remove(entity); 
        context.SaveChanges();  
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
    {
        using var context = new TContext();
        return context.Set<TEntity>().SingleOrDefault(filter)!;

    }

    public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}

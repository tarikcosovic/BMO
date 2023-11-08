using AutoMapper;
using BMO.Api.Models;
using BMO.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BMO.Api.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;
        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TEntity entity) => _dbContext.Set<TEntity>().Add(entity);
        public virtual async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default) => await _dbContext.Set<TEntity>().AddAsync(entity, cancellationToken);

        public void AddRange(IEnumerable<TEntity> entities) => _dbContext.Set<TEntity>().AddRange(entities);
        public async void AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default) => await _dbContext.Set<TEntity>().AddRangeAsync(entities, cancellationToken);

        public TEntity? Get(int id) => _dbContext.Set<TEntity>().Find(id);
        public async Task<TEntity?> GetAsync(int id, CancellationToken cancellationToken = default) => await _dbContext.Set<TEntity>().FindAsync(new object[] { id }, cancellationToken);
        public async Task<TEntity?> GetAsync(long id, CancellationToken cancellationToken = default) => await _dbContext.Set<TEntity>().FindAsync(new object[] { id }, cancellationToken);
        public async Task<TEntity?> GetAsync(Guid id, CancellationToken cancellationToken = default) => await _dbContext.Set<TEntity>().FindAsync(new object[] { id }, cancellationToken);

        public async Task<IEnumerable<TEntity>> GetAll(CancellationToken cancellationToken = default) => await _dbContext.Set<TEntity>().ToListAsync(cancellationToken);
        public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default) => await _dbContext.Set<TEntity>().ToListAsync(cancellationToken);

        public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default) => await _dbContext.Set<TEntity>().Where(predicate).ToListAsync(cancellationToken);

        public void Remove(TEntity entity) => _dbContext.Set<TEntity>().Remove(entity);
        public void RemoveRange(IEnumerable<TEntity> entities) => _dbContext.Set<TEntity>().RemoveRange(entities);
    }
}

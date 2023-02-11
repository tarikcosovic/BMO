using System.Linq.Expressions;

namespace BMO.Api.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);

        void AddRange(IEnumerable<TEntity> entities);
        void AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);

        TEntity? Get(int id);
        Task<TEntity?> GetAsync(int id, CancellationToken cancellationToken = default);

        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entity);
    }
}

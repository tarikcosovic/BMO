using System.Linq.Expressions;

namespace BMO.Api.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);

        void AddRange(IEnumerable<TEntity> entities);
        void AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

        Task<IEnumerable<TEntity>> GetAll(CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);

        TEntity? Get(int id);
        Task<TEntity?> GetAsync(int id, CancellationToken cancellationToken = default);
        Task<TEntity?> GetAsync(long id, CancellationToken cancellationToken = default);
        Task<TEntity?> GetAsync(Guid id, CancellationToken cancellationToken = default);

        Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entity);
    }
}

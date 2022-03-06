namespace CAExample.Domain.SeedWork;
public interface IGenericRepository<TAggregate, TKey>
{
    public Task Insert(TAggregate aggregate);
    public Task<TAggregate?> GetById(TKey id);
    public Task Update(TAggregate aggregate);
}

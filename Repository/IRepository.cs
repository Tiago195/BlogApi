namespace Blog.Repository;

public interface IRepository<T>
{
  public IEnumerable<T> GetAll();
  public T? Get(int id);
  public void Create(T entity);
  public void Update(T entity);
  public void Delete(T entity);
}
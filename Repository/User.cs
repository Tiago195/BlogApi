using Blog.Context;

namespace Blog.Repository;

public class User : IRepository<Model.User>
{
  private readonly BlogContext _context;
  public User(BlogContext context)
  {
    _context = context;
  }

  public IEnumerable<Model.User> GetAll()
  {

    return _context.Users;
  }

  public Model.User? Get(int Id)
  {
    return _context.Users.Find(Id);
  }

  public Model.User? GetByEmail(Model.Login user)
  {
    return _context.Users.First(x => x.Email == user.Email);
  }

  public void Create(Model.User entity)
  {
    _context.Users.Add(entity);
    _context.SaveChanges();
  }

  public void Update(Model.User entity)
  {
    _context.Users.Update(entity);
    _context.SaveChanges();
  }

  public void Delete(Model.User entity)
  {
    _context.Users.Remove(entity);
    _context.SaveChanges();
  }
}
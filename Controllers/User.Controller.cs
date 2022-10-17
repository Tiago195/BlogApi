using Microsoft.AspNetCore.Mvc;
using Blog.Model;
using Blog.Services;


namespace Blog.Controllers;

[ApiController]
[Route("[controller]")]
public class User : Controller
{
  private readonly Repository.User _repository;

  public User(Repository.User repository)
  {
    _repository = repository;
  }

  [HttpPost]
  [Route("/login")]
  public ActionResult Login(Model.Login user)
  {
    // try
    // {
    var userExist = _repository.GetByEmail(user);

    if (userExist.Password != user.Password) throw new Exception(ErrorService.Generate("Invalid fields", 400));

    var token = Token.Generate();

    return Ok(new { Token = token });
    // }
    // catch (System.Exception)
    // {
    //   return BadRequest(new { message = "Some required fields are missing" });
    //   throw;
    // }
    // return Ok("alllw");
  }
}
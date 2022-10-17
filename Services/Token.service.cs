using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Blog.Services;

public static class Token
{
  public static string Generate()
  {
    var tokenHandler = new JwtSecurityTokenHandler();
    var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Contants.Token.Secret));
    var credencias = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
    var descriptor = new SecurityTokenDescriptor()
    {
      // Subject = user,
      SigningCredentials = credencias,
      Expires = DateTime.Now.AddDays(7)
    };

    var token = tokenHandler.CreateToken(descriptor);

    return tokenHandler.WriteToken(token);
  }
}
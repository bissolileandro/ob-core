using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using ob.core.application.Models;
using ob.core.domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace ob.core.api.Service
{
    public class TokenService
    {
        public static object GenerateTokenUsuario(UsuarioModel usuario)
        {
            var key = Encoding.ASCII.GetBytes(Key.Secret);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                      new Claim("usuarioId", usuario.Id.ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            var tokenString = tokenHandler.WriteToken(token);

            return new
            {
                token = tokenString
            };
        }
        public static TokenDeAcessoModel GenerateTokenSistema(SistemaModel sistema)
        {
            var key = Encoding.ASCII.GetBytes(Key.Secret);
            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                      new Claim("sistemaChave", sistema.ChaveDeAcesso.ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(12),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            var tokenString = tokenHandler.WriteToken(token);
            var retorno = new TokenDeAcessoModel()
            {
                Token = tokenString
            };

            return retorno;
        }
        public static TokenDeAcessoValidadoModel ValidateToken(TokenDeAcessoModel authToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = GetValidationParameters();

            SecurityToken validatedToken;
            IPrincipal principal = tokenHandler.ValidateToken(authToken.Token, validationParameters, out validatedToken);

            return new TokenDeAcessoValidadoModel()
            {
                Token = authToken.Token,
                Validado = true
            };
        }

        public static int ObterIdUsuario(TokenDeAcessoModel token)
        {
            var key = Encoding.ASCII.GetBytes(Key.Secret);
            var tokenHandler = new JwtSecurityTokenHandler();


            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };

            try
            {
                ClaimsPrincipal claimsPrincipal = tokenHandler.ValidateToken(token.Token, tokenValidationParameters, out SecurityToken validatedToken);

                var id = 0;
                int.TryParse(claimsPrincipal.FindFirst("usuarioId").Value, out id);

                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }


        private static TokenValidationParameters GetValidationParameters()
        {
            var key = Encoding.ASCII.GetBytes(Key.Secret);
            return new TokenValidationParameters()
            {
                ValidateLifetime = false, 
                ValidateAudience = false, 
                ValidateIssuer = false,   
                IssuerSigningKey = new SymmetricSecurityKey(key) 
            };
        }
    }
}

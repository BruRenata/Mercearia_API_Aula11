using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services;
using Domain;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace Mercearia_Produtos_API.Controllers
{
    public class UsuarioController : ControllerBase
    {
        private UsuarioService usuarioService = new Services.UsuarioService();

        [HttpGet]
        [Route("[controller]")]
        [Authorize]
        public IActionResult GetAll()
        {
            return Ok(usuarioService.GetAll());
        }

        [HttpGet]
        [Route("[controller]/{id}")]
        [Authorize]
        public IActionResult Get(int id)
        {
            return Ok(usuarioService.GetById(id));
        }

        [HttpPost]
        [Route("[controller]")]
        [Authorize]
        public IActionResult Create([FromBody] Usuario cliente)
        {
            try
            {
                usuarioService.Create(cliente);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("[controller]")]
        [Authorize]
        public IActionResult Update([FromBody] Usuario usuario)
        {
            try
            {
                usuarioService.Update(usuario);
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("[controller]/{id}")]
        [Authorize]
        public IActionResult DeleteByID(int id)
        {
            try
            {
                usuarioService.DeleteByID(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("[controller]/authenticate")]
        public IActionResult AutorizaUsuario([FromBody] Usuario usuario)
        {
            try
            {
                string token = null;
                if (usuario.login == "joao.zinho" && usuario.senha == "123456789")
                {
                    token = generateJwtToken(usuario);
                }

                if (token == null)
                {
                    return BadRequest(new { message = "Aluno incorrete ou não cadastrado" });
                }
                else
                {
                    HttpContext.Session.SetString("Token", token);
                }
                return Ok(new { message = token});
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("[controller]/token")]
        [Authorize]
        public IActionResult token()
        {
            return Ok(HttpContext.Session.GetString("Token"));
        }

        private string generateJwtToken(Usuario usuario)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("1234567890123456");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("ID", usuario.ID.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}

using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Collections.Generic;

namespace Mercearia_Produtos_API.Controllers
{
    public class ClienteController : ControllerBase
    {
        private ClienteService clienteService = new ClienteService();

        [HttpGet]
        [Route("[controller]")]
        [Authorize]
        public IEnumerable<Cliente> GetAll()
        {
            return clienteService.GetAll();
        }

        [HttpGet]
        [Route("[controller]/{id}")]
        [Authorize]
        public Cliente Get(int id)
        {
            return clienteService.GetById(id);
        }

        [HttpPost]
        [Route("[controller]")]
        [Authorize]
        public void Create([FromBody] Cliente cliente)
        {
            clienteService.Create(cliente);
        }

        [HttpPut]
        [Route("[controller]")]
        [Authorize]
        public void Update([FromBody] Cliente cliente)
        {
            clienteService.Update(cliente);   
        }

        [HttpDelete]
        [Route("[controller]/{id}")]
        [Authorize]
        public void DeleteByID(int id)
        {
            clienteService.DeleteByID(id);
        }
    }

    

}

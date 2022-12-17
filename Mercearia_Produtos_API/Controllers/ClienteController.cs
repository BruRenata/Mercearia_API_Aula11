using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Collections.Generic;

namespace Mercearia_Produtos_API.Controllers
{
    public class ClienteController
    {
        private ClienteService clienteService = new ClienteService();

        [HttpGet]
        [Route("[controller]")]
        public IEnumerable<Cliente> GetAll()
        {
            return clienteService.GetAll();
        }

        [HttpGet]
        [Route("[controller]/{id}")]
        public Cliente Get(int id)
        {
            return clienteService.GetById(id);
        }

        [HttpPost]
        [Route("[controller]")]
        public void Create([FromBody] Cliente cliente)
        {
            clienteService.Create(cliente);
        }

        [HttpPut]
        [Route("[controller]")]
        public void Update([FromBody] Cliente cliente)
        {
            clienteService.Update(cliente);   
        }

        [HttpDelete]
        [Route("[controller]/{id}")]
        public void DeleteByID(int id)
        {
            clienteService.DeleteByID(id);
        }
    }

    

}

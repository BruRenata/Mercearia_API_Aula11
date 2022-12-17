using Domain;
using Infra.Data;
using System;
using System.Collections.Generic;

namespace Services
{
    public class ClienteService
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        public IEnumerable<Cliente> GetAll()
        {
            return clienteRepository.GetAll();
        }

        public Cliente GetById(int id)
        {
            return clienteRepository.GetById(id);
        }

        public void Create(Cliente cliente)
        {
            clienteRepository.AddCliente(cliente);
        }

        public void Update(Cliente cliente)
        {
            clienteRepository.UpdateCliente(cliente);
        }

        public void DeleteByID(int id)
        {
            clienteRepository.DeleteClienteById(id);
        }
    }
}

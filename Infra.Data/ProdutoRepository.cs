using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data
{
    public class ProdutoRepository
    {
        public List<Produto> GetAll()
        {
            return null;
        }

        public Produto GetById(int id)
        {
            return null;
        }

        public List<Produto> Get(Func<Produto, bool> filter)
        {
            return null;
        }

        public void AddProduto(Produto produto)
        {
        }

        public void UpdateProduto(Produto produto)
        {
            
        }

        public void DeleteProdutoById(int id)
        {
            
        }
    }
}

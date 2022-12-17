using Domain;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProdutoService
    {
        private ProdutoRepository produtoRepository = new ProdutoRepository();

        public IEnumerable<Produto> GetAll()
        {
            return produtoRepository.GetAll();
        }

        public Produto GetById(int id)
        {
            return produtoRepository.GetById(id);
        }

        public void Create(Produto produto)
        {
            produtoRepository.AddProduto(produto);
        }

        public void UpdateProduto(Produto produto)
        {
            produtoRepository.UpdateProduto(produto);
        }

        public void DeleteProdutoById(int id)
        {
            produtoRepository.DeleteProdutoById(id);
        }
    }
}

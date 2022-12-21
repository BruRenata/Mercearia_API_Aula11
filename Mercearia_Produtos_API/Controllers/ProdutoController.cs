using Domain;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Collections.Generic;

namespace Mercearia_Produtos_API.Controllers
{
    public class ProdutoController : ControllerBase
    {

        private ProdutoService produtoService = new ProdutoService();

        [HttpGet]
        [Route("[controller]")]
        public IEnumerable<Produto> GetAll()
        {
            return produtoService.GetAll();
        }

        [HttpGet]
        [Route("[controller]/{id}")]
        public Produto Get(int id)
        {
            return produtoService.GetById(id);
        }

        [HttpPost]
        [Route("[controller]")]
        public void Create([FromBody] Produto produto)
        {
            produtoService.Create(produto);
        }

        [HttpPut]
        [Route("[controller]")]
        public void Update([FromBody] Produto produto)
        {
            produtoService.UpdateProduto(produto);
        }

        [HttpDelete]
        [Route("[controller]/{id}")]
        public void Delete(int id)
        {
            produtoService.DeleteProdutoById(id);
        }
    }
}

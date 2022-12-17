using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Produto
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public DateTime dataVencimento { get; set; }
        public double preco { get; set; }
        public string unid { get; set; }
        public int quantEstoque { get; set; }
    }
}

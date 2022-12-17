using System;

namespace Domain
{
    public class Cliente
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public Endereco enderecoCliente { get; set; }

        public struct Endereco
        {
            public string rua { get; set; }
            public int numero { get; set; }
            public string bairro { get; set; }
            public string cidade { get; set; }
            public string UF { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Pessoa
    {
        public Guid PessoaId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Telefone> Telefones { get; set; }
    }
}
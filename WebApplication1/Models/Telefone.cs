using System;

namespace WebApplication1.Models
{
    public class Telefone
    {
        public Guid TelefoneId { get; set; }
        public string Numero { get; set; }
        public string DDD { get; set; }

        public Guid PessoaId { get; set; }
        public virtual Pessoa  Pessoa { get; set; }
    }
}
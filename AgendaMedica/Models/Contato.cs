using System.ComponentModel.DataAnnotations;

namespace AgendaMedica.Models
{
    public class Contato
    {
        public Contato()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [StringLength(250), MinLength(3)]
        public string Nome { get; set; }

        [StringLength(250), MinLength(10), MaxLength(11)]
        public string Telefone { get; set; }
    }
}

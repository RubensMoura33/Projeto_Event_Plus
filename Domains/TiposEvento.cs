using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_manha.Domains
{

    [Table (nameof(TiposEvento))]
    public class TiposEvento
    {
        [Key]
        public Guid IdTipoEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage ="Titulo do evento obrigatorio")]
        public string? TituloTipoEvento { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_manha.Domains
{
    [Table (nameof(TiposUsuario))]
    public class TiposUsuario
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR (50)")]
        [Required(ErrorMessage = "Titulo do tipo de usuario obrigatorio")]
        public string? TituloTipoUsuario { get; set; }

    }
}

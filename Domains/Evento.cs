using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_manha.Domains
{
    [Table(nameof(Evento))]
    public class Evento
    {
        [Key]
        public Guid IdEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data do evento obrigatoria")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do evento obrigatorio")]
        public string? NomeEvento { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descricao do evento obrigatorio")]
        public string? Descricao { get; set; }

        //referencia tabela TiposEvento FOREIGN (FK)

        [Required(ErrorMessage = "O tipo do evento e obrigatorio")]
        public Guid IdTipoEevento { get; set; }

        [ForeignKey(nameof(IdTipoEevento))]

        public TiposEvento? TiposEvento { get; set; }

        //referencia tabela Instituicao
        [Required(ErrorMessage = "Instituicao obrigatoria")]
        public Guid IdInstituicao { get; set; }

        [ForeignKey(nameof(IdInstituicao))]
        
        public Instituicao? Instituicao { get; set;}

    }
    
}

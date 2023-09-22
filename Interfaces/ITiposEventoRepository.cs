using webapi.event_manha.Domains;

namespace webapi.event_manha.Interfaces
{
    public interface ITiposEventoRepository
    {
        void Cadastrar(TiposEvento tipoEvento);

        void Deletar(Guid id);

        List<TiposEvento> Listar();

        TiposEvento BuscarPorId(Guid id);

        void Atualizar(Guid id, TiposEvento tipoEvento);
    }
}

using webapi.event_manha.Domains;

namespace webapi.event_manha.Interfaces
{
    public interface IEventoRepository
    {
        void Cadastrar(Evento evento);

        void Deletar(Guid id);

        List<Evento> Listar();

        Evento BuscarPorId(Guid id);

        void Atualizar(Guid id, Evento evento);
    }
}

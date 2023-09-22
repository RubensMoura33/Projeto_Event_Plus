using webapi.event_manha.Domains;

namespace webapi.event_manha.Interfaces
{
    public interface IIntituicaoRepository
    {
        void Cadastrar(Instituicao instituicao);

        void Deletar(Guid id);

        List<Instituicao> Listar();

        Instituicao BuscarPorId(Guid id);

        void Atualizar(Guid id, Instituicao instituicao);
    }
}

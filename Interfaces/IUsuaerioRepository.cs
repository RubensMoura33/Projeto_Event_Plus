using webapi.event_manha.Domains;

namespace webapi.event_manha.Interfaces
{
    public interface IUsuaerioRepository
    {
        void Cadastrar(Usuario usuario);

        Usuario BuscarPorId(Guid id);

        Usuario BuscarPorEmailESenha (string email, string senha);
    }
}

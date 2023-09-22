using webapi.event_manha.Contexts;
using webapi.event_manha.Domains;
using webapi.event_manha.Interfaces;

namespace webapi.event_manha.Repositories
{
    public class InstituicaoRepository : IIntituicaoRepository
    {

        private EventContext? _eventContext;    

        public InstituicaoRepository()
        { 
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, Instituicao instituicao)
        {
            throw new NotImplementedException();
        }

        public Instituicao BuscarPorId(Guid id)
        {
            try
            {
                Instituicao instituicaoBuscada = _eventContext!.Instituicao.Select(u => new Instituicao
                {
                    IdInstituicao = u.IdInstituicao,
                    CNPJ = u.CNPJ,
                    Endereco = u.Endereco,
                    NomeFantasia = u.NomeFantasia

                }).FirstOrDefault(u => u.IdInstituicao == id)!;

                if (instituicaoBuscada != null)
                {
                    return instituicaoBuscada;
                }

                return null!;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Instituicao instituicao)
        {
            try
            {
                _eventContext!.Instituicao.Add(instituicao);
                _eventContext.SaveChanges();
            }
            catch (Exception )
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Instituicao> Listar()
        {
            throw new NotImplementedException();
        }
    }
}

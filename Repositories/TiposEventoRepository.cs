using webapi.event_manha.Contexts;
using webapi.event_manha.Domains;
using webapi.event_manha.Interfaces;

namespace webapi.event_manha.Repositories
{
    public class TiposEventoRepository : ITiposEventoRepository
    {
        private EventContext? _eventContext;  

        public TiposEventoRepository ()
        {
            _eventContext = new EventContext ();
        }
        public void Atualizar(Guid id, TiposEvento tipoEvento)
        {
            throw new NotImplementedException();
        }

        public TiposEvento BuscarPorId(Guid id)
        {
            TiposEvento tipoEventoBuscado = _eventContext!.TiposEvento.Select(U => new TiposEvento 
            {
            
            })
        }

        public void Cadastrar(TiposEvento tipoEvento)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposEvento> Listar()
        {
            throw new NotImplementedException();
        }
    }
}

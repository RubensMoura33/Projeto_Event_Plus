using webapi.event_manha.Contexts;
using webapi.event_manha.Domains;
using webapi.event_manha.Interfaces;

namespace webapi.event_manha.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private EventContext? _eventContext;

        public EventoRepository() 
        {
            _eventContext = new EventContext();
        }   
        
        public void Atualizar(Guid id, Evento evento)
        {
            throw new NotImplementedException();
        }

        public Evento BuscarPorId(Guid id)
        {
            try
            {
                Evento eventoBuscado = _eventContext!.Evento.Select(u => new Evento
                {
                    IdEvento = u.IdEvento,
                    DataEvento = u.DataEvento,
                    NomeEvento = u.NomeEvento,
                    Descricao = u.Descricao,

                    TiposEvento = new TiposEvento
                    {
                        IdTipoEvento = u.TiposEvento!.IdTipoEvento,
                        TituloTipoEvento = u.TiposEvento!.TituloTipoEvento
                    },

                    Instituicao = new Instituicao
                    {
                        IdInstituicao = u.Instituicao!.IdInstituicao,
                        NomeFantasia =u.Instituicao!.NomeFantasia
                    }

                }).FirstOrDefault(u => u.IdEvento == id)!;

                if (eventoBuscado != null)
                {
                    return eventoBuscado;
                }

                return null!;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Evento evento)
        {
            try
            {
                _eventContext!.Evento.Add(evento);
                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Evento> Listar()
        {
            throw new NotImplementedException();
        }
    }
}

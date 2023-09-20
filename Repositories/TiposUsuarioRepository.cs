﻿using webapi.event_manha.Contexts;
using webapi.event_manha.Domains;
using webapi.event_manha.Interfaces;

namespace webapi.event_manha.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly EventContext? _eventContext;

        public TiposUsuarioRepository()
        { 
        _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, TiposUsuario tipoUsuario)
        {
            throw new NotImplementedException();
        }

        public TiposUsuario BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            _eventContext.TiposUsuario.Add(tipoUsuario);
            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TiposUsuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}

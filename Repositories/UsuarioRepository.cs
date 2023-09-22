﻿using Microsoft.AspNetCore.Http.HttpResults;
using webapi.event_manha.Contexts;
using webapi.event_manha.Domains;
using webapi.event_manha.Interfaces;
using webapi.event_manha.Utils;

namespace webapi.event_manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EventContext? _eventContext;

        public UsuarioRepository()
        {
            _eventContext = new EventContext();
        }
        public Usuario BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = _eventContext!.Usuario.Select(u => new Usuario
                {
                    IdUsuario = u.IdUsuario,
                    NomeUsuario = u.NomeUsuario,
                    Email = u.Email,
                    Senha = u.Senha,
                    IdTipoUsuario = u.IdTipoUsuario,


                    TiposUsuario = new TiposUsuario
                    {
                        IdTipoUsuario = u.TiposUsuario!.IdTipoUsuario,
                        TituloTipoUsuario = u.TiposUsuario!.TituloTipoUsuario
                    }
                }).FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }

                }

                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _eventContext!.Usuario.Select(u => new Usuario
                {
                    IdUsuario = u.IdUsuario,
                    NomeUsuario = u.NomeUsuario,
                    Email = u.Email,
                    Senha = u.Senha,
                    IdTipoUsuario = u.IdTipoUsuario,


                    TiposUsuario = new TiposUsuario
                    {
                        IdTipoUsuario = u.TiposUsuario!.IdTipoUsuario,
                        TituloTipoUsuario = u.TiposUsuario!.TituloTipoUsuario
                    }
                }).FirstOrDefault(u => u.IdUsuario == id)!;

                if (usuarioBuscado != null)
                {
                    return usuarioBuscado;
                }

                return null!;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                _eventContext!.Usuario.Add(usuario);

                _eventContext.SaveChanges();
            }
            catch (Exception )
            {

                throw;
            }
        }
    }
}

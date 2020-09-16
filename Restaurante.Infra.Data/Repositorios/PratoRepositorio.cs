﻿using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorioss;
using Restaurante.Infra.Data.Contextos;

namespace Restaurante.Infra.Data.Repositorios
{
    public class PratoRepositorio : RepositorioBase<Prato>, IPratoRepositorio
    {
        public PratoRepositorio(Contexto contexto)
            : base(contexto)
        {
        }
    }
}

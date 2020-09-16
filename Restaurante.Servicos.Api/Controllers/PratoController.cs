﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;

namespace Restaurante.Servicos.Api.Controllers
{
   
        public class PratoController : ControllerBase<Prato, PratoDTO>
        {
            public PratoController(IPratoApp app)
                : base(app)
            { }
        }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Aplicacao.DTO
{
    public class PratoDTO : DTOBase
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public char Tamanho { get; set; }
        public string Dia { get; set; }

    }
}

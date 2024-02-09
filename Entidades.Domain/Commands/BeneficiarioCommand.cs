﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Domain.Commands
{
    public class BeneficiarioCommand
    {
        public int BeneficiarioId { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public long Cep { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Models
{
    public class ClienteDataModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public  string Telefone { get; set; }

        public string Email  { get; set; }

        public string CarteiraDeMotorista { get; set; }

        public string CartaoDeCredito { get; set; }

    }
}

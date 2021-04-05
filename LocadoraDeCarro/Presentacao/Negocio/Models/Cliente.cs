using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Models
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string CarteiraDeMotorista { get; private set; }
        public string CartaoDeCredito { get; private set; }

    }
}

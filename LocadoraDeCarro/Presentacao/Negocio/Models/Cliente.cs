using Negocio.RepositorioDados;
using Negocio.ServicoNegocio.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Models
{
    public class Cliente
    {
        private readonly IClienteServico _clienteServico;

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string CarteiraDeMotorista { get; private set; }
        public string CartaoDeCredito { get; private set; }

        public Cliente()
        {

        }

            public Cliente(int id, string nome, string endereco, string telefone, string email, string carteirademotorista, string cartaodecredito, IClienteServico clienteServico)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            CarteiraDeMotorista = carteirademotorista;
            CartaoDeCredito = cartaodecredito;
            
            _clienteServico = clienteServico;
        }

        public bool EmailEstaDuplicado()
        {
            return _clienteServico.obterClientePorEmail(this.Email) != null;
        }

    }
}
